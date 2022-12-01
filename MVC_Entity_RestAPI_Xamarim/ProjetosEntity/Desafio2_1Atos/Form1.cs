using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Drawing.Printing;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desafio2_1Atos
{
    public partial class form_notaFiscal : Form
    {
        public form_notaFiscal()
        {
            InitializeComponent();
        }


        private void carregarDgvNota()
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
               var result = (from nt in contexto.NotaFiscals
                          join p in contexto.Produtos on nt.IdProduto equals p.IdProduto
                          join c in contexto.Clientes on nt.IdCliente equals c.IdCliente
                          select new { ID = nt.IdNota, Data = nt.DataEmissao, Cliente = c.Nome, Produto = p.Nome }).ToList();
                dgv_notaFiscal.DataSource = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectar.Enabled = false;
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

        private void btn_filtrarNota_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from nt in contexto.NotaFiscals
                              join p in contexto.Produtos on nt.IdProduto equals p.IdProduto
                              join c in contexto.Clientes on nt.IdCliente equals c.IdCliente
                              where nt.DataEmissao == DateTime.Parse(txt_buscaNota.Text)
                              select new { ID = nt.IdNota, Data = nt.DataEmissao, Cliente = c.Nome, Produto = p.Nome }).ToList();
                dgv_notaFiscal.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_limpaFiltroNota_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from nt in contexto.NotaFiscals
                              join p in contexto.Produtos on nt.IdProduto equals p.IdProduto
                              join c in contexto.Clientes on nt.IdCliente equals c.IdCliente
                              select new { ID = nt.IdNota, Data = nt.DataEmissao, Cliente = c.Nome, Produto = p.Nome }).ToList();
                txt_buscaNota.Text = "";
                dgv_notaFiscal.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }
        private void btn_addNota_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                NotaFiscal nt = new NotaFiscal();
                int idCliente = int.Parse(txt_addIdCliente.Text);
                Cliente c = contexto.Clientes.Find(idCliente);
                int idProduto = int.Parse(txt_addIdProduto.Text);
                Produto p = contexto.Produtos.Find(idProduto);

                nt.DataEmissao = DateTime.Parse(txt_addDataEmissao.Text);
                nt.IdProdutoNavigation = p;
                nt.IdClienteNavigation = c;
                contexto.NotaFiscals.Add(nt);
                contexto.SaveChanges();

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
        }
        private void dgv_notaFiscal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try{
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_notaFiscal.Rows[indexDgv];
                int idNotaFiscal = int.Parse(selectedRow.Cells[0].Value.ToString());
                var result = (from nt in contexto.NotaFiscals
                              where nt.IdNota == idNotaFiscal
                              select new {Data = nt.DataEmissao, Cliente = nt.IdCliente, Produto = nt.IdProduto }).ToList();
                foreach(var item in result)
                {
                    txt_editDataEmissao.Text = item.Data.ToString();
                    txt_editIdCliente.Text = item.Cliente.ToString();
                    txt_editIdProduto.Text = item.Produto.ToString();
                }
                txt_editIdNota.Text = selectedRow.Cells[0].Value.ToString();
                txt_editDataEmissao.Text = selectedRow.Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_editNota_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                NotaFiscal nt = contexto.NotaFiscals.Find(int.Parse(txt_editIdNota.Text));
                nt.DataEmissao = DateTime.Parse(txt_editDataEmissao.Text);
                nt.IdCliente = int.Parse(txt_editIdCliente.Text);
                nt.IdProduto = int.Parse(txt_editIdProduto.Text);
                contexto.NotaFiscals.Update(nt);
                contexto.SaveChanges();
                txt_editDataEmissao.Text = "";
                txt_editIdCliente.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvNota();
                MessageBox.Show("Nota atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_deleteNota_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                NotaFiscal nt = contexto.NotaFiscals.Find(int.Parse(txt_editIdNota.Text));
                contexto.NotaFiscals.Remove(nt);
                contexto.SaveChanges();
                txt_editDataEmissao.Text = "";
                txt_editIdCliente.Text = "";
                txt_editIdProduto.Text = "";
                carregarDgvNota();
                Console.WriteLine("Nota deletada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
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