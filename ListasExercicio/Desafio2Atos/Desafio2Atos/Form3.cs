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

namespace Desafio2Atos
{
    public partial class form_fornecedor : Form
    {
        public form_fornecedor()
        {
            InitializeComponent();
        }

        
        private void carregarDgvFornecedor()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            try
            {
                dt = bd.ExecutaConsulta("SELECT * FROM Fornecedor;");
                dgv_fornecedor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarFornecedor.Enabled = false;
                bd.FecharConexao();
            }
        }

        private void btn_conectarFornecedores_Click(object sender, EventArgs e)
        {
            carregarDgvFornecedor();
            panel_addFornecedor.Enabled = true;
            panel_consultaFornecedor.Enabled = true;
            panel_editDeleteFornecedor.Enabled = true;
            btn_gerarPdfFornecedor.Enabled = true;
        }

        private void btn_filtrarFornecedor_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM Fornecedor WHERE nome = @nomeFornecedor;";
                cmd.Parameters.Add("@nomeFornecedor", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txt_buscaNomeFornecedor.Text;

                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgv_fornecedor.DataSource = dt;
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

        private void btn_limparFiltroFornecedor_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta("SELECT * FROM Fornecedor;");
            txt_buscaNomeFornecedor.Text = "";
            dgv_fornecedor.DataSource = dt;
        }

        private void btn_addFornecedor_Click(object sender, EventArgs e)
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
                cmd.CommandText = "INSERT INTO Fornecedor values (@nome, @email, @endereco);";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txt_addNomeFornecedor.Text;
                cmd.Parameters[1].Value = txt_addEmailFornecedor.Text;
                cmd.Parameters[2].Value = txt_addEnderecoFornecedor.Text;
                cmd.ExecuteNonQuery();

                txt_addNomeFornecedor.Text = "";
                txt_addEmailFornecedor.Text = "";
                txt_addEnderecoFornecedor.Text = "";
                carregarDgvFornecedor();

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

        private void dgv_fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_fornecedor.Rows[indexDgv];
                int idFornecedor = int.Parse(selectedRow.Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Fornecedor " +
                    "WHERE idFornecedor=@idFornecedor;";
                cmd.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idFornecedor;
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txt_editIdFornecedor.Text = reader["idFornecedor"].ToString();
                txt_editNomeFornecedor.Text = reader["nome"].ToString();
                txt_editEmailFornecedor.Text = reader["email"].ToString();
                txt_editEnderecoFornecedor.Text = reader["endereco"].ToString();

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

        private void btn_editCFornecedor_Click(object sender, EventArgs e)
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
                cmd.CommandText = "UPDATE Fornecedor SET  nome=@nome, email=@email, endereco=@endereco " +
                    "WHERE idFornecedor=@idFornecedor;";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editNomeFornecedor.Text;
                cmd.Parameters[1].Value = txt_editEmailFornecedor.Text;
                cmd.Parameters[2].Value = txt_editEnderecoFornecedor.Text;
                cmd.Parameters[3].Value = txt_editIdFornecedor.Text;

                cmd.ExecuteNonQuery();

                txt_editIdFornecedor.Text = "";
                txt_editNomeFornecedor.Text = "";
                txt_editEmailFornecedor.Text = "";
                txt_editEnderecoFornecedor.Text = "";
                carregarDgvFornecedor();
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

        private void btn_deleteFornecedor_Click(object sender, EventArgs e)
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
                cmd.CommandText = "DELETE FROM Fornecedor WHERE idFornecedor=@idFornecedor;";
                cmd.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editIdFornecedor.Text;
                cmd.ExecuteNonQuery();

                txt_editIdFornecedor.Text = "";
                txt_editNomeFornecedor.Text = "";
                txt_editEmailFornecedor.Text = "";
                txt_editEnderecoFornecedor.Text = "";
                carregarDgvFornecedor();
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

        private void btn_gerarPdfFornecedor_Click(object sender, EventArgs e)
        {
            if (dgv_fornecedor.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "FornecedoresDesafio2Atos.pdf";
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
                            PdfPTable pTable = new PdfPTable(dgv_fornecedor.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgv_fornecedor.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgv_fornecedor.Rows)
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
