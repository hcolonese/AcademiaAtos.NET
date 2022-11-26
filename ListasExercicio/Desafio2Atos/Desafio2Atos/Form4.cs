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
    public partial class form_produto : Form
    {
        public form_produto()
        {
            InitializeComponent();
        }

        private void carregarDgvProduto()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            try
            {
                dt = bd.ExecutaConsulta("SELECT [Produto].idProduto AS ID, [Produto].nome AS Nome, [Produto].descricao AS Descrição, " +
                    "[Produto].preco AS Preço,[Produto].quantidade AS Quantidade, [Fornecedor].nome AS Fornecedor " +
                    "FROM Produto, Fornecedor WHERE  [Produto].idFornecedor = [Fornecedor].idFornecedor;");
                dgv_produto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarProduto.Enabled = false;
                bd.FecharConexao();
            }
        }
        private void btn_conectarProduto_Click(object sender, EventArgs e)
        {
            carregarDgvProduto();
            panel_addCliente.Enabled = true;
            panel_consultaProduto.Enabled = true;
            panel_editDeleteProduto.Enabled = true;
            btn_gerarPdfProdutos.Enabled = true;
        }

        private void btn_filtrarProduto_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT[Produto].idProduto AS ID, [Produto].nome AS Nome, [Produto].descricao AS Descrição, " +
                    "[Produto].preco AS Preço, [Produto].quantidade AS Quantidade, [Fornecedor].nome AS Fornecedor " +
                    "FROM Produto, Fornecedor WHERE  [Produto].idFornecedor = [Fornecedor].idFornecedor AND " +
                    "[Produto].nome = @nome;";

                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters[0].Value = txt_buscaNomeProduto.Text;

                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgv_produto.DataSource = dt;
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

        private void btn_limparFiltroProduto_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta("SELECT [Produto].idProduto AS ID, [Produto].nome AS Nome, [Produto].descricao AS Descrição, " +
                    "[Produto].preco AS Preço,[Produto].quantidade AS Quantidade, [Fornecedor].nome AS Fornecedor " +
                    "FROM Produto, Fornecedor WHERE  [Produto].idFornecedor = [Fornecedor].idFornecedor;");
            dgv_produto.DataSource = dt;
        }

        private void btn_addProduto_Click(object sender, EventArgs e)
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
                cmd.CommandText = "INSERT INTO Produto values (@nome, @descricao, @preco, @quantidade, @idFornecedor);";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@preco", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@quantidade", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_addNomeProduto.Text;
                cmd.Parameters[1].Value = txt_addDescricaoProduto.Text;
                cmd.Parameters[2].Value = txt_addPrecoProduto.Text;
                cmd.Parameters[3].Value = txt_addQuantidadeProduto.Text;
                cmd.Parameters[4].Value = txt_addIdFornecedorProduto.Text;
                cmd.ExecuteNonQuery();

                txt_addNomeProduto.Text = "";
                txt_addDescricaoProduto.Text = "";
                txt_addPrecoProduto.Text = "";
                txt_addQuantidadeProduto.Text = "";
                txt_addIdFornecedorProduto.Text = "";
                carregarDgvProduto();

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

        private void dgv_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_produto.Rows[indexDgv];
                int idProduto = int.Parse(selectedRow.Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT[Produto].idProduto, [Produto].nome, [Produto].descricao, " +
                    "[Produto].preco, [Produto].quantidade, [Produto].idFornecedor " +
                    "FROM Produto WHERE [Produto].idProduto = @idProduto;";
                cmd.Parameters.Add("@idProduto", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = idProduto;
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txt_editIdProduto.Text = reader["idProduto"].ToString();
                txt_editNomeProduto.Text = reader["nome"].ToString();
                txt_editDescricaoProduto.Text = reader["descricao"].ToString();
                txt_editPrecoProduto.Text = reader["preco"].ToString();
                txt_editQuantidadeProduto.Text = reader["quantidade"].ToString();
                txt_editIdFornecedor.Text = reader["idFornecedor"].ToString();

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
                cmd.CommandText = "UPDATE Produto SET  nome=@nome, descricao=@descricao, " +
                    "preco=@preco, quantidade=@quantidade, idFornecedor=@idFornecedor WHERE idProduto=@idProduto;";
                cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@preco", System.Data.SqlDbType.Float);
                cmd.Parameters.Add("@quantidade", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@idProduto", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editNomeProduto.Text;
                cmd.Parameters[1].Value = txt_editDescricaoProduto.Text;
                cmd.Parameters[2].Value = txt_editPrecoProduto.Text;
                cmd.Parameters[3].Value = txt_editQuantidadeProduto.Text;
                cmd.Parameters[4].Value = txt_editIdFornecedor.Text;
                cmd.Parameters[5].Value = txt_editIdProduto.Text;
                cmd.ExecuteNonQuery();

                txt_editNomeProduto.Text = "";
                txt_editDescricaoProduto.Text = "";
                txt_editPrecoProduto.Text = "";
                txt_editQuantidadeProduto.Text = "";
                txt_editIdFornecedor.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvProduto();
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

        private void btn_deleteProduto_Click(object sender, EventArgs e)
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
                cmd.CommandText = "DELETE FROM Produto WHERE idProduto=@idProduto;";
                cmd.Parameters.Add("@idProduto", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = txt_editIdProduto.Text;
                cmd.ExecuteNonQuery();

                txt_editNomeProduto.Text = "";
                txt_editDescricaoProduto.Text = "";
                txt_editPrecoProduto.Text = "";
                txt_editQuantidadeProduto.Text = "";
                txt_editIdFornecedor.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvProduto();
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

        private void btn_gerarPdfProdutos_Click(object sender, EventArgs e)
        {
            if (dgv_produto.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "ProdutosDesafio2Atos.pdf";
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
                            PdfPTable pTable = new PdfPTable(dgv_produto.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgv_produto.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgv_produto.Rows)
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
