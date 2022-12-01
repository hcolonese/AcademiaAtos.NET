using System.Data;
using System.Data.SqlClient;

namespace ExercicioAulaBancoSQLInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtb_nome.Text;
            p.peso = float.Parse(txtb_peso.Text);

            if (p.gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir pessoa!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM pessoas;";

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPessoas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas where nome = '" + txtb_busca.Text + "'");

            dgvPessoas.DataSource = dt;
        }
    }
}