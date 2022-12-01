using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_1Atos
{
    public partial class form_produto : Form
    {
        public form_produto()
        {
            InitializeComponent();
        }
        private void carregarDgvProduto()
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from p in contexto.Produtos
                              join f in contexto.Fornecedors on p.IdFornecedor equals f.IdFornecedor
                              select new { ID = p.IdProduto, Nome = p.Nome, Descricao = p.Descricao, 
                                  Preco = p.Preco, Quantidade = p.Quantidade, Fornecedor = f.Nome }).ToList();
                dgv_produto.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarProduto.Enabled = false;
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
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from p in contexto.Produtos
                              join f in contexto.Fornecedors on p.IdFornecedor equals f.IdFornecedor
                              where p.Nome == txt_buscaNomeProduto.Text
                              select new
                              {
                                  ID = p.IdProduto,Nome = p.Nome,
                                  Descricao = p.Descricao,Preco = p.Preco,
                                  Quantidade = p.Quantidade,Fornecedor = f.Nome}).ToList();
                dgv_produto.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_limparFiltroProduto_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from p in contexto.Produtos
                              join f in contexto.Fornecedors on p.IdFornecedor equals f.IdFornecedor
                              select new
                              {
                                  ID = p.IdProduto, Nome = p.Nome,
                                  Descricao = p.Descricao,Preco = p.Preco,
                                  Quantidade = p.Quantidade,Fornecedor = f.Nome}).ToList();
                txt_buscaNomeProduto.Text = "";
                dgv_produto.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Produto p = new Produto();
                int idFornecedor = int.Parse(txt_addIdFornecedorProduto.Text);
                Fornecedor f = contexto.Fornecedors.Find(idFornecedor);

                p.Nome = txt_addNomeProduto.Text;
                p.Descricao = txt_addDescricaoProduto.Text;
                p.Preco = float.Parse(txt_addPrecoProduto.Text);
                p.Quantidade = int.Parse(txt_addQuantidadeProduto.Text);
                p.IdFornecedorNavigation = f;

                contexto.Produtos.Add(p);
                contexto.SaveChanges();

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
        }

        private void dgv_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_produto.Rows[indexDgv];
                int idProduto = int.Parse(selectedRow.Cells[0].Value.ToString());
                var result = (from p in contexto.Produtos
                              join f in contexto.Fornecedors on p.IdFornecedor equals f.IdFornecedor
                              where p.IdProduto == idProduto
                              select new
                              {
                                  ID = p.IdProduto,Nome = p.Nome,
                                  Descricao = p.Descricao, Preco = p.Preco,
                                  Quantidade = p.Quantidade,Fornecedor = f.IdFornecedor}).ToList();
                foreach (var item in result)
                {
                    txt_editIdProduto.Text = item.ID.ToString();
                    txt_editNomeProduto.Text = item.Nome.ToString();
                    txt_editDescricaoProduto.Text = item.Descricao.ToString();
                    txt_editPrecoProduto.Text = item.Preco.ToString();
                    txt_editQuantidadeProduto.Text = item.Quantidade.ToString();
                    txt_editIdFornecedor.Text = item.Fornecedor.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_editProduto_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Produto p = contexto.Produtos.Find(int.Parse(txt_editIdProduto.Text));
                p.Nome = txt_editNomeProduto.Text;
                p.Descricao = txt_editDescricaoProduto.Text;
                p.Preco = float.Parse(txt_editPrecoProduto.Text);
                p.IdFornecedor = int.Parse(txt_editIdFornecedor.Text);
                p.Quantidade = int.Parse(txt_editQuantidadeProduto.Text);
                contexto.Produtos.Update(p);
                contexto.SaveChanges();
                txt_editNomeProduto.Text = "";
                txt_editDescricaoProduto.Text = "";
                txt_editPrecoProduto.Text = "";
                txt_editQuantidadeProduto.Text = "";
                txt_editIdFornecedor.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvProduto();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_deleteProduto_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Produto p = contexto.Produtos.Find(int.Parse(txt_editIdProduto.Text));
                contexto.Produtos.Remove(p);
                contexto.SaveChanges();
                txt_editNomeProduto.Text = "";
                txt_editDescricaoProduto.Text = "";
                txt_editPrecoProduto.Text = "";
                txt_editQuantidadeProduto.Text = "";
                txt_editIdFornecedor.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvProduto();
                Console.WriteLine("Produto deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
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
