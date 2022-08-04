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
    public class VagasDAO
    {

        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM vaga ";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public static bool True(Vaga vaga)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "UPDATE vaga SET Situacao = '1' WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", vaga.Id);


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
        public static bool False(Vaga vaga)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "UPDATE vaga SET Situacao = '0' WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", vaga.Id);


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
    }
}
