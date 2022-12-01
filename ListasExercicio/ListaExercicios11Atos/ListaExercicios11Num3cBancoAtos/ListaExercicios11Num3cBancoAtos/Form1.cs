using System.Configuration;
using System.Data.SqlClient;

namespace ListaExercicios11Num3cBancoAtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["CriptoMoedaDBString"].ConnectionString; 
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            loadListView();
            btn_cadastrar.Enabled = true;
        }

        private void loadListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                string sqlSelect = "SELECT [Moeda].idMoeda, [Moeda].sigla, [Moeda].nome, [Moeda].valorUnidade " +
                    "FROM Moeda";
                SqlCommand cmd = new SqlCommand(sqlSelect, conexao);

                listView_Moeda.Items.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    listView_Moeda.Items.Add(reader["idMoeda"].ToString());
                    listView_Moeda.Items[i].SubItems.Add(reader["sigla"].ToString());
                    listView_Moeda.Items[i].SubItems.Add(reader["nome"].ToString());
                    listView_Moeda.Items[i].SubItems.Add(reader["valorUnidade"].ToString());
                    i++;
                }
                conexao.Close();
                btn_conectar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Erro");
            }
        }


        private void listView_Moeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Moeda.SelectedItems.Count == 0)
                return;
            int idSelected = int.Parse(listView_Moeda.SelectedItems[0].Text);

            btn_deletar.Enabled = true;
            btn_editar.Enabled = true;
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idMoeda, sigla, nome, valorUnidade FROM " +
                    "Moeda WHERE idMoeda = @idMoeda;";
                cmd.Parameters.Add("@idMoeda", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idSelected;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txtb_idMoeda.Text = reader["idMoeda"].ToString();
                txtb_siglaMoeda.Text = reader["sigla"].ToString();
                txtb_nomeMoeda.Text = reader["nome"].ToString();
                txtb_valorMoeda.Text = reader["valorUnidade"].ToString();

                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            panel_Cadastro.Enabled = true;
            txtb_idMoeda.Text = "";
            txtb_siglaMoeda.Text = "";
            txtb_nomeMoeda.Text = "";
            txtb_valorMoeda.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            if(txtb_idMoeda.Text != "")
            {
                int idSelected = int.Parse(listView_Moeda.SelectedItems[0].Text);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "UPDATE Moeda SET  sigla=@sigla, nome=@nome, valorUnidade =@valUnitario " +
                        "WHERE idMoeda=@idMoeda";
                    cmd.Parameters.Add("@sigla", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@valUnitario", System.Data.SqlDbType.Float);
                    cmd.Parameters.Add("@idMoeda", System.Data.SqlDbType.Int);
                    cmd.Parameters[0].Value = txtb_siglaMoeda.Text;
                    cmd.Parameters[1].Value = txtb_nomeMoeda.Text;
                    cmd.Parameters[2].Value = txtb_valorMoeda.Text;
                    cmd.Parameters[3].Value = idSelected;
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                    btn_deletar.Enabled = false;
                    btn_editar.Enabled = false;
                    MessageBox.Show("Moeda Editada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                }
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO Moeda values (@sigla, @nome, @valUnitario);";
                    cmd.Parameters.Add("@sigla", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@valUnitario", System.Data.SqlDbType.Float);
                    cmd.Parameters[0].Value = txtb_siglaMoeda.Text;
                    cmd.Parameters[1].Value = txtb_nomeMoeda.Text;
                    cmd.Parameters[2].Value = txtb_valorMoeda.Text;
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                    txtb_idMoeda.Text = "";
                    txtb_siglaMoeda.Text = "";
                    txtb_nomeMoeda.Text = "";
                    txtb_valorMoeda.Text = "";
                    MessageBox.Show("Moeda criada com sucesso!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
                }
            }
            loadListView();
            panel_Cadastro.Enabled = false;
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();

            try
            {
                int idSelected = int.Parse(listView_Moeda.SelectedItems[0].Text);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Moeda WHERE idMoeda = @idMoeda;";
                cmd.Parameters.Add("@idMoeda", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idSelected;
                cmd.ExecuteNonQuery();

                conexao.Close();
                MessageBox.Show("Moeda deletada com sucesso!");
                loadListView();
                txtb_idMoeda.Text = "";
                txtb_siglaMoeda.Text = "";
                txtb_nomeMoeda.Text = "";
                txtb_valorMoeda.Text = "";
                btn_deletar.Enabled = false;
                btn_editar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            panel_Cadastro.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idMoeda, nome, valorUnidade FROM Moeda " +
                    "WHERE sigla=@sigla;";
                cmd.Parameters.Add("@sigla", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txtb_buscaMoeda.Text;
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txtb_idBusca.Text = reader["idMoeda"].ToString();
                txtb_nomeBusca.Text = reader["nome"].ToString();
                txtb_valorBusca.Text = reader["valorUnidade"].ToString();
                conexao.Close();
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Moeda não existente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }
    }
}