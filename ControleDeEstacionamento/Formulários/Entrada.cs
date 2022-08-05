using ControleDeEstacionamento.Classes;
using System;
using System.Windows.Forms;

namespace ControleDeEstacionamento.Formulários
{
    public partial class Entrada : Form
    {
        DateTime data1, data2;
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
        private int obterIddaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }

        public void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            var V = new Classes.Veiculos();
            var vaga = new Classes.Vaga();
            var esta = new Classes.Estacionamento();



            //dados do veiculo
            V.Modelo = tbModelo.Text;
            //verificar se a 6 caracteres no placa
            var valida = tbPlaca.Text.Length < 6 || tbPlaca.Text.Length >6;
           if(valida)
            {
                MessageBox.Show("Placa Invalida");
            }
            else 
            {

                //caso a placa esteja dentro do padrao continuar com cadastro dentro do BD
                V.Placa = tbPlaca.Text;
                vaga.Id = int.Parse(comboBox1.Text);
                V.Id_VAGA = vaga.Id;
                tbEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                data1 = DateTime.Now;
                   esta.Id_Veiculo = V.Placa;
                esta.Id_Vaga = V.ID;

                //verificar se ta ocupada

                if (dataGridView1.Rows[vaga.Id - 1].Cells[1].Value.ToString() == "True")
                {
                    MessageBox.Show("Vaga Ocupada");
                }
                else
                {
                    Banco.VeiculosDao.Cadastrar(V);
                    Banco.VagasDAO.True(vaga);
                    MessageBox.Show("Entrada feita com sucesso");
                }

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
           
            dgvDADOS.DataSource = Banco.EstacionamentoDao.ListarTudo();
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
            cbSaida.Text = Convert.ToString(Vaga);


        }






        public void btSaida_Click(object sender, EventArgs e)
        {
            //criar um objeto
            var v = new Classes.Veiculos();
            var saida = new Classes.Vaga();

            //registrar no BD
            v.Placa =tbPlacaSaida.Text;
            v.Saida = DateTime.Now;
            tbSaidaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            data2 = DateTime.Now;

            
            var valida = cbSaida.SelectedIndex == -1;
            if(valida)
            {
                MessageBox.Show("Dados invalidos");
            }
            else
            {
                saida.Id = int.Parse(cbSaida.Text);
                Banco.VeiculosDao.Saida(v);
                Banco.VagasDAO.False(saida);
                var diffInSeconds = (data2 - data1).TotalSeconds;

            }


            AtualizarDgv();



        }

        private void dgvDADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Descobrir o número da Linha da célula clicada:
            int numeroLinha = dgvDADOS.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvDADOS.Rows[numeroLinha];

            // Variaveis que vão receber os valores da linha selecionada:

            var Vaga = int.Parse(linha.Cells[1].Value.ToString());
                var id = int.Parse(linha.Cells[5].Value.ToString());



            // Atribuir o valores das células aos txb do editar:
            tbPlacaSaida.Text=Convert.ToString(Vaga);
            cbSaida.Text = Convert.ToString(id);
        }

        private void lblvalor_Click(object sender, EventArgs e)
            {
                    
            }
       }
   }
  

