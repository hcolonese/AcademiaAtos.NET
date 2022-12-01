namespace ListaExercicios11Num3cBancoAtos
{
    partial class Form1
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
            this.listView_Moeda = new System.Windows.Forms.ListView();
            this.idMoeda = new System.Windows.Forms.ColumnHeader();
            this.siglaMoeda = new System.Windows.Forms.ColumnHeader();
            this.nomeMoeda = new System.Windows.Forms.ColumnHeader();
            this.valorUnitario = new System.Windows.Forms.ColumnHeader();
            this.panel_Cadastro = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txtb_valorMoeda = new System.Windows.Forms.TextBox();
            this.txtb_nomeMoeda = new System.Windows.Forms.TextBox();
            this.txtb_siglaMoeda = new System.Windows.Forms.TextBox();
            this.txtb_idMoeda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel_buscar = new System.Windows.Forms.Panel();
            this.txtb_valorBusca = new System.Windows.Forms.TextBox();
            this.txtb_nomeBusca = new System.Windows.Forms.TextBox();
            this.txtb_idBusca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_buscaMoeda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Cadastro.SuspendLayout();
            this.panel_buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(12, 194);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // listView_Moeda
            // 
            this.listView_Moeda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMoeda,
            this.siglaMoeda,
            this.nomeMoeda,
            this.valorUnitario});
            this.listView_Moeda.Location = new System.Drawing.Point(12, 12);
            this.listView_Moeda.Name = "listView_Moeda";
            this.listView_Moeda.Size = new System.Drawing.Size(358, 177);
            this.listView_Moeda.TabIndex = 1;
            this.listView_Moeda.UseCompatibleStateImageBehavior = false;
            this.listView_Moeda.View = System.Windows.Forms.View.Details;
            this.listView_Moeda.SelectedIndexChanged += new System.EventHandler(this.listView_Moeda_SelectedIndexChanged);
            // 
            // idMoeda
            // 
            this.idMoeda.Text = "Id Moeda";
            this.idMoeda.Width = 70;
            // 
            // siglaMoeda
            // 
            this.siglaMoeda.Text = "Sigla";
            // 
            // nomeMoeda
            // 
            this.nomeMoeda.Text = "Nome";
            this.nomeMoeda.Width = 120;
            // 
            // valorUnitario
            // 
            this.valorUnitario.Text = "Valor unitário";
            this.valorUnitario.Width = 100;
            // 
            // panel_Cadastro
            // 
            this.panel_Cadastro.Controls.Add(this.btn_salvar);
            this.panel_Cadastro.Controls.Add(this.txtb_valorMoeda);
            this.panel_Cadastro.Controls.Add(this.txtb_nomeMoeda);
            this.panel_Cadastro.Controls.Add(this.txtb_siglaMoeda);
            this.panel_Cadastro.Controls.Add(this.txtb_idMoeda);
            this.panel_Cadastro.Controls.Add(this.label4);
            this.panel_Cadastro.Controls.Add(this.label3);
            this.panel_Cadastro.Controls.Add(this.label2);
            this.panel_Cadastro.Controls.Add(this.label1);
            this.panel_Cadastro.Enabled = false;
            this.panel_Cadastro.Location = new System.Drawing.Point(12, 223);
            this.panel_Cadastro.Name = "panel_Cadastro";
            this.panel_Cadastro.Size = new System.Drawing.Size(196, 160);
            this.panel_Cadastro.TabIndex = 2;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(50, 127);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txtb_valorMoeda
            // 
            this.txtb_valorMoeda.Location = new System.Drawing.Point(85, 82);
            this.txtb_valorMoeda.Name = "txtb_valorMoeda";
            this.txtb_valorMoeda.Size = new System.Drawing.Size(100, 23);
            this.txtb_valorMoeda.TabIndex = 7;
            // 
            // txtb_nomeMoeda
            // 
            this.txtb_nomeMoeda.Location = new System.Drawing.Point(85, 58);
            this.txtb_nomeMoeda.Name = "txtb_nomeMoeda";
            this.txtb_nomeMoeda.Size = new System.Drawing.Size(100, 23);
            this.txtb_nomeMoeda.TabIndex = 6;
            // 
            // txtb_siglaMoeda
            // 
            this.txtb_siglaMoeda.Location = new System.Drawing.Point(85, 33);
            this.txtb_siglaMoeda.Name = "txtb_siglaMoeda";
            this.txtb_siglaMoeda.Size = new System.Drawing.Size(100, 23);
            this.txtb_siglaMoeda.TabIndex = 5;
            // 
            // txtb_idMoeda
            // 
            this.txtb_idMoeda.Enabled = false;
            this.txtb_idMoeda.Location = new System.Drawing.Point(85, 7);
            this.txtb_idMoeda.Name = "txtb_idMoeda";
            this.txtb_idMoeda.Size = new System.Drawing.Size(100, 23);
            this.txtb_idMoeda.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Moeda";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Enabled = false;
            this.btn_cadastrar.Location = new System.Drawing.Point(93, 194);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(174, 194);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Location = new System.Drawing.Point(255, 194);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(59, 53);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // panel_buscar
            // 
            this.panel_buscar.Controls.Add(this.txtb_valorBusca);
            this.panel_buscar.Controls.Add(this.txtb_nomeBusca);
            this.panel_buscar.Controls.Add(this.txtb_idBusca);
            this.panel_buscar.Controls.Add(this.label9);
            this.panel_buscar.Controls.Add(this.label8);
            this.panel_buscar.Controls.Add(this.label7);
            this.panel_buscar.Controls.Add(this.txtb_buscaMoeda);
            this.panel_buscar.Controls.Add(this.label6);
            this.panel_buscar.Controls.Add(this.label5);
            this.panel_buscar.Controls.Add(this.btn_buscar);
            this.panel_buscar.Location = new System.Drawing.Point(214, 223);
            this.panel_buscar.Name = "panel_buscar";
            this.panel_buscar.Size = new System.Drawing.Size(156, 160);
            this.panel_buscar.TabIndex = 7;
            // 
            // txtb_valorBusca
            // 
            this.txtb_valorBusca.Location = new System.Drawing.Point(52, 130);
            this.txtb_valorBusca.Name = "txtb_valorBusca";
            this.txtb_valorBusca.Size = new System.Drawing.Size(100, 23);
            this.txtb_valorBusca.TabIndex = 15;
            // 
            // txtb_nomeBusca
            // 
            this.txtb_nomeBusca.Location = new System.Drawing.Point(52, 105);
            this.txtb_nomeBusca.Name = "txtb_nomeBusca";
            this.txtb_nomeBusca.Size = new System.Drawing.Size(100, 23);
            this.txtb_nomeBusca.TabIndex = 14;
            // 
            // txtb_idBusca
            // 
            this.txtb_idBusca.Location = new System.Drawing.Point(52, 77);
            this.txtb_idBusca.Name = "txtb_idBusca";
            this.txtb_idBusca.Size = new System.Drawing.Size(100, 23);
            this.txtb_idBusca.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome";
            // 
            // txtb_buscaMoeda
            // 
            this.txtb_buscaMoeda.Location = new System.Drawing.Point(52, 25);
            this.txtb_buscaMoeda.Name = "txtb_buscaMoeda";
            this.txtb_buscaMoeda.Size = new System.Drawing.Size(100, 23);
            this.txtb_buscaMoeda.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Busca por Moedas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 389);
            this.Controls.Add(this.panel_buscar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.panel_Cadastro);
            this.Controls.Add(this.listView_Moeda);
            this.Controls.Add(this.btn_conectar);
            this.Name = "Form1";
            this.Text = "Gerênciamento de CriptoMoedas";
            this.panel_Cadastro.ResumeLayout(false);
            this.panel_Cadastro.PerformLayout();
            this.panel_buscar.ResumeLayout(false);
            this.panel_buscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_conectar;
        private ListView listView_Moeda;
        private ColumnHeader idMoeda;
        private ColumnHeader siglaMoeda;
        private ColumnHeader nomeMoeda;
        private ColumnHeader valorUnitario;
        private Panel panel_Cadastro;
        private TextBox txtb_valorMoeda;
        private TextBox txtb_nomeMoeda;
        private TextBox txtb_siglaMoeda;
        private TextBox txtb_idMoeda;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_cadastrar;
        private Button btn_deletar;
        private Button btn_editar;
        private Button btn_buscar;
        private Button btn_salvar;
        private Panel panel_buscar;
        private TextBox txtb_buscaMoeda;
        private Label label6;
        private Label label5;
        private TextBox txtb_idBusca;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtb_valorBusca;
        private TextBox txtb_nomeBusca;
    }
}