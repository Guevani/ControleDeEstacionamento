using ControleDeEstacionamento.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstacionamento.Banco
{
    public class VeiculosDao
    {
        public static bool Cadastrar(Veiculos v)
        {
            string comando;
            comando = "INSERT INTO `veiculos`( `Placa`, Modelo, ID_Vaga )"
                +
               " VALUES(@Placa,@Modelo,@Id_vaga )";




            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instaciar o objeto do Tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@Placa", v.Placa);
            cmd.Parameters.AddWithValue("@Modelo", v.Modelo);
            cmd.Parameters.AddWithValue("@Id_vaga", v.Id_VAGA);


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

        public static bool Saida(Veiculos v)
        {
            string comando;
            comando = "UPDATE `veiculos` SET Saida = @Saida WHERE Placa = @Placa";



            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instaciar o objeto do Tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@Saida", v.Saida);
            cmd.Parameters.AddWithValue("@Placa", v.Placa);


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

