namespace Desafio2_1Atos
{
    partial class form_fornecedor
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
            this.btn_gerarPdfFornecedor = new System.Windows.Forms.Button();
            this.panel_editDeleteFornecedor = new System.Windows.Forms.Panel();
            this.txt_editIdFornecedor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_deleteFornecedor = new System.Windows.Forms.Button();
            this.btn_editCFornecedor = new System.Windows.Forms.Button();
            this.txt_editEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.txt_editEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txt_editNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_addFornecedor = new System.Windows.Forms.Panel();
            this.btn_addFornecedor = new System.Windows.Forms.Button();
            this.txt_addEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.txt_addEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txt_addNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_consultaFornecedor = new System.Windows.Forms.Panel();
            this.btn_limparFiltroFornecedor = new System.Windows.Forms.Button();
            this.btn_filtrarFornecedor = new System.Windows.Forms.Button();
            this.txt_buscaNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_fornecedor = new System.Windows.Forms.DataGridView();
            this.btn_conectarFornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_editDeleteFornecedor.SuspendLayout();
            this.panel_addFornecedor.SuspendLayout();
            this.panel_consultaFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gerarPdfFornecedor
            // 
            this.btn_gerarPdfFornecedor.Enabled = false;
            this.btn_gerarPdfFornecedor.Location = new System.Drawing.Point(712, 299);
            this.btn_gerarPdfFornecedor.Name = "btn_gerarPdfFornecedor";
            this.btn_gerarPdfFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_gerarPdfFornecedor.TabIndex = 14;
            this.btn_gerarPdfFornecedor.Text = "Gerar Pdf";
            this.btn_gerarPdfFornecedor.UseVisualStyleBackColor = true;
            this.btn_gerarPdfFornecedor.Click += new System.EventHandler(this.btn_gerarPdfFornecedor_Click);
            // 
            // panel_editDeleteFornecedor
            // 
            this.panel_editDeleteFornecedor.Controls.Add(this.txt_editIdFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.label13);
            this.panel_editDeleteFornecedor.Controls.Add(this.btn_deleteFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.btn_editCFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.txt_editEnderecoFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.txt_editEmailFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.txt_editNomeFornecedor);
            this.panel_editDeleteFornecedor.Controls.Add(this.label9);
            this.panel_editDeleteFornecedor.Controls.Add(this.label11);
            this.panel_editDeleteFornecedor.Controls.Add(this.label12);
            this.panel_editDeleteFornecedor.Enabled = false;
            this.panel_editDeleteFornecedor.Location = new System.Drawing.Point(366, 236);
            this.panel_editDeleteFornecedor.Name = "panel_editDeleteFornecedor";
            this.panel_editDeleteFornecedor.Size = new System.Drawing.Size(340, 126);
            this.panel_editDeleteFornecedor.TabIndex = 13;
            // 
            // txt_editIdFornecedor
            // 
            this.txt_editIdFornecedor.Enabled = false;
            this.txt_editIdFornecedor.Location = new System.Drawing.Point(79, 18);
            this.txt_editIdFornecedor.Name = "txt_editIdFornecedor";
            this.txt_editIdFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_editIdFornecedor.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "ID:";
            // 
            // btn_deleteFornecedor
            // 
            this.btn_deleteFornecedor.Location = new System.Drawing.Point(223, 80);
            this.btn_deleteFornecedor.Name = "btn_deleteFornecedor";
            this.btn_deleteFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteFornecedor.TabIndex = 23;
            this.btn_deleteFornecedor.Text = "Apagar";
            this.btn_deleteFornecedor.UseVisualStyleBackColor = true;
            this.btn_deleteFornecedor.Click += new System.EventHandler(this.btn_deleteFornecedor_Click);
            // 
            // btn_editCFornecedor
            // 
            this.btn_editCFornecedor.Location = new System.Drawing.Point(223, 47);
            this.btn_editCFornecedor.Name = "btn_editCFornecedor";
            this.btn_editCFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_editCFornecedor.TabIndex = 22;
            this.btn_editCFornecedor.Text = "Editar";
            this.btn_editCFornecedor.UseVisualStyleBackColor = true;
            this.btn_editCFornecedor.Click += new System.EventHandler(this.btn_editCFornecedor_Click);
            // 
            // txt_editEnderecoFornecedor
            // 
            this.txt_editEnderecoFornecedor.Location = new System.Drawing.Point(79, 98);
            this.txt_editEnderecoFornecedor.Name = "txt_editEnderecoFornecedor";
            this.txt_editEnderecoFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_editEnderecoFornecedor.TabIndex = 20;
            // 
            // txt_editEmailFornecedor
            // 
            this.txt_editEmailFornecedor.Location = new System.Drawing.Point(79, 71);
            this.txt_editEmailFornecedor.Name = "txt_editEmailFornecedor";
            this.txt_editEmailFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_editEmailFornecedor.TabIndex = 19;
            // 
            // txt_editNomeFornecedor
            // 
            this.txt_editNomeFornecedor.Location = new System.Drawing.Point(79, 44);
            this.txt_editNomeFornecedor.Name = "txt_editNomeFornecedor";
            this.txt_editNomeFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_editNomeFornecedor.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Endereço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email:";
            // 
            // panel_addFornecedor
            // 
            this.panel_addFornecedor.Controls.Add(this.btn_addFornecedor);
            this.panel_addFornecedor.Controls.Add(this.txt_addEnderecoFornecedor);
            this.panel_addFornecedor.Controls.Add(this.txt_addEmailFornecedor);
            this.panel_addFornecedor.Controls.Add(this.txt_addNomeFornecedor);
            this.panel_addFornecedor.Controls.Add(this.label7);
            this.panel_addFornecedor.Controls.Add(this.label6);
            this.panel_addFornecedor.Controls.Add(this.label5);
            this.panel_addFornecedor.Controls.Add(this.label4);
            this.panel_addFornecedor.Enabled = false;
            this.panel_addFornecedor.Location = new System.Drawing.Point(13, 236);
            this.panel_addFornecedor.Name = "panel_addFornecedor";
            this.panel_addFornecedor.Size = new System.Drawing.Size(306, 132);
            this.panel_addFornecedor.TabIndex = 12;
            // 
            // btn_addFornecedor
            // 
            this.btn_addFornecedor.Location = new System.Drawing.Point(221, 68);
            this.btn_addFornecedor.Name = "btn_addFornecedor";
            this.btn_addFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_addFornecedor.TabIndex = 14;
            this.btn_addFornecedor.Text = "Criar";
            this.btn_addFornecedor.UseVisualStyleBackColor = true;
            this.btn_addFornecedor.Click += new System.EventHandler(this.btn_addFornecedor_Click);
            // 
            // txt_addEnderecoFornecedor
            // 
            this.txt_addEnderecoFornecedor.Location = new System.Drawing.Point(68, 95);
            this.txt_addEnderecoFornecedor.Name = "txt_addEnderecoFornecedor";
            this.txt_addEnderecoFornecedor.Size = new System.Drawing.Size(147, 23);
            this.txt_addEnderecoFornecedor.TabIndex = 12;
            // 
            // txt_addEmailFornecedor
            // 
            this.txt_addEmailFornecedor.Location = new System.Drawing.Point(68, 68);
            this.txt_addEmailFornecedor.Name = "txt_addEmailFornecedor";
            this.txt_addEmailFornecedor.Size = new System.Drawing.Size(147, 23);
            this.txt_addEmailFornecedor.TabIndex = 11;
            // 
            // txt_addNomeFornecedor
            // 
            this.txt_addNomeFornecedor.Location = new System.Drawing.Point(68, 41);
            this.txt_addNomeFornecedor.Name = "txt_addNomeFornecedor";
            this.txt_addNomeFornecedor.Size = new System.Drawing.Size(147, 23);
            this.txt_addNomeFornecedor.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(115, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adicionar";
            // 
            // panel_consultaFornecedor
            // 
            this.panel_consultaFornecedor.Controls.Add(this.btn_limparFiltroFornecedor);
            this.panel_consultaFornecedor.Controls.Add(this.btn_filtrarFornecedor);
            this.panel_consultaFornecedor.Controls.Add(this.txt_buscaNomeFornecedor);
            this.panel_consultaFornecedor.Controls.Add(this.label3);
            this.panel_consultaFornecedor.Controls.Add(this.label2);
            this.panel_consultaFornecedor.Enabled = false;
            this.panel_consultaFornecedor.Location = new System.Drawing.Point(22, 65);
            this.panel_consultaFornecedor.Name = "panel_consultaFornecedor";
            this.panel_consultaFornecedor.Size = new System.Drawing.Size(277, 132);
            this.panel_consultaFornecedor.TabIndex = 11;
            // 
            // btn_limparFiltroFornecedor
            // 
            this.btn_limparFiltroFornecedor.Location = new System.Drawing.Point(148, 82);
            this.btn_limparFiltroFornecedor.Name = "btn_limparFiltroFornecedor";
            this.btn_limparFiltroFornecedor.Size = new System.Drawing.Size(89, 23);
            this.btn_limparFiltroFornecedor.TabIndex = 9;
            this.btn_limparFiltroFornecedor.Text = "Limpar Filtro";
            this.btn_limparFiltroFornecedor.UseVisualStyleBackColor = true;
            this.btn_limparFiltroFornecedor.Click += new System.EventHandler(this.btn_limparFiltroFornecedor_Click);
            // 
            // btn_filtrarFornecedor
            // 
            this.btn_filtrarFornecedor.Location = new System.Drawing.Point(31, 82);
            this.btn_filtrarFornecedor.Name = "btn_filtrarFornecedor";
            this.btn_filtrarFornecedor.Size = new System.Drawing.Size(93, 23);
            this.btn_filtrarFornecedor.TabIndex = 8;
            this.btn_filtrarFornecedor.Text = "Aplicar Filtro";
            this.btn_filtrarFornecedor.UseVisualStyleBackColor = true;
            this.btn_filtrarFornecedor.Click += new System.EventHandler(this.btn_filtrarFornecedor_Click);
            // 
            // txt_buscaNomeFornecedor
            // 
            this.txt_buscaNomeFornecedor.Location = new System.Drawing.Point(115, 42);
            this.txt_buscaNomeFornecedor.Name = "txt_buscaNomeFornecedor";
            this.txt_buscaNomeFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txt_buscaNomeFornecedor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consulta";
            // 
            // dgv_fornecedor
            // 
            this.dgv_fornecedor.AllowUserToAddRows = false;
            this.dgv_fornecedor.AllowUserToDeleteRows = false;
            this.dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fornecedor.Location = new System.Drawing.Point(335, 18);
            this.dgv_fornecedor.Name = "dgv_fornecedor";
            this.dgv_fornecedor.ReadOnly = true;
            this.dgv_fornecedor.RowHeadersVisible = false;
            this.dgv_fornecedor.RowTemplate.Height = 25;
            this.dgv_fornecedor.Size = new System.Drawing.Size(403, 204);
            this.dgv_fornecedor.TabIndex = 10;
            this.dgv_fornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fornecedor_CellClick);
            // 
            // btn_conectarFornecedor
            // 
            this.btn_conectarFornecedor.Location = new System.Drawing.Point(128, 36);
            this.btn_conectarFornecedor.Name = "btn_conectarFornecedor";
            this.btn_conectarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btn_conectarFornecedor.TabIndex = 9;
            this.btn_conectarFornecedor.Text = "Conectar";
            this.btn_conectarFornecedor.UseVisualStyleBackColor = true;
            this.btn_conectarFornecedor.Click += new System.EventHandler(this.btn_conectarFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conectar com Banco de Dados";
            // 
            // form_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.btn_gerarPdfFornecedor);
            this.Controls.Add(this.panel_editDeleteFornecedor);
            this.Controls.Add(this.panel_addFornecedor);
            this.Controls.Add(this.panel_consultaFornecedor);
            this.Controls.Add(this.dgv_fornecedor);
            this.Controls.Add(this.btn_conectarFornecedor);
            this.Controls.Add(this.label1);
            this.Name = "form_fornecedor";
            this.Text = "Mini ERP - Fornecedores";
            this.panel_editDeleteFornecedor.ResumeLayout(false);
            this.panel_editDeleteFornecedor.PerformLayout();
            this.panel_addFornecedor.ResumeLayout(false);
            this.panel_addFornecedor.PerformLayout();
            this.panel_consultaFornecedor.ResumeLayout(false);
            this.panel_consultaFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_gerarPdfFornecedor;
        private Panel panel_editDeleteFornecedor;
        private TextBox txt_editIdFornecedor;
        private Label label13;
        private Button btn_deleteFornecedor;
        private Button btn_editCFornecedor;
        private TextBox txt_editEnderecoFornecedor;
        private TextBox txt_editEmailFornecedor;
        private TextBox txt_editNomeFornecedor;
        private Label label9;
        private Label label11;
        private Label label12;
        private Panel panel_addFornecedor;
        private Button btn_addFornecedor;
        private TextBox txt_addEnderecoFornecedor;
        private TextBox txt_addEmailFornecedor;
        private TextBox txt_addNomeFornecedor;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel_consultaFornecedor;
        private Button btn_limparFiltroFornecedor;
        private Button btn_filtrarFornecedor;
        private TextBox txt_buscaNomeFornecedor;
        private Label label3;
        private Label label2;
        private DataGridView dgv_fornecedor;
        private Button btn_conectarFornecedor;
        private Label label1;
    }
}