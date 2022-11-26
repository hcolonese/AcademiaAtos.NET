namespace CRUDglisemia
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
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.txtb_idMedida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_idPaciente = new System.Windows.Forms.TextBox();
            this.txtb_dataMedicao = new System.Windows.Forms.TextBox();
            this.txtb_valGlicemia = new System.Windows.Forms.TextBox();
            this.lbl_idPaciente = new System.Windows.Forms.Label();
            this.lbl_dataMedicao = new System.Windows.Forms.Label();
            this.lbl_valorGlicemia = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.idMedida = new System.Windows.Forms.ColumnHeader();
            this.ValorGlicemico = new System.Windows.Forms.ColumnHeader();
            this.DataMedicao = new System.Windows.Forms.ColumnHeader();
            this.Paciente = new System.Windows.Forms.ColumnHeader();
            this.IdPaciente = new System.Windows.Forms.ColumnHeader();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.txtb_idMedida);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Controls.Add(this.txtb_idPaciente);
            this.panelCadastro.Controls.Add(this.txtb_dataMedicao);
            this.panelCadastro.Controls.Add(this.txtb_valGlicemia);
            this.panelCadastro.Controls.Add(this.lbl_idPaciente);
            this.panelCadastro.Controls.Add(this.lbl_dataMedicao);
            this.panelCadastro.Controls.Add(this.lbl_valorGlicemia);
            this.panelCadastro.Controls.Add(this.btn_salvar);
            this.panelCadastro.Enabled = false;
            this.panelCadastro.Location = new System.Drawing.Point(12, 250);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(581, 168);
            this.panelCadastro.TabIndex = 0;
            // 
            // txtb_idMedida
            // 
            this.txtb_idMedida.Enabled = false;
            this.txtb_idMedida.Location = new System.Drawing.Point(88, 10);
            this.txtb_idMedida.Name = "txtb_idMedida";
            this.txtb_idMedida.Size = new System.Drawing.Size(100, 23);
            this.txtb_idMedida.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Medida";
            // 
            // txtb_idPaciente
            // 
            this.txtb_idPaciente.Location = new System.Drawing.Point(88, 97);
            this.txtb_idPaciente.Name = "txtb_idPaciente";
            this.txtb_idPaciente.Size = new System.Drawing.Size(100, 23);
            this.txtb_idPaciente.TabIndex = 6;
            // 
            // txtb_dataMedicao
            // 
            this.txtb_dataMedicao.Location = new System.Drawing.Point(88, 68);
            this.txtb_dataMedicao.Name = "txtb_dataMedicao";
            this.txtb_dataMedicao.Size = new System.Drawing.Size(100, 23);
            this.txtb_dataMedicao.TabIndex = 5;
            // 
            // txtb_valGlicemia
            // 
            this.txtb_valGlicemia.Location = new System.Drawing.Point(88, 39);
            this.txtb_valGlicemia.Name = "txtb_valGlicemia";
            this.txtb_valGlicemia.Size = new System.Drawing.Size(100, 23);
            this.txtb_valGlicemia.TabIndex = 4;
            // 
            // lbl_idPaciente
            // 
            this.lbl_idPaciente.AutoSize = true;
            this.lbl_idPaciente.Location = new System.Drawing.Point(3, 100);
            this.lbl_idPaciente.Name = "lbl_idPaciente";
            this.lbl_idPaciente.Size = new System.Drawing.Size(65, 15);
            this.lbl_idPaciente.TabIndex = 3;
            this.lbl_idPaciente.Text = "Id Paciente";
            // 
            // lbl_dataMedicao
            // 
            this.lbl_dataMedicao.AutoSize = true;
            this.lbl_dataMedicao.Location = new System.Drawing.Point(3, 71);
            this.lbl_dataMedicao.Name = "lbl_dataMedicao";
            this.lbl_dataMedicao.Size = new System.Drawing.Size(80, 15);
            this.lbl_dataMedicao.TabIndex = 2;
            this.lbl_dataMedicao.Text = "Data Medição";
            // 
            // lbl_valorGlicemia
            // 
            this.lbl_valorGlicemia.AutoSize = true;
            this.lbl_valorGlicemia.Location = new System.Drawing.Point(3, 42);
            this.lbl_valorGlicemia.Name = "lbl_valorGlicemia";
            this.lbl_valorGlicemia.Size = new System.Drawing.Size(82, 15);
            this.lbl_valorGlicemia.TabIndex = 1;
            this.lbl_valorGlicemia.Text = "Valor Glicemia";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(288, 43);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedida,
            this.ValorGlicemico,
            this.DataMedicao,
            this.Paciente,
            this.IdPaciente});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(12, 12);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(581, 169);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            this.listView_medidasGlicemias.SelectedIndexChanged += new System.EventHandler(this.listView_medidasGlicemias_SelectedIndexChanged);
            // 
            // idMedida
            // 
            this.idMedida.Text = "Id Medida";
            this.idMedida.Width = 90;
            // 
            // ValorGlicemico
            // 
            this.ValorGlicemico.Text = "Valor Glicêmico";
            this.ValorGlicemico.Width = 115;
            // 
            // DataMedicao
            // 
            this.DataMedicao.Text = "Data Medição";
            this.DataMedicao.Width = 115;
            // 
            // Paciente
            // 
            this.Paciente.Text = "Paciente";
            this.Paciente.Width = 170;
            // 
            // IdPaciente
            // 
            this.IdPaciente.Text = "Id Paciente";
            this.IdPaciente.Width = 85;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(12, 198);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Enabled = false;
            this.btn_cadastrar.Location = new System.Drawing.Point(93, 198);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(174, 198);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Location = new System.Drawing.Point(255, 198);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Controls.Add(this.panelCadastro);
            this.Name = "Form1";
            this.Text = "Gestão de Glicemia";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCadastro;
        private Label lbl_idPaciente;
        private Label lbl_dataMedicao;
        private Label lbl_valorGlicemia;
        private Button btn_salvar;
        private ListView listView_medidasGlicemias;
        private ColumnHeader idMedida;
        private ColumnHeader ValorGlicemico;
        private ColumnHeader DataMedicao;
        private ColumnHeader Paciente;
        private ColumnHeader IdPaciente;
        private Button btn_conectar;
        private Button btn_cadastrar;
        private Button btn_deletar;
        private Button btn_editar;
        private TextBox txtb_idPaciente;
        private TextBox txtb_dataMedicao;
        private TextBox txtb_valGlicemia;
        private TextBox txtb_idMedida;
        private Label label1;
    }
}