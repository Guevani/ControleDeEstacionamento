using ControleDeEstacionamento.Classes;
using System;
using System.Windows.Forms;

namespace ControleDeEstacionamento.Formulários
{
    public partial class Entrada : Form
     {
        DateTime data1,data2;
        //private Vaga _Vaga;
        public Entrada()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            
        }

        public void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            var V = new Classes.Veiculos();
            var vaga = new Classes.Vaga();
            var esta = new Classes.Estacionamento();


            
            //dados do veiculo
            V.Modelo = tbModelo.Text;
            var valida = 
            V.Placa = tbPlaca.Text;
            vaga.Id = int.Parse(comboBox1.Text);
            tbEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            data1 = DateTime.Now;
           


            esta.Id_Veiculo = V.Placa;
            esta.Id_Vaga = V.ID;

            //verificar se ta true ou nao  

           if(dataGridView1.Rows[vaga.Id - 1].Cells[1].Value.ToString() == "True")
            {
                MessageBox.Show("Vaga Ocupada");
            }
           else
            {
                Banco.VeiculosDao.Cadastrar(V);
                Banco.VagasDAO.True(vaga);
                MessageBox.Show("Entrada feita com sucesso");
            }
            
                                          
                     
            //clear dados 
            tbEntrada.Text = "";
            tbPlaca.Text = "";
            tbModelo.Text = "";
            

            AtualizarDgv();
                                                                     }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarDgv()
        {
            dgvListartudo.DataSource = Banco.EstacionamentoDao.ListarTudo();
            dataGridView1.DataSource = Banco.VagasDAO.ListarTudo();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Descobrir o número da Linha da célula clicada:
            int numeroLinha = dataGridView1.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dataGridView1.Rows[numeroLinha];

            // Variaveis que vão receber os valores da linha selecionada:
            
             var Vaga = int.Parse(linha.Cells[0].Value.ToString());
            


            // Atribuir o valores das células aos txb do editar:
            cbSaida.Text = Convert.ToString (Vaga);
            
            
        }

        public void btSaida_Click(object sender, EventArgs e)
        {
            var v = new Classes.Veiculos();
            var saida = new Classes.Vaga();


            v.Placa = tbPlacaSaida.Text;
            v.Saida = DateTime.Now;
            tbSaidaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            data2 = DateTime.Now;
            saida.Id = int.Parse(cbSaida.Text);
            Banco.VeiculosDao.Saida(v);
            Banco.VagasDAO.False(saida);
            
            lblvalor.Text = Convert.ToString( data2 - data1);


            AtualizarDgv();



        }

        private void lblvalor_Click(object sender, EventArgs e)
        {
           
        }
    }
}
