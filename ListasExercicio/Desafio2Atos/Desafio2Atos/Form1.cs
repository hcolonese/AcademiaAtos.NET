using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Threading;
using System.Windows.Forms;

using System.Xml.Linq;

namespace Desafio2Atos
{
    public partial class form_notaFiscal : Form
    {
        public form_notaFiscal()
        {
            InitializeComponent();
        }

        private void carregarDgvNota()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            try
            {
                dt = bd.ExecutaConsulta("SELECT [NotaFiscal].idNota, [NotaFiscal].dataEmissao, [Cliente].nome AS Cliente , [Produto].nome AS Produto " +
                    "FROM NotaFiscal, Cliente, Produto WHERE  [NotaFiscal].idCliente = [Cliente].idCliente AND " +
                    "[NotaFiscal].idProduto = [Produto].idProduto;");
                dgv_notaFiscal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectar.Enabled = false;
                bd.FecharConexao();
            }
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            carregarDgvNota();
            panel_addNota.Enabled = true;
            panel_consultaNota.Enabled = true;
            panel_editNota.Enabled = true;
            btn_gerarPDF.Enabled = true;
        }

        private void btn_filtrarNota_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT [NotaFiscal].idNota, [NotaFiscal].dataEmissao, [Cliente].nome AS Cliente, " +
                    "[Produto].nome AS Produto FROM NotaFiscal, Cliente, Produto " +
                    "WHERE [NotaFiscal].idCliente = [Cliente].idCliente AND " +
                    "[NotaFiscal].idProduto = [Produto].idProduto AND " +
                    "[NotaFiscal].dataEmissao = @dataEmissao;";

                cmd.Parameters.Add("@dataEmissao", System.Data.SqlDbType.Date);
                cmd.Parameters[0].Value = txt_buscaNota.Text;

                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgv_notaFiscal.DataSource = dt;
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

        private void btn_limpaFiltroNota_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta("SELECT [NotaFiscal].idNota, [NotaFiscal].dataEmissao, [Cliente].nome AS Cliente , [Produto].nome AS Produto " +
                    "FROM NotaFiscal, Cliente, Produto WHERE  [NotaFiscal].idCliente = [Cliente].idCliente AND " +
                    "[NotaFiscal].idProduto = [Produto].idProduto;");
            txt_buscaNota.Text = "";
            dgv_notaFiscal.DataSource = dt;
        }
        private void dgv_notaFiscal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_notaFiscal.Rows[indexDgv];
                int idNotaFiscal = int.Parse(selectedRow.Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT dataEmissao, idCliente, idProduto FROM NotaFiscal " +
                    "WHERE idNota=@idNotaFiscal;";
                cmd.Parameters.Add("@idNotaFiscal", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idNotaFiscal;
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txt_editDataEmissao.Text = reader["dataEmissao"].ToString();
                txt_editIdCliente.Text = reader["idCliente"].ToString();
                txt_editIdProduto.Text = reader["idProduto"].ToString();
                txt_editIdNota.Text = selectedRow.Cells[0].Value.ToString();
                txt_editDataEmissao.Text = selectedRow.Cells[1].Value.ToString();

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

        private void btn_editNota_Click(object sender, EventArgs e)
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
                cmd.CommandText = "UPDATE NotaFiscal SET  dataEmissao=@dataEmissao, idCliente=@idCliente, " +
                    "idProduto=@idProduto WHERE idNota=@idNota;";
                cmd.Parameters.Add("@dataEmissao", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@idCliente", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idProduto", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idNota", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editDataEmissao.Text;
                cmd.Parameters[1].Value = txt_editIdCliente.Text;
                cmd.Parameters[2].Value = txt_editIdProduto.Text;
                cmd.Parameters[3].Value = txt_editIdNota.Text;
                cmd.ExecuteNonQuery();

                txt_editDataEmissao.Text = "";
                txt_editIdCliente.Text = "";
                txt_editIdProduto.Text = "";
                txt_editIdNota.Text = "";
                carregarDgvNota();
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

        private void btn_deleteNota_Click(object sender, EventArgs e)
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
                cmd.CommandText = "DELETE FROM NotaFiscal WHERE idNota=@idNota;";
                cmd.Parameters.Add("@idNota", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editIdNota.Text;
                cmd.ExecuteNonQuery();

                txt_editDataEmissao.Text = "";
                txt_editIdCliente.Text = "";
                txt_editIdProduto.Text = "";
                txt_editIdNota.Text = "";
                carregarDgvNota();
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

        private void btn_addNota_Click(object sender, EventArgs e)
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
                cmd.CommandText = "INSERT INTO NotaFiscal values (@dataEmissao, @idProduto, @idCliente);";
                cmd.Parameters.Add("@dataEmissao", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@idProduto", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idCliente", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_addDataEmissao.Text;
                cmd.Parameters[1].Value = txt_addIdProduto.Text;
                cmd.Parameters[2].Value = txt_addIdCliente.Text;
                cmd.ExecuteNonQuery();

                txt_addDataEmissao.Text = "";
                txt_addIdProduto.Text = "";
                txt_addIdCliente.Text = "";
                carregarDgvNota();
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

        private void btn_goClientes_Click(object sender, EventArgs e)
        {
            form_cliente formCliente = new form_cliente();
            formCliente.ShowDialog();
        }

        private void btn_goFornecedores_Click(object sender, EventArgs e)
        {
            form_fornecedor formFornecedor = new form_fornecedor();
            formFornecedor.ShowDialog();
        }

        private void btn_goProdutos_Click(object sender, EventArgs e)
        {
            form_produto formProduto = new form_produto();
            formProduto.ShowDialog();
        }

        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            if (dgv_notaFiscal.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "NotasFiscaisDesafio2Atos.pdf";
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
                            PdfPTable pTable = new PdfPTable(dgv_notaFiscal.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgv_notaFiscal.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgv_notaFiscal.Rows)
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
