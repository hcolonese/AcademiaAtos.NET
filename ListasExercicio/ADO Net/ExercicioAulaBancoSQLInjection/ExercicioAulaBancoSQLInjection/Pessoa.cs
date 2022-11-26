using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAulaBancoSQLInjection
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public float peso;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO pessoas values (@nome, @peso);";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@peso", System.Data.SqlDbType.VarChar);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = peso;

            try
            {
                cmd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
