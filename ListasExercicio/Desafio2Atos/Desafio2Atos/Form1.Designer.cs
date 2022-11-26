namespace Desafio2Atos
{
    partial class form_notaFiscal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_conectar = new System.Windows.Forms.Button();
            this.dgv_notaFiscal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_navNota = new System.Windows.Forms.Panel();
            this.btn_goProdutos = new System.Windows.Forms.Button();
            this.btn_goFornecedores = new System.Windows.Forms.Button();
            this.btn_goClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_consultaNota = new System.Windows.Forms.Panel();
            this.btn_limpaFiltroNota = new System.Windows.Forms.Button();
            this.btn_filtrarNota = new System.Windows.Forms.Button();
            this.txt_buscaNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_editNota = new System.Windows.Forms.Panel();
            this.btn_deleteNota = new System.Windows.Forms.Button();
            this.btn_editNota = new System.Windows.Forms.Button();
            this.txt_editIdProduto = new System.Windows.Forms.TextBox();
            this.txt_editIdCliente = new System.Windows.Forms.TextBox();
            this.txt_editDataEmissao = new System.Windows.Forms.TextBox();
            this.txt_editIdNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_addNota = new System.Windows.Forms.Panel();
            this.btn_addNota = new System.Windows.Forms.Button();
            this.txt_addIdProduto = new System.Windows.Forms.TextBox();
            this.txt_addIdCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_addDataEmissao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_gerarPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notaFiscal)).BeginInit();
            this.panel_navNota.SuspendLayout();
            this.panel_consultaNota.SuspendLayout();
            this.panel_editNota.SuspendLayout();
            this.panel_addNota.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(117, 94);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // dgv_notaFiscal
            // 
            this.dgv_notaFiscal.AllowUserToAddRows = false;
            this.dgv_notaFiscal.AllowUserToDeleteRows = false;
            this.dgv_notaFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notaFiscal.Location = new System.Drawing.Point(330, 12);
            this.dgv_notaFiscal.Name = "dgv_notaFiscal";
            this.dgv_notaFiscal.ReadOnly = true;
            this.dgv_notaFiscal.RowHeadersVisible = false;
            this.dgv_notaFiscal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_notaFiscal.RowTemplate.Height = 25;
            this.dgv_notaFiscal.Size = new System.Drawing.Size(404, 201);
            this.dgv_notaFiscal.TabIndex = 1;
            this.dgv_notaFiscal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notaFiscal_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barra de Navegação";
            // 
            // panel_navNota
            // 
            this.panel_navNota.Controls.Add(this.btn_goProdutos);
            this.panel_navNota.Controls.Add(this.btn_goFornecedores);
            this.panel_navNota.Controls.Add(this.btn_goClientes);
            this.panel_navNota.Controls.Add(this.label1);
            this.panel_navNota.Location = new System.Drawing.Point(22, 12);
            this.panel_navNota.Name = "panel_navNota";
            this.panel_navNota.Size = new System.Drawing.Size(267, 61);
            this.panel_navNota.TabIndex = 3;
            // 
            // btn_goProdutos
            // 
            this.btn_goProdutos.Location = new System.Drawing.Point(182, 27);
            this.btn_goProdutos.Name = "btn_goProdutos";
            this.btn_goProdutos.Size = new System.Drawing.Size(75, 23);
            this.btn_goProdutos.TabIndex = 5;
            this.btn_goProdutos.Text = "Produtos";
            this.btn_goProdutos.UseVisualStyleBackColor = true;
            this.btn_goProdutos.Click += new System.EventHandler(this.btn_goProdutos_Click);
            // 
            // btn_goFornecedores
            // 
            this.btn_goFornecedores.Location = new System.Drawing.Point(84, 27);
            this.btn_goFornecedores.Name = "btn_goFornecedores";
            this.btn_goFornecedores.Size = new System.Drawing.Size(94, 23);
            this.btn_goFornecedores.TabIndex = 4;
            this.btn_goFornecedores.Text = "Fornecedores";
            this.btn_goFornecedores.UseVisualStyleBackColor = true;
            this.btn_goFornecedores.Click += new System.EventHandler(this.btn_goFornecedores_Click);
            // 
            // btn_goClientes
            // 
            this.btn_goClientes.Location = new System.Drawing.Point(3, 27);
            this.btn_goClientes.Name = "btn_goClientes";
            this.btn_goClientes.Size = new System.Drawing.Size(75, 23);
            this.btn_goClientes.TabIndex = 3;
            this.btn_goClientes.Text = "Clientes";
            this.btn_goClientes.UseVisualStyleBackColor = true;
            this.btn_goClientes.Click += new System.EventHandler(this.btn_goClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clique aqui para se conectar com o banco de dados";
            // 
            // panel_consultaNota
            // 
            this.panel_consultaNota.Controls.Add(this.btn_limpaFiltroNota);
            this.panel_consultaNota.Controls.Add(this.btn_filtrarNota);
            this.panel_consultaNota.Controls.Add(this.txt_buscaNota);
            this.panel_consultaNota.Controls.Add(this.label4);
            this.panel_consultaNota.Controls.Add(this.label3);
            this.panel_consultaNota.Enabled = false;
            this.panel_consultaNota.Location = new System.Drawing.Point(22, 123);
            this.panel_consultaNota.Name = "panel_consultaNota";
            this.panel_consultaNota.Size = new System.Drawing.Size(270, 101);
            this.panel_consultaNota.TabIndex = 5;
            // 
            // btn_limpaFiltroNota
            // 
            this.btn_limpaFiltroNota.Location = new System.Drawing.Point(147, 67);
            this.btn_limpaFiltroNota.Name = "btn_limpaFiltroNota";
            this.btn_limpaFiltroNota.Size = new System.Drawing.Size(96, 23);
            this.btn_limpaFiltroNota.TabIndex = 4;
            this.btn_limpaFiltroNota.Text = "Limpar Filtro";
            this.btn_limpaFiltroNota.UseVisualStyleBackColor = true;
            this.btn_limpaFiltroNota.Click += new System.EventHandler(this.btn_limpaFiltroNota_Click);
            // 
            // btn_filtrarNota
            // 
            this.btn_filtrarNota.Location = new System.Drawing.Point(21, 67);
            this.btn_filtrarNota.Name = "btn_filtrarNota";
            this.btn_filtrarNota.Size = new System.Drawing.Size(98, 23);
            this.btn_filtrarNota.TabIndex = 3;
            this.btn_filtrarNota.Text = "Aplicar Filtro";
            this.btn_filtrarNota.UseVisualStyleBackColor = true;
            this.btn_filtrarNota.Click += new System.EventHandler(this.btn_filtrarNota_Click);
            // 
            // txt_buscaNota
            // 
            this.txt_buscaNota.Location = new System.Drawing.Point(177, 38);
            this.txt_buscaNota.Name = "txt_buscaNota";
            this.txt_buscaNota.Size = new System.Drawing.Size(90, 23);
            this.txt_buscaNota.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data de emissão (dd/mm/yyyy):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta";
            // 
            // panel_editNota
            // 
            this.panel_editNota.Controls.Add(this.btn_deleteNota);
            this.panel_editNota.Controls.Add(this.btn_editNota);
            this.panel_editNota.Controls.Add(this.txt_editIdProduto);
            this.panel_editNota.Controls.Add(this.txt_editIdCliente);
            this.panel_editNota.Controls.Add(this.txt_editDataEmissao);
            this.panel_editNota.Controls.Add(this.txt_editIdNota);
            this.panel_editNota.Controls.Add(this.label8);
            this.panel_editNota.Controls.Add(this.label7);
            this.panel_editNota.Controls.Add(this.label6);
            this.panel_editNota.Controls.Add(this.label5);
            this.panel_editNota.Enabled = false;
            this.panel_editNota.Location = new System.Drawing.Point(330, 219);
            this.panel_editNota.Name = "panel_editNota";
            this.panel_editNota.Size = new System.Drawing.Size(364, 141);
            this.panel_editNota.TabIndex = 6;
            // 
            // btn_deleteNota
            // 
            this.btn_deleteNota.Location = new System.Drawing.Point(242, 79);
            this.btn_deleteNota.Name = "btn_deleteNota";
            this.btn_deleteNota.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteNota.TabIndex = 9;
            this.btn_deleteNota.Text = "Apagar";
            this.btn_deleteNota.UseVisualStyleBackColor = true;
            this.btn_deleteNota.Click += new System.EventHandler(this.btn_deleteNota_Click);
            // 
            // btn_editNota
            // 
            this.btn_editNota.Location = new System.Drawing.Point(242, 39);
            this.btn_editNota.Name = "btn_editNota";
            this.btn_editNota.Size = new System.Drawing.Size(75, 23);
            this.btn_editNota.TabIndex = 8;
            this.btn_editNota.Text = "Editar";
            this.btn_editNota.UseVisualStyleBackColor = true;
            this.btn_editNota.Click += new System.EventHandler(this.btn_editNota_Click);
            // 
            // txt_editIdProduto
            // 
            this.txt_editIdProduto.Location = new System.Drawing.Point(107, 104);
            this.txt_editIdProduto.Name = "txt_editIdProduto";
            this.txt_editIdProduto.Size = new System.Drawing.Size(95, 23);
            this.txt_editIdProduto.TabIndex = 7;
            // 
            // txt_editIdCliente
            // 
            this.txt_editIdCliente.Location = new System.Drawing.Point(107, 71);
            this.txt_editIdCliente.Name = "txt_editIdCliente";
            this.txt_editIdCliente.Size = new System.Drawing.Size(95, 23);
            this.txt_editIdCliente.TabIndex = 6;
            // 
            // txt_editDataEmissao
            // 
            this.txt_editDataEmissao.Location = new System.Drawing.Point(107, 40);
            this.txt_editDataEmissao.Name = "txt_editDataEmissao";
            this.txt_editDataEmissao.Size = new System.Drawing.Size(95, 23);
            this.txt_editDataEmissao.TabIndex = 5;
            // 
            // txt_editIdNota
            // 
            this.txt_editIdNota.Enabled = false;
            this.txt_editIdNota.Location = new System.Drawing.Point(107, 7);
            this.txt_editIdNota.Name = "txt_editIdNota";
            this.txt_editIdNota.Size = new System.Drawing.Size(95, 23);
            this.txt_editIdNota.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID Nota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Emissão:";
            // 
            // panel_addNota
            // 
            this.panel_addNota.Controls.Add(this.btn_addNota);
            this.panel_addNota.Controls.Add(this.txt_addIdProduto);
            this.panel_addNota.Controls.Add(this.txt_addIdCliente);
            this.panel_addNota.Controls.Add(this.label12);
            this.panel_addNota.Controls.Add(this.label11);
            this.panel_addNota.Controls.Add(this.txt_addDataEmissao);
            this.panel_addNota.Controls.Add(this.label9);
            this.panel_addNota.Controls.Add(this.label10);
            this.panel_addNota.Enabled = false;
            this.panel_addNota.Location = new System.Drawing.Point(22, 234);
            this.panel_addNota.Name = "panel_addNota";
            this.panel_addNota.Size = new System.Drawing.Size(270, 126);
            this.panel_addNota.TabIndex = 6;
            // 
            // btn_addNota
            // 
            this.btn_addNota.Location = new System.Drawing.Point(169, 64);
            this.btn_addNota.Name = "btn_addNota";
            this.btn_addNota.Size = new System.Drawing.Size(98, 23);
            this.btn_addNota.TabIndex = 10;
            this.btn_addNota.Text = "Criar";
            this.btn_addNota.UseVisualStyleBackColor = true;
            this.btn_addNota.Click += new System.EventHandler(this.btn_addNota_Click);
            // 
            // txt_addIdProduto
            // 
            this.txt_addIdProduto.Location = new System.Drawing.Point(70, 85);
            this.txt_addIdProduto.Name = "txt_addIdProduto";
            this.txt_addIdProduto.Size = new System.Drawing.Size(81, 23);
            this.txt_addIdProduto.TabIndex = 9;
            // 
            // txt_addIdCliente
            // 
            this.txt_addIdCliente.Location = new System.Drawing.Point(70, 56);
            this.txt_addIdCliente.Name = "txt_addIdCliente";
            this.txt_addIdCliente.Size = new System.Drawing.Size(81, 23);
            this.txt_addIdCliente.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "ID Produto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID Cliente:";
            // 
            // txt_addDataEmissao
            // 
            this.txt_addDataEmissao.Location = new System.Drawing.Point(177, 30);
            this.txt_addDataEmissao.Name = "txt_addDataEmissao";
            this.txt_addDataEmissao.Size = new System.Drawing.Size(90, 23);
            this.txt_addDataEmissao.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data de emissão (dd/mm/yyyy):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(99, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adicionar";
            // 
            // btn_gerarPDF
            // 
            this.btn_gerarPDF.Enabled = false;
            this.btn_gerarPDF.Location = new System.Drawing.Point(713, 285);
            this.btn_gerarPDF.Name = "btn_gerarPDF";
            this.btn_gerarPDF.Size = new System.Drawing.Size(75, 23);
            this.btn_gerarPDF.TabIndex = 7;
            this.btn_gerarPDF.Text = "Gerar PDF";
            this.btn_gerarPDF.UseVisualStyleBackColor = true;
            this.btn_gerarPDF.Click += new System.EventHandler(this.btn_gerarPDF_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(712, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Gerar PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(21, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 126);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Criar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "ID Produto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "ID Cliente:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Data de emissão (dd/mm/yyyy):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(99, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Adicionar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(329, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 141);
            this.panel2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(242, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(107, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 23);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 23);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(107, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 23);
            this.textBox7.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "ID Nota:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "ID Produto:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "ID Cliente:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Data Emissão:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(21, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 101);
            this.panel3.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(147, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Limpar Filtro";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Aplicar Filtro";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(177, 38);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(90, 23);
            this.textBox8.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "Data de emissão (dd/mm/yyyy):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(99, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "Consulta";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(280, 15);
            this.label23.TabIndex = 11;
            this.label23.Text = "Clique aqui para se conectar com o banco de dados";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(21, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 61);
            this.panel4.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(182, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Produtos";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Fornecedores";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Clientes";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(78, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "Barra de Navegação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(404, 201);
            this.dataGridView1.TabIndex = 9;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(116, 92);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "Conectar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // form_notaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_gerarPDF);
            this.Controls.Add(this.panel_addNota);
            this.Controls.Add(this.panel_editNota);
            this.Controls.Add(this.panel_consultaNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_navNota);
            this.Controls.Add(this.dgv_notaFiscal);
            this.Controls.Add(this.btn_conectar);
            this.Name = "form_notaFiscal";
            this.Text = "Mini ERP - Notas Fiscais";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notaFiscal)).EndInit();
            this.panel_navNota.ResumeLayout(false);
            this.panel_navNota.PerformLayout();
            this.panel_consultaNota.ResumeLayout(false);
            this.panel_consultaNota.PerformLayout();
            this.panel_editNota.ResumeLayout(false);
            this.panel_editNota.PerformLayout();
            this.panel_addNota.ResumeLayout(false);
            this.panel_addNota.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_conectar;
        private DataGridView dgv_notaFiscal;
        private Label label1;
        private Panel panel_navNota;
        private Button btn_goClientes;
        private Button btn_goProdutos;
        private Button btn_goFornecedores;
        private Label label2;
        private Panel panel_consultaNota;
        private TextBox txt_buscaNota;
        private Label label4;
        private Label label3;
        private Button btn_limpaFiltroNota;
        private Button btn_filtrarNota;
        private Panel panel_editNota;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txt_editIdProduto;
        private TextBox txt_editIdCliente;
        private TextBox txt_editDataEmissao;
        private TextBox txt_editIdNota;
        private Button btn_deleteNota;
        private Button btn_editNota;
        private Panel panel_addNota;
        private Button btn_addNota;
        private TextBox txt_addIdProduto;
        private TextBox txt_addIdCliente;
        private Label label12;
        private Label label11;
        private TextBox txt_addDataEmissao;
        private Label label9;
        private Label label10;
        private Button btn_gerarPDF;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label13;
        private Label label14;
        private TextBox textBox3;
        private Label label15;
        private Label label16;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Panel panel3;
        private Button button5;
        private Button button6;
        private TextBox textBox8;
        private Label label21;
        private Label label22;
        private Label label23;
        private Panel panel4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label24;
        private DataGridView dataGridView1;
        private Button button10;
    }
}