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
    public partial class form_fornecedor : Form
    {
        public form_fornecedor()
        {
            InitializeComponent();
        }
        private void carregarDgvFornecedor()
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from f in contexto.Fornecedors
                              select new { ID = f.IdFornecedor, Nome = f.Nome, Email = f.Email, Endereco = f.Endereco}).ToList();
                dgv_fornecedor.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarFornecedor.Enabled = false;
            }
        }
        private void btn_conectarFornecedor_Click(object sender, EventArgs e)
        {
            carregarDgvFornecedor();
            panel_addFornecedor.Enabled = true;
            panel_consultaFornecedor.Enabled = true;
            panel_editDeleteFornecedor.Enabled = true;
            btn_gerarPdfFornecedor.Enabled = true;
        }

        private void btn_filtrarFornecedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from f in contexto.Fornecedors
                              where f.Nome == txt_buscaNomeFornecedor.Text
                              select new { ID = f.IdFornecedor, Nome = f.Nome, Email = f.Email, Endereco = f.Endereco }).ToList();
                dgv_fornecedor.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_limparFiltroFornecedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from f in contexto.Fornecedors
                              select new { ID = f.IdFornecedor, Nome = f.Nome, Email = f.Email, Endereco = f.Endereco }).ToList();
                txt_buscaNomeFornecedor.Text = "";
                dgv_fornecedor.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarFornecedor.Enabled = false;
            }
        }

        private void btn_addFornecedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Fornecedor f = new Fornecedor();
                f.Nome = txt_addNomeFornecedor.Text;
                f.Email = txt_addEmailFornecedor.Text;
                f.Endereco = txt_addEnderecoFornecedor.Text;
                contexto.Fornecedors.Add(f);
                contexto.SaveChanges();

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
        }

        private void dgv_fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_fornecedor.Rows[indexDgv];
                int idFornecedor = int.Parse(selectedRow.Cells[0].Value.ToString());
                var result = (from f in contexto.Fornecedors
                              where f.IdFornecedor == idFornecedor
                              select new { ID = f.IdFornecedor, Nome = f.Nome, Email = f.Email, Endereco = f.Endereco }).ToList();
                foreach (var item in result)
                {
                    txt_editIdFornecedor.Text = item.ID.ToString();
                    txt_editNomeFornecedor.Text = item.Nome.ToString();
                    txt_editEmailFornecedor.Text = item.Email.ToString();
                    txt_editEnderecoFornecedor.Text = item.Endereco.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_editCFornecedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Fornecedor f = contexto.Fornecedors.Find(int.Parse(txt_editIdFornecedor.Text));
                f.Nome = txt_editNomeFornecedor.Text;
                f.Email = txt_editEmailFornecedor.Text;
                f.Endereco = txt_editEnderecoFornecedor.Text;
                contexto.Fornecedors.Update(f);
                contexto.SaveChanges();
                txt_editIdFornecedor.Text = "";
                txt_editNomeFornecedor.Text = "";
                txt_editEmailFornecedor.Text = "";
                txt_editEnderecoFornecedor.Text = "";
                carregarDgvFornecedor();
                Console.WriteLine("Fornecedor atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_deleteFornecedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Fornecedor f = contexto.Fornecedors.Find(int.Parse(txt_editIdFornecedor.Text));
                contexto.Fornecedors.Remove(f);
                contexto.SaveChanges();
                txt_editIdFornecedor.Text = "";
                txt_editNomeFornecedor.Text = "";
                txt_editEmailFornecedor.Text = "";
                txt_editEnderecoFornecedor.Text = "";
                carregarDgvFornecedor();
                Console.WriteLine("Fornecedor deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
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
