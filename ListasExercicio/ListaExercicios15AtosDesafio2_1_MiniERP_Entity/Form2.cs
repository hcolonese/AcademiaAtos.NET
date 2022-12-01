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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }
        private void carregarDgvCliente()
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from c in contexto.Clientes
                              select new { ID = c.IdCliente, Nome = c.Nome, Email = c.Email, Cidade = c.Cidade, Cpf = c.Cpf }).ToList();
                dgv_cliente.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarCliente.Enabled = false;
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
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from c in contexto.Clientes
                              where c.Nome == txt_buscaNomeCliente.Text
                              select new { ID = c.IdCliente, Nome = c.Nome, Email = c.Email, Cidade = c.Cidade, Cpf = c.Cpf }).ToList();
                dgv_cliente.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_limparFiltroCliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                var result = (from c in contexto.Clientes
                              select new { ID = c.IdCliente, Nome = c.Nome, Email = c.Email, Cidade = c.Cidade, Cpf = c.Cpf }).ToList();
                txt_buscaNomeCliente.Text = "";
                dgv_cliente.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
            finally
            {
                btn_conectarCliente.Enabled = false;
            }
        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Cliente c = new Cliente();
                c.Nome = txt_addNomeCliente.Text;
                c.Email = txt_addEmailCliente.Text;
                c.Cidade = txt_addCidadeCliente.Text;
                c.Cpf = txt_addCpfCliente.Text;
                contexto.Clientes.Add(c);
                contexto.SaveChanges();

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
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                int indexDgv = e.RowIndex;
                DataGridViewRow selectedRow = dgv_cliente.Rows[indexDgv];
                int idCliente = int.Parse(selectedRow.Cells[0].Value.ToString());
                var result = (from c in contexto.Clientes
                              where c.IdCliente == idCliente
                              select new { ID = c.IdCliente, Nome = c.Nome, Email = c.Email, Cidade = c.Cidade, Cpf = c.Cpf }).ToList();
                foreach (var item in result)
                {
                    txt_editIdCliente.Text = item.ID.ToString();
                    txt_editNomeCliente.Text = item.Nome.ToString();
                    txt_editEmailCliente.Text = item.Email.ToString();
                    txt_editCidadeCliente.Text = item.Cidade.ToString();
                    txt_editCpfCliente.Text = item.Cpf.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_editCliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Cliente c = contexto.Clientes.Find(int.Parse(txt_editIdCliente.Text));
                c.Nome = txt_editNomeCliente.Text;
                c.Email = txt_editEmailCliente.Text;
                c.Cidade = txt_editCidadeCliente.Text;
                c.Cpf = txt_editCpfCliente.Text;
                contexto.Clientes.Update(c);
                contexto.SaveChanges();
                txt_editNomeCliente.Text = "";
                txt_editEmailCliente.Text = "";
                txt_editCidadeCliente.Text = "" ;
                txt_editCpfCliente.Text = "";
                carregarDgvCliente();
                Console.WriteLine("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
            }
        }

        private void btn_deleteCliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Desafio21Context contexto = new Desafio21Context();

            try
            {
                Cliente c = contexto.Clientes.Find(int.Parse(txt_editIdCliente.Text));
                contexto.Clientes.Remove(c);
                contexto.SaveChanges();
                txt_editNomeCliente.Text = "";
                txt_editEmailCliente.Text = "";
                txt_editCidadeCliente.Text = "";
                txt_editCpfCliente.Text = "";
                carregarDgvCliente();
                Console.WriteLine("Nota deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu Errado" + ex.ToString(), "Erro");
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
