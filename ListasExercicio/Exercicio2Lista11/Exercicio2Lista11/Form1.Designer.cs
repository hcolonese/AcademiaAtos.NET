namespace Exercicio2Lista11
{
    partial class Exercicio2
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_AddPessoa = new System.Windows.Forms.Button();
            this.btn_ListEmail = new System.Windows.Forms.Button();
            this.btn_ListDominio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 12);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(99, 15);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Location = new System.Drawing.Point(117, 9);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.PlaceholderText = "Digite seu nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(160, 23);
            this.txtBox_Nome.TabIndex = 1;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(117, 49);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(160, 23);
            this.txtBox_Email.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(177, 212);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(177, 212);
            this.textBox2.TabIndex = 7;
            this.textBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(408, 128);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(177, 212);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            // 
            // btn_AddPessoa
            // 
            this.btn_AddPessoa.Location = new System.Drawing.Point(283, 29);
            this.btn_AddPessoa.Name = "btn_AddPessoa";
            this.btn_AddPessoa.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPessoa.TabIndex = 4;
            this.btn_AddPessoa.Text = "Inserir";
            this.btn_AddPessoa.UseVisualStyleBackColor = true;
            this.btn_AddPessoa.Click += new System.EventHandler(this.btn_AddPessoa_Click);
            // 
            // btn_ListEmail
            // 
            this.btn_ListEmail.Location = new System.Drawing.Point(210, 99);
            this.btn_ListEmail.Name = "btn_ListEmail";
            this.btn_ListEmail.Size = new System.Drawing.Size(113, 23);
            this.btn_ListEmail.TabIndex = 6;
            this.btn_ListEmail.Text = "Listar Emails";
            this.btn_ListEmail.UseVisualStyleBackColor = true;
            // 
            // btn_ListDominio
            // 
            this.btn_ListDominio.Location = new System.Drawing.Point(408, 99);
            this.btn_ListDominio.Name = "btn_ListDominio";
            this.btn_ListDominio.Size = new System.Drawing.Size(113, 23);
            this.btn_ListDominio.TabIndex = 8;
            this.btn_ListDominio.Text = "Listar Domínio";
            this.btn_ListDominio.UseVisualStyleBackColor = true;
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ListDominio);
            this.Controls.Add(this.btn_ListEmail);
            this.Controls.Add(this.btn_AddPessoa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.txtBox_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private Label label2;
        private TextBox txtBox_Nome;
        private TextBox txtBox_Email;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_AddPessoa;
        private Button btn_ListEmail;
        private Button btn_ListDominio;
    }
}