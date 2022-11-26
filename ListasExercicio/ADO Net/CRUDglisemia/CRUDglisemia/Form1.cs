using System.Configuration;
using System.Data.SqlClient;
namespace CRUDglisemia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        private int idSelected = 0;
        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, " +
                    "[MedidaGlicemia].dataMedida, [Paciente].nome, [Paciente].idPaciente " +
                    "FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                string[] vetorDados;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    vetorDados = leitor["dataMedida"].ToString().Split(' ');
                    listView_medidasGlicemias.Items[i].SubItems.Add(vetorDados[0]);
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
                conexao.Close();
                btn_conectar.Enabled = false;
                //MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            btn_cadastrar.Enabled = true;
            btn_deletar.Enabled = true;
            btn_editar.Enabled = true;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            panelCadastro.Enabled = true;
            txtb_idMedida.Text = "";
            txtb_valGlicemia.Text = "";
            txtb_dataMedicao.Text = "";
            txtb_idPaciente.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txtb_idMedida.Text != "")
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                try
                {
                    //Pegando o valor das variáveis
                    int idMedidaGlicemia = int.Parse(txtb_idMedida.Text);
                    int valorGlicemia = int.Parse(txtb_valGlicemia.Text);
                    string dataMedida = txtb_dataMedicao.Text;
                    int idPaciente = int.Parse(txtb_idPaciente.Text);

                    //Criando sql de update
                    string sqlUpdate = "UPDATE MedidaGlicemia SET valorGlicemia = @valorGlicemia, dataMedida = @dataMedida, " +
                        "idPaciente = @idPaciente WHERE idMedidaGlicemia = @idMedidaGlicemia";
                    SqlCommand cmd = new SqlCommand(sqlUpdate, conexao);
                    cmd.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                    cmd.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    cmd.Parameters.AddWithValue("@dataMedida", dataMedida);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                    cmd.ExecuteNonQuery();
                    carregarListView();
                    panelCadastro.Enabled = false;
                    MessageBox.Show("Atualizado com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                }
            }
            else
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                try
                {
                    //Obtendo valor das variáveis
                    int valorGlicemia = int.Parse(txtb_valGlicemia.Text);
                    string dataMedicao = txtb_dataMedicao.Text;
                    int idPaciente = int.Parse(txtb_idPaciente.Text);
                    string sqlInsert = "INSERT INTO MedidaGlicemia (valorGlicemia, dataMedida, idPaciente) VALUES" +
                            "(@valorGlicemia, @dataMedicao, @idPaciente)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, conexao);
                    cmd.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    cmd.Parameters.AddWithValue("@dataMedicao", dataMedicao);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criado com Sucesso!");
                    conexao.Close();

                    //Recarregar a listView
                    carregarListView();
                    panelCadastro.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                }
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //Pegando o id da medida selecionada
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //Criando o sql de delete
                string sqlDelete = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";
                SqlCommand cmd = new SqlCommand(sqlDelete,conexao);
                cmd.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                cmd.ExecuteNonQuery();
                conexao.Close();
                carregarListView();

                btn_cadastrar.Enabled = true;
                btn_deletar.Enabled = false;

                MessageBox.Show("Deletado com Sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void listView_medidasGlicemias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_deletar.Enabled = true;
            if (listView_medidasGlicemias.SelectedItems.Count == 0)
                return;
            idSelected = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);
            atualizaPainel();
        }

        private void atualizaPainel()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                int idMedidaGlicemia = idSelected;

                //gerar sentenças SQL
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia " +
                    "WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                SqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();
                txtb_idMedida.Text = leitor["idMedidaGlicemia"].ToString();
                txtb_valGlicemia.Text = leitor["valorGlicemia"].ToString();

                string[] vetorDados;
                vetorDados = leitor["dataMedida"].ToString().Split();
                txtb_dataMedicao.Text = vetorDados[0];
                txtb_idPaciente.Text = leitor["idPaciente"].ToString();

                conexao.Close();

                //recarregar ListView


            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            panelCadastro.Enabled = true;
        }
    }
}