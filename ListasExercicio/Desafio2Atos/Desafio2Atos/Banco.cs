using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2Atos
{
    internal class Banco
    {
        private string conec = "Data Source=localhost; Initial Catalog=desafio_2;" +
            "User ID=sa; password=123456; language=Portuguese";
        private SqlConnection cn;

        private void Conexao()
        {
            cn= new SqlConnection(conec);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public DataTable ExecutaConsulta(string sql)
        {
            try
            {
                AbrirConexao();
                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
