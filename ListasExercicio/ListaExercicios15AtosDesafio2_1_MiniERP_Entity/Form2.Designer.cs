namespace Desafio2_1Atos
{
    partial class form_cliente
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
            this.btn_gerarPdfCliente = new System.Windows.Forms.Button();
            this.panel_editDeleteCliente = new System.Windows.Forms.Panel();
            this.txt_editIdCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_deleteCliente = new System.Windows.Forms.Button();
            this.btn_editCliente = new System.Windows.Forms.Button();
            this.txt_editCpfCliente = new System.Windows.Forms.TextBox();
            this.txt_editCidadeCliente = new System.Windows.Forms.TextBox();
            this.txt_editEmailCliente = new System.Windows.Forms.TextBox();
            this.txt_editNomeCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_addCliente = new System.Windows.Forms.Panel();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.txt_addCpfCliente = new System.Windows.Forms.TextBox();
            this.txt_addCidadeCliente = new System.Windows.Forms.TextBox();
            this.txt_addEmailCliente = new System.Windows.Forms.TextBox();
            this.txt_addNomeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_consultaCliente = new System.Windows.Forms.Panel();
            this.btn_limparFiltroCliente = new System.Windows.Forms.Button();
            this.btn_filtrarCliente = new System.Windows.Forms.Button();
            this.txt_buscaNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.btn_conectarCliente = new System.Windows.Forms.Button();
            this.panel_editDeleteCliente.SuspendLayout();
            this.panel_addCliente.SuspendLayout();
            this.panel_consultaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gerarPdfCliente
            // 
            this.btn_gerarPdfCliente.Enabled = false;
            this.btn_gerarPdfCliente.Location = new System.Drawing.Point(718, 283);
            this.btn_gerarPdfCliente.Name = "btn_gerarPdfCliente";
            this.btn_gerarPdfCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_gerarPdfCliente.TabIndex = 13;
            this.btn_gerarPdfCliente.Text = "Gerar PDF";
            this.btn_gerarPdfCliente.UseVisualStyleBackColor = true;
            this.btn_gerarPdfCliente.Click += new System.EventHandler(this.btn_gerarPdfCliente_Click);
            // 
            // panel_editDeleteCliente
            // 
            this.panel_editDeleteCliente.Controls.Add(this.txt_editIdCliente);
            this.panel_editDeleteCliente.Controls.Add(this.label13);
            this.panel_editDeleteCliente.Controls.Add(this.btn_deleteCliente);
            this.panel_editDeleteCliente.Controls.Add(this.btn_editCliente);
            this.panel_editDeleteCliente.Controls.Add(this.txt_editCpfCliente);
            this.panel_editDeleteCliente.Controls.Add(this.txt_editCidadeCliente);
            this.panel_editDeleteCliente.Controls.Add(this.txt_editEmailCliente);
            this.panel_editDeleteCliente.Controls.Add(this.txt_editNomeCliente);
            this.panel_editDeleteCliente.Controls.Add(this.label10);
            this.panel_editDeleteCliente.Controls.Add(this.label9);
            this.panel_editDeleteCliente.Controls.Add(this.label11);
            this.panel_editDeleteCliente.Controls.Add(this.label12);
            this.panel_editDeleteCliente.Enabled = false;
            this.panel_editDeleteCliente.Location = new System.Drawing.Point(344, 213);
            this.panel_editDeleteCliente.Name = "panel_editDeleteCliente";
            this.panel_editDeleteCliente.Size = new System.Drawing.Size(354, 152);
            this.panel_editDeleteCliente.TabIndex = 12;
            // 
            // txt_editIdCliente
            // 
            this.txt_editIdCliente.Enabled = false;
            this.txt_editIdCliente.Location = new System.Drawing.Point(63, 18);
            this.txt_editIdCliente.Name = "txt_editIdCliente";
            this.txt_editIdCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_editIdCliente.TabIndex = 25;
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
            // btn_deleteCliente
            // 
            this.btn_deleteCliente.Location = new System.Drawing.Point(223, 80);
            this.btn_deleteCliente.Name = "btn_deleteCliente";
            this.btn_deleteCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteCliente.TabIndex = 23;
            this.btn_deleteCliente.Text = "Apagar";
            this.btn_deleteCliente.UseVisualStyleBackColor = true;
            this.btn_deleteCliente.Click += new System.EventHandler(this.btn_deleteCliente_Click);
            // 
            // btn_editCliente
            // 
            this.btn_editCliente.Location = new System.Drawing.Point(223, 47);
            this.btn_editCliente.Name = "btn_editCliente";
            this.btn_editCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_editCliente.TabIndex = 22;
            this.btn_editCliente.Text = "Editar";
            this.btn_editCliente.UseVisualStyleBackColor = true;
            this.btn_editCliente.Click += new System.EventHandler(this.btn_editCliente_Click);
            // 
            // txt_editCpfCliente
            // 
            this.txt_editCpfCliente.Location = new System.Drawing.Point(63, 125);
            this.txt_editCpfCliente.Name = "txt_editCpfCliente";
            this.txt_editCpfCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_editCpfCliente.TabIndex = 21;
            // 
            // txt_editCidadeCliente
            // 
            this.txt_editCidadeCliente.Location = new System.Drawing.Point(63, 98);
            this.txt_editCidadeCliente.Name = "txt_editCidadeCliente";
            this.txt_editCidadeCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_editCidadeCliente.TabIndex = 20;
            // 
            // txt_editEmailCliente
            // 
            this.txt_editEmailCliente.Location = new System.Drawing.Point(63, 71);
            this.txt_editEmailCliente.Name = "txt_editEmailCliente";
            this.txt_editEmailCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_editEmailCliente.TabIndex = 19;
            // 
            // txt_editNomeCliente
            // 
            this.txt_editNomeCliente.Location = new System.Drawing.Point(63, 44);
            this.txt_editNomeCliente.Name = "txt_editNomeCliente";
            this.txt_editNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_editNomeCliente.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "CPF:";
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
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cidade:";
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
            // panel_addCliente
            // 
            this.panel_addCliente.Controls.Add(this.btn_addCliente);
            this.panel_addCliente.Controls.Add(this.txt_addCpfCliente);
            this.panel_addCliente.Controls.Add(this.txt_addCidadeCliente);
            this.panel_addCliente.Controls.Add(this.txt_addEmailCliente);
            this.panel_addCliente.Controls.Add(this.txt_addNomeCliente);
            this.panel_addCliente.Controls.Add(this.label8);
            this.panel_addCliente.Controls.Add(this.label7);
            this.panel_addCliente.Controls.Add(this.label6);
            this.panel_addCliente.Controls.Add(this.label5);
            this.panel_addCliente.Controls.Add(this.label4);
            this.panel_addCliente.Enabled = false;
            this.panel_addCliente.Location = new System.Drawing.Point(7, 207);
            this.panel_addCliente.Name = "panel_addCliente";
            this.panel_addCliente.Size = new System.Drawing.Size(222, 165);
            this.panel_addCliente.TabIndex = 11;
            // 
            // btn_addCliente
            // 
            this.btn_addCliente.Location = new System.Drawing.Point(67, 139);
            this.btn_addCliente.Name = "btn_addCliente";
            this.btn_addCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_addCliente.TabIndex = 14;
            this.btn_addCliente.Text = "Criar";
            this.btn_addCliente.UseVisualStyleBackColor = true;
            this.btn_addCliente.Click += new System.EventHandler(this.btn_addCliente_Click);
            // 
            // txt_addCpfCliente
            // 
            this.txt_addCpfCliente.Location = new System.Drawing.Point(56, 110);
            this.txt_addCpfCliente.Name = "txt_addCpfCliente";
            this.txt_addCpfCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_addCpfCliente.TabIndex = 13;
            // 
            // txt_addCidadeCliente
            // 
            this.txt_addCidadeCliente.Location = new System.Drawing.Point(56, 83);
            this.txt_addCidadeCliente.Name = "txt_addCidadeCliente";
            this.txt_addCidadeCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_addCidadeCliente.TabIndex = 12;
            // 
            // txt_addEmailCliente
            // 
            this.txt_addEmailCliente.Location = new System.Drawing.Point(56, 56);
            this.txt_addEmailCliente.Name = "txt_addEmailCliente";
            this.txt_addEmailCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_addEmailCliente.TabIndex = 11;
            // 
            // txt_addNomeCliente
            // 
            this.txt_addNomeCliente.Location = new System.Drawing.Point(56, 29);
            this.txt_addNomeCliente.Name = "txt_addNomeCliente";
            this.txt_addNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_addNomeCliente.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
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
            this.label4.Location = new System.Drawing.Point(76, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adicionar";
            // 
            // panel_consultaCliente
            // 
            this.panel_consultaCliente.Controls.Add(this.btn_limparFiltroCliente);
            this.panel_consultaCliente.Controls.Add(this.btn_filtrarCliente);
            this.panel_consultaCliente.Controls.Add(this.txt_buscaNomeCliente);
            this.panel_consultaCliente.Controls.Add(this.label3);
            this.panel_consultaCliente.Controls.Add(this.label2);
            this.panel_consultaCliente.Enabled = false;
            this.panel_consultaCliente.Location = new System.Drawing.Point(7, 71);
            this.panel_consultaCliente.Name = "panel_consultaCliente";
            this.panel_consultaCliente.Size = new System.Drawing.Size(222, 117);
            this.panel_consultaCliente.TabIndex = 10;
            // 
            // btn_limparFiltroCliente
            // 
            this.btn_limparFiltroCliente.Location = new System.Drawing.Point(124, 78);
            this.btn_limparFiltroCliente.Name = "btn_limparFiltroCliente";
            this.btn_limparFiltroCliente.Size = new System.Drawing.Size(89, 23);
            this.btn_limparFiltroCliente.TabIndex = 4;
            this.btn_limparFiltroCliente.Text = "Limpar Filtro";
            this.btn_limparFiltroCliente.UseVisualStyleBackColor = true;
            this.btn_limparFiltroCliente.Click += new System.EventHandler(this.btn_limparFiltroCliente_Click);
            // 
            // btn_filtrarCliente
            // 
            this.btn_filtrarCliente.Location = new System.Drawing.Point(7, 78);
            this.btn_filtrarCliente.Name = "btn_filtrarCliente";
            this.btn_filtrarCliente.Size = new System.Drawing.Size(93, 23);
            this.btn_filtrarCliente.TabIndex = 3;
            this.btn_filtrarCliente.Text = "Aplicar Filtro";
            this.btn_filtrarCliente.UseVisualStyleBackColor = true;
            this.btn_filtrarCliente.Click += new System.EventHandler(this.btn_filtrarCliente_Click);
            // 
            // txt_buscaNomeCliente
            // 
            this.txt_buscaNomeCliente.Location = new System.Drawing.Point(91, 38);
            this.txt_buscaNomeCliente.Name = "txt_buscaNomeCliente";
            this.txt_buscaNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.txt_buscaNomeCliente.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conectar com Banco de Dados";
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(276, 14);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.RowHeadersVisible = false;
            this.dgv_cliente.RowTemplate.Height = 25;
            this.dgv_cliente.Size = new System.Drawing.Size(503, 193);
            this.dgv_cliente.TabIndex = 8;
            this.dgv_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellClick);
            // 
            // btn_conectarCliente
            // 
            this.btn_conectarCliente.Location = new System.Drawing.Point(83, 32);
            this.btn_conectarCliente.Name = "btn_conectarCliente";
            this.btn_conectarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_conectarCliente.TabIndex = 7;
            this.btn_conectarCliente.Text = "Conectar";
            this.btn_conectarCliente.UseVisualStyleBackColor = true;
            this.btn_conectarCliente.Click += new System.EventHandler(this.btn_conectarCliente_Click);
            // 
            // form_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.btn_gerarPdfCliente);
            this.Controls.Add(this.panel_editDeleteCliente);
            this.Controls.Add(this.panel_addCliente);
            this.Controls.Add(this.panel_consultaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cliente);
            this.Controls.Add(this.btn_conectarCliente);
            this.Name = "form_cliente";
            this.Text = "Mini ERP - Clientes";
            this.panel_editDeleteCliente.ResumeLayout(false);
            this.panel_editDeleteCliente.PerformLayout();
            this.panel_addCliente.ResumeLayout(false);
            this.panel_addCliente.PerformLayout();
            this.panel_consultaCliente.ResumeLayout(false);
            this.panel_consultaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_gerarPdfCliente;
        private Panel panel_editDeleteCliente;
        private TextBox txt_editIdCliente;
        private Label label13;
        private Button btn_deleteCliente;
        private Button btn_editCliente;
        private TextBox txt_editCpfCliente;
        private TextBox txt_editCidadeCliente;
        private TextBox txt_editEmailCliente;
        private TextBox txt_editNomeCliente;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Panel panel_addCliente;
        private Button btn_addCliente;
        private TextBox txt_addCpfCliente;
        private TextBox txt_addCidadeCliente;
        private TextBox txt_addEmailCliente;
        private TextBox txt_addNomeCliente;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel_consultaCliente;
        private Button btn_limparFiltroCliente;
        private Button btn_filtrarCliente;
        private TextBox txt_buscaNomeCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_cliente;
        private Button btn_conectarCliente;
    }
}