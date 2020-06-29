using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.ID_Cli1 = Convert.ToInt32(dados["ID_Cli"].ToString());
                    cliente.Nome_Cli1 = dados["Nome_Cli"].ToString();
                    cliente.CPF_Cli1 = dados["CPF_Cli"].ToString();
                    cliente.Ender_Cli1 = dados["Ender_Cli"].ToString();
                    cliente.Tel_Cli1 = dados["Tel_Cli"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na busca do registro");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }


        public void SelectByNome(){
        
        }

        public void Insert(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Clientes VALUES (@ID_Cli, @Nome_Cli, @CPF_Cli, @Ender_Cli, @Tel_Cli);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID_Cli", clientes.ID_Cli1);
            cmd.Parameters.AddWithValue("@Nome_Cli", clientes.Nome_Cli1);
            cmd.Parameters.AddWithValue("@CPF_Cli", clientes.CPF_Cli1);
            cmd.Parameters.AddWithValue("@Ender_Cli", clientes.Ender_Cli1);
            cmd.Parameters.AddWithValue("@Tel_Cli", clientes.Tel_Cli1);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }


        public void Update(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET ID_Cli=@ID_Cli, Nome_Cli=@Nome_Cli, CPF_Cli=@CPF_Cli, Ender_Cli=@Ender_Cli, Tel_Cli=@Tel_Cli ";
            sql += "WHERE ID_Cli=@ID_Cli;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID_Cli", clientes.ID_Cli1);
            cmd.Parameters.AddWithValue("@Nome_Cli", clientes.Nome_Cli1);
            cmd.Parameters.AddWithValue("@CPF_Cli", clientes.CPF_Cli1);
            cmd.Parameters.AddWithValue("@Ender_Cli", clientes.Ender_Cli1);
            cmd.Parameters.AddWithValue("@Tel_Cli", clientes.Tel_Cli1);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int ID_Cli)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes WHERE ID_Cli=@ID_Cli;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID_Cli", ID_Cli);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na exclusão do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
