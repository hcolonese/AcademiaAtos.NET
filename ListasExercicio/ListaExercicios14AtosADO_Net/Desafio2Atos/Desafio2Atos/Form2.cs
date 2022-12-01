using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Desafio2Atos
{
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }
        private void carregarDgvCliente()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            try
            {
                dt = bd.ExecutaConsulta("SELECT * FROM Cliente;");
                dgv_cliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarCliente.Enabled = false;
                bd.FecharConexao();
            }
        }
        private void btn_conectarCliente_Click(object sender, EventArgs e)
        {
            carregarDgvCliente();
            panel_consultaCliente.Enabled = true;
            panel_addCliente.Enabled = true;
            panel_editDeleteCliente.Enabled = true;
            btn_gerarPdfCliente.Enabled = true;
        }

        private void btn_filtrarCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            //Criando sql de filtro
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Cliente WHERE nome = @nomeCliente;";
                cmd.Parameters.Add("@nomeCliente", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txt_buscaNomeCliente.Text;

                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgv_cliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        private void btn_limparFiltroCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta("SELECT * FROM Cliente;");
            txt_buscaNomeCliente.Text = "";
            dgv_cliente.DataSource = dt;
        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            //Criando sql de insert
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Cliente values (@nome, @email, @cidade, @cpf);";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@cidade", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txt_addNomeCliente.Text;
                cmd.Parameters[1].Value = txt_addEmailCliente.Text;
                cmd.Parameters[2].Value = txt_addCidadeCliente.Text;
                cmd.Parameters[3].Value = txt_addCpfCliente.Text;
                cmd.ExecuteNonQuery();

                txt_addNomeCliente.Text = "";
                txt_addEmailCliente.Text = "";
                txt_addCidadeCliente.Text = "";
                txt_addCpfCliente.Text = "";
                carregarDgvCliente();

                MessageBox.Show("Adicionado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_cliente.Rows[indexDgv];
                int idCliente = int.Parse(selectedRow.Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Cliente " +
                    "WHERE idCliente=@idCliente;";
                cmd.Parameters.Add("@idCliente", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idCliente;
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txt_editIdCliente.Text = reader["idCliente"].ToString();
                txt_editNomeCliente.Text = reader["nome"].ToString();
                txt_editEmailCliente.Text = reader["email"].ToString();
                txt_editCidadeCliente.Text = reader["cidade"].ToString();
                txt_editCpfCliente.Text = reader["cpf"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        private void btn_editCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            //Criando sql de update
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Cliente SET  nome=@nome, email=@email, cidade=@cidade, " +
                    "cpf=@cpf WHERE idCliente=@idCliente;";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@cidade", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@idCliente", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editNomeCliente.Text;
                cmd.Parameters[1].Value = txt_editEmailCliente.Text;
                cmd.Parameters[2].Value = txt_editCidadeCliente.Text;
                cmd.Parameters[3].Value = txt_editCpfCliente.Text;
                cmd.Parameters[4].Value = txt_editIdCliente.Text;
                cmd.ExecuteNonQuery();

                txt_editIdCliente.Text = "";
                txt_editNomeCliente.Text = "";
                txt_editEmailCliente.Text = "";
                txt_editCidadeCliente.Text = "";
                txt_editCpfCliente.Text = "";
                carregarDgvCliente();
                MessageBox.Show("Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {

                bd.FecharConexao();
            }
        }

        private void btn_deleteCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            //Criando sql de delete
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Cliente WHERE idCliente=@idCliente;";
                cmd.Parameters.Add("@idCliente", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editIdCliente.Text;
                cmd.ExecuteNonQuery();

                txt_editNomeCliente.Text = "";
                txt_editEmailCliente.Text = "";
                txt_editCidadeCliente.Text = "";
                txt_editCpfCliente.Text = "";
                carregarDgvCliente();
                MessageBox.Show("Deletado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {

                bd.FecharConexao();
            }
        }

        private void btn_gerarPdfCliente_Click(object sender, EventArgs e)
        {
            if (dgv_cliente.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "ClientesDesafio2Atos.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgv_cliente.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgv_cliente.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgv_cliente.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
