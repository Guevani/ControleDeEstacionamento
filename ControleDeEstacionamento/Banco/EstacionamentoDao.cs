using ControleDeEstacionamento.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstacionamento.Banco
{
    internal class EstacionamentoDao
    {
        public static bool Cadastro (Estacionamento esta )
        {
            string comando;
            comando = "INSERT INTO estacionamento ( Id_Vaga, Id_Veiculo, Valor) " +
                "VALUES(@Id_Vaga, @Id_Veiculo, @Valor)";



            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instaciar o objeto do Tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@Id_Vaga", esta.Id_Vaga);
            cmd.Parameters.AddWithValue("@Id_Veiculo",esta.Id_Veiculo );
            cmd.Parameters.AddWithValue("@Valor",esta.Valor );
             cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;

            
            }  
        }
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = " SELECT * FROM `veiculos` WHERE 1";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public static DataTable Listar()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM `estacionamento`" ;
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

    }

}
