namespace Desafio2Atos
{
    partial class form_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_conectarProduto = new System.Windows.Forms.Button();
            this.dgv_produto = new System.Windows.Forms.DataGridView();
            this.panel_consultaProduto = new System.Windows.Forms.Panel();
            this.btn_limparFiltroProduto = new System.Windows.Forms.Button();
            this.btn_filtrarProduto = new System.Windows.Forms.Button();
            this.txt_buscaNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_addCliente = new System.Windows.Forms.Panel();
            this.txt_addIdFornecedorProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_addProduto = new System.Windows.Forms.Button();
            this.txt_addQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txt_addPrecoProduto = new System.Windows.Forms.TextBox();
            this.txt_addDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txt_addNomeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_editDeleteProduto = new System.Windows.Forms.Panel();
            this.txt_editIdFornecedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_editIdProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_deleteProduto = new System.Windows.Forms.Button();
            this.btn_editProduto = new System.Windows.Forms.Button();
            this.txt_editQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txt_editPrecoProduto = new System.Windows.Forms.TextBox();
            this.txt_editDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txt_editNomeProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_gerarPdfProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
            this.panel_consultaProduto.SuspendLayout();
            this.panel_addCliente.SuspendLayout();
            this.panel_editDeleteProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conectar com Banco de Dados";
            // 
            // btn_conectarProduto
            // 
            this.btn_conectarProduto.Location = new System.Drawing.Point(89, 30);
            this.btn_conectarProduto.Name = "btn_conectarProduto";
            this.btn_conectarProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_conectarProduto.TabIndex = 3;
            this.btn_conectarProduto.Text = "Conectar";
            this.btn_conectarProduto.UseVisualStyleBackColor = true;
            this.btn_conectarProduto.Click += new System.EventHandler(this.btn_conectarProduto_Click);
            // 
            // dgv_produto
            // 
            this.dgv_produto.AllowUserToAddRows = false;
            this.dgv_produto.AllowUserToDeleteRows = false;
            this.dgv_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produto.Location = new System.Drawing.Point(253, 12);
            this.dgv_produto.MinimumSize = new System.Drawing.Size(519, 219);
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.ReadOnly = true;
            this.dgv_produto.RowHeadersVisible = false;
            this.dgv_produto.RowTemplate.Height = 25;
            this.dgv_produto.Size = new System.Drawing.Size(519, 219);
            this.dgv_produto.TabIndex = 5;
            this.dgv_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produto_CellClick);
            // 
            // panel_consultaProduto
            // 
            this.panel_consultaProduto.Controls.Add(this.btn_limparFiltroProduto);
            this.panel_consultaProduto.Controls.Add(this.btn_filtrarProduto);
            this.panel_consultaProduto.Controls.Add(this.txt_buscaNomeProduto);
            this.panel_consultaProduto.Controls.Add(this.label3);
            this.panel_consultaProduto.Controls.Add(this.label2);
            this.panel_consultaProduto.Enabled = false;
            this.panel_consultaProduto.Location = new System.Drawing.Point(12, 266);
            this.panel_consultaProduto.Name = "panel_consultaProduto";
            this.panel_consultaProduto.Size = new System.Drawing.Size(232, 109);
            this.panel_consultaProduto.TabIndex = 6;
            // 
            // btn_limparFiltroProduto
            // 
            this.btn_limparFiltroProduto.Location = new System.Drawing.Point(124, 78);
            this.btn_limparFiltroProduto.Name = "btn_limparFiltroProduto";
            this.btn_limparFiltroProduto.Size = new System.Drawing.Size(89, 23);
            this.btn_limparFiltroProduto.TabIndex = 4;
            this.btn_limparFiltroProduto.Text = "Limpar Filtro";
            this.btn_limparFiltroProduto.UseVisualStyleBackColor = true;
            this.btn_limparFiltroProduto.Click += new System.EventHandler(this.btn_limparFiltroProduto_Click);
            // 
            // btn_filtrarProduto
            // 
            this.btn_filtrarProduto.Location = new System.Drawing.Point(7, 78);
            this.btn_filtrarProduto.Name = "btn_filtrarProduto";
            this.btn_filtrarProduto.Size = new System.Drawing.Size(93, 23);
            this.btn_filtrarProduto.TabIndex = 3;
            this.btn_filtrarProduto.Text = "Aplicar Filtro";
            this.btn_filtrarProduto.UseVisualStyleBackColor = true;
            this.btn_filtrarProduto.Click += new System.EventHandler(this.btn_filtrarProduto_Click);
            // 
            // txt_buscaNomeProduto
            // 
            this.txt_buscaNomeProduto.Location = new System.Drawing.Point(91, 38);
            this.txt_buscaNomeProduto.Name = "txt_buscaNomeProduto";
            this.txt_buscaNomeProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_buscaNomeProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consulta";
            // 
            // panel_addCliente
            // 
            this.panel_addCliente.Controls.Add(this.txt_addIdFornecedorProduto);
            this.panel_addCliente.Controls.Add(this.label9);
            this.panel_addCliente.Controls.Add(this.btn_addProduto);
            this.panel_addCliente.Controls.Add(this.txt_addQuantidadeProduto);
            this.panel_addCliente.Controls.Add(this.txt_addPrecoProduto);
            this.panel_addCliente.Controls.Add(this.txt_addDescricaoProduto);
            this.panel_addCliente.Controls.Add(this.txt_addNomeProduto);
            this.panel_addCliente.Controls.Add(this.label8);
            this.panel_addCliente.Controls.Add(this.label7);
            this.panel_addCliente.Controls.Add(this.label6);
            this.panel_addCliente.Controls.Add(this.label5);
            this.panel_addCliente.Controls.Add(this.label4);
            this.panel_addCliente.Enabled = false;
            this.panel_addCliente.Location = new System.Drawing.Point(12, 59);
            this.panel_addCliente.Name = "panel_addCliente";
            this.panel_addCliente.Size = new System.Drawing.Size(235, 201);
            this.panel_addCliente.TabIndex = 7;
            // 
            // txt_addIdFornecedorProduto
            // 
            this.txt_addIdFornecedorProduto.Location = new System.Drawing.Point(96, 139);
            this.txt_addIdFornecedorProduto.Name = "txt_addIdFornecedorProduto";
            this.txt_addIdFornecedorProduto.Size = new System.Drawing.Size(136, 23);
            this.txt_addIdFornecedorProduto.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID Fornecedor:";
            // 
            // btn_addProduto
            // 
            this.btn_addProduto.Location = new System.Drawing.Point(76, 167);
            this.btn_addProduto.Name = "btn_addProduto";
            this.btn_addProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_addProduto.TabIndex = 16;
            this.btn_addProduto.Text = "Criar";
            this.btn_addProduto.UseVisualStyleBackColor = true;
            this.btn_addProduto.Click += new System.EventHandler(this.btn_addProduto_Click);
            // 
            // txt_addQuantidadeProduto
            // 
            this.txt_addQuantidadeProduto.Location = new System.Drawing.Point(96, 110);
            this.txt_addQuantidadeProduto.Name = "txt_addQuantidadeProduto";
            this.txt_addQuantidadeProduto.Size = new System.Drawing.Size(136, 23);
            this.txt_addQuantidadeProduto.TabIndex = 13;
            // 
            // txt_addPrecoProduto
            // 
            this.txt_addPrecoProduto.Location = new System.Drawing.Point(96, 83);
            this.txt_addPrecoProduto.Name = "txt_addPrecoProduto";
            this.txt_addPrecoProduto.Size = new System.Drawing.Size(136, 23);
            this.txt_addPrecoProduto.TabIndex = 12;
            // 
            // txt_addDescricaoProduto
            // 
            this.txt_addDescricaoProduto.Location = new System.Drawing.Point(96, 56);
            this.txt_addDescricaoProduto.Name = "txt_addDescricaoProduto";
            this.txt_addDescricaoProduto.Size = new System.Drawing.Size(136, 23);
            this.txt_addDescricaoProduto.TabIndex = 11;
            // 
            // txt_addNomeProduto
            // 
            this.txt_addNomeProduto.Location = new System.Drawing.Point(96, 29);
            this.txt_addNomeProduto.Name = "txt_addNomeProduto";
            this.txt_addNomeProduto.Size = new System.Drawing.Size(136, 23);
            this.txt_addNomeProduto.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adicionar";
            // 
            // panel_editDeleteProduto
            // 
            this.panel_editDeleteProduto.Controls.Add(this.txt_editIdFornecedor);
            this.panel_editDeleteProduto.Controls.Add(this.label15);
            this.panel_editDeleteProduto.Controls.Add(this.txt_editIdProduto);
            this.panel_editDeleteProduto.Controls.Add(this.label13);
            this.panel_editDeleteProduto.Controls.Add(this.btn_deleteProduto);
            this.panel_editDeleteProduto.Controls.Add(this.btn_editProduto);
            this.panel_editDeleteProduto.Controls.Add(this.txt_editQuantidadeProduto);
            this.panel_editDeleteProduto.Controls.Add(this.txt_editPrecoProduto);
            this.panel_editDeleteProduto.Controls.Add(this.txt_editDescricaoProduto);
            this.panel_editDeleteProduto.Controls.Add(this.txt_editNomeProduto);
            this.panel_editDeleteProduto.Controls.Add(this.label10);
            this.panel_editDeleteProduto.Controls.Add(this.label11);
            this.panel_editDeleteProduto.Controls.Add(this.label12);
            this.panel_editDeleteProduto.Controls.Add(this.label14);
            this.panel_editDeleteProduto.Enabled = false;
            this.panel_editDeleteProduto.Location = new System.Drawing.Point(312, 237);
            this.panel_editDeleteProduto.Name = "panel_editDeleteProduto";
            this.panel_editDeleteProduto.Size = new System.Drawing.Size(395, 138);
            this.panel_editDeleteProduto.TabIndex = 8;
            // 
            // txt_editIdFornecedor
            // 
            this.txt_editIdFornecedor.Location = new System.Drawing.Point(275, 56);
            this.txt_editIdFornecedor.Name = "txt_editIdFornecedor";
            this.txt_editIdFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_editIdFornecedor.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "ID Fornecedor:";
            // 
            // txt_editIdProduto
            // 
            this.txt_editIdProduto.Enabled = false;
            this.txt_editIdProduto.Location = new System.Drawing.Point(79, 3);
            this.txt_editIdProduto.Name = "txt_editIdProduto";
            this.txt_editIdProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_editIdProduto.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "ID:";
            // 
            // btn_deleteProduto
            // 
            this.btn_deleteProduto.Location = new System.Drawing.Point(229, 94);
            this.btn_deleteProduto.Name = "btn_deleteProduto";
            this.btn_deleteProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteProduto.TabIndex = 23;
            this.btn_deleteProduto.Text = "Apagar";
            this.btn_deleteProduto.UseVisualStyleBackColor = true;
            this.btn_deleteProduto.Click += new System.EventHandler(this.btn_deleteProduto_Click);
            // 
            // btn_editProduto
            // 
            this.btn_editProduto.Location = new System.Drawing.Point(136, 94);
            this.btn_editProduto.Name = "btn_editProduto";
            this.btn_editProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_editProduto.TabIndex = 22;
            this.btn_editProduto.Text = "Editar";
            this.btn_editProduto.UseVisualStyleBackColor = true;
            this.btn_editProduto.Click += new System.EventHandler(this.btn_editCliente_Click);
            // 
            // txt_editQuantidadeProduto
            // 
            this.txt_editQuantidadeProduto.Location = new System.Drawing.Point(275, 29);
            this.txt_editQuantidadeProduto.Name = "txt_editQuantidadeProduto";
            this.txt_editQuantidadeProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_editQuantidadeProduto.TabIndex = 21;
            // 
            // txt_editPrecoProduto
            // 
            this.txt_editPrecoProduto.Location = new System.Drawing.Point(275, 3);
            this.txt_editPrecoProduto.Name = "txt_editPrecoProduto";
            this.txt_editPrecoProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_editPrecoProduto.TabIndex = 20;
            // 
            // txt_editDescricaoProduto
            // 
            this.txt_editDescricaoProduto.Location = new System.Drawing.Point(79, 53);
            this.txt_editDescricaoProduto.Name = "txt_editDescricaoProduto";
            this.txt_editDescricaoProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_editDescricaoProduto.TabIndex = 19;
            // 
            // txt_editNomeProduto
            // 
            this.txt_editNomeProduto.Location = new System.Drawing.Point(79, 29);
            this.txt_editNomeProduto.Name = "txt_editNomeProduto";
            this.txt_editNomeProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_editNomeProduto.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Preço:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Descrição:";
            // 
            // btn_gerarPdfProdutos
            // 
            this.btn_gerarPdfProdutos.Enabled = false;
            this.btn_gerarPdfProdutos.Location = new System.Drawing.Point(713, 296);
            this.btn_gerarPdfProdutos.Name = "btn_gerarPdfProdutos";
            this.btn_gerarPdfProdutos.Size = new System.Drawing.Size(75, 23);
            this.btn_gerarPdfProdutos.TabIndex = 9;
            this.btn_gerarPdfProdutos.Text = "Gerar Pdf";
            this.btn_gerarPdfProdutos.UseVisualStyleBackColor = true;
            this.btn_gerarPdfProdutos.Click += new System.EventHandler(this.btn_gerarPdfProdutos_Click);
            // 
            // form_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.btn_gerarPdfProdutos);
            this.Controls.Add(this.panel_editDeleteProduto);
            this.Controls.Add(this.panel_addCliente);
            this.Controls.Add(this.panel_consultaProduto);
            this.Controls.Add(this.dgv_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conectarProduto);
            this.Name = "form_produto";
            this.Text = "Mini ERP - Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.panel_consultaProduto.ResumeLayout(false);
            this.panel_consultaProduto.PerformLayout();
            this.panel_addCliente.ResumeLayout(false);
            this.panel_addCliente.PerformLayout();
            this.panel_editDeleteProduto.ResumeLayout(false);
            this.panel_editDeleteProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_conectarProduto;
        private DataGridView dgv_produto;
        private Panel panel_consultaProduto;
        private Button btn_limparFiltroProduto;
        private Button btn_filtrarProduto;
        private TextBox txt_buscaNomeProduto;
        private Label label3;
        private Label label2;
        private Panel panel_addCliente;
        private Button btn_addProduto;
        private TextBox txt_addQuantidadeProduto;
        private TextBox txt_addPrecoProduto;
        private TextBox txt_addDescricaoProduto;
        private TextBox txt_addNomeProduto;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_addIdFornecedorProduto;
        private Label label9;
        private Panel panel_editDeleteProduto;
        private TextBox txt_editIdFornecedor;
        private Label label15;
        private TextBox txt_editIdProduto;
        private Label label13;
        private Button btn_deleteProduto;
        private Button btn_editProduto;
        private TextBox txt_editQuantidadeProduto;
        private TextBox txt_editPrecoProduto;
        private TextBox txt_editDescricaoProduto;
        private TextBox txt_editNomeProduto;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Button btn_gerarPdfProdutos;
    }
}