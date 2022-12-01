using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsADONet;

namespace PrimeiroWSADONET
{
    internal class Empregado
    {
        public string nome;
        public string idGerente;
        public string funcao;
        public string idDepto;
        public string dataAdmissao;
        public string salario;
        public string comissao;

        public Empregado(string nome, string idGerente, string funcao, string idDepto, string dataAdmissao, string salario, string comissao)
        {
            this.nome = nome;
            
            if (idGerente == "")
            {
                this.idGerente = null;
            }
            else
                this.idGerente = idGerente;
            this.funcao = funcao;
            this.idDepto = idDepto;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
            this.comissao = comissao;
        }

        public bool gravarEmpregado()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Empregado values (@nome, @idGerente, @funcao, @idDepto, @dataAdmissao, @salario, @comissao);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", SqlDbType.Int);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar);
            cmd.Parameters.Add("@idDepto", SqlDbType.Int);//SqlDbType.Int
            cmd.Parameters.Add("@dataAdmissao", SqlDbType.Date);
            cmd.Parameters.Add("@salario", SqlDbType.Int);
            cmd.Parameters.Add("@comissao", SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idGerente;
            cmd.Parameters[2].Value = funcao;
            cmd.Parameters[3].Value = idDepto;
            cmd.Parameters[4].Value = dataAdmissao;
            cmd.Parameters[5].Value = salario;
            cmd.Parameters[6].Value = comissao;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                MessageBox.Show(e.Message);
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }
    }
}
