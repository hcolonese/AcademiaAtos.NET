namespace ListaExercicios11Atos
{
    partial class Form_principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.button_AdicionarLista = new System.Windows.Forms.Button();
            this.textBox_listaNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(114, 6);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(180, 23);
            this.textBox_nomeCompleto.TabIndex = 1;
            this.textBox_nomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeCompleto_KeyPress);
            // 
            // button_AdicionarLista
            // 
            this.button_AdicionarLista.Location = new System.Drawing.Point(300, 6);
            this.button_AdicionarLista.Name = "button_AdicionarLista";
            this.button_AdicionarLista.Size = new System.Drawing.Size(75, 23);
            this.button_AdicionarLista.TabIndex = 2;
            this.button_AdicionarLista.Text = "Inserir";
            this.button_AdicionarLista.UseVisualStyleBackColor = true;
            this.button_AdicionarLista.Click += new System.EventHandler(this.button_AdicionarLista_Click);
            // 
            // textBox_listaNome
            // 
            this.textBox_listaNome.Enabled = false;
            this.textBox_listaNome.Location = new System.Drawing.Point(114, 56);
            this.textBox_listaNome.Multiline = true;
            this.textBox_listaNome.Name = "textBox_listaNome";
            this.textBox_listaNome.ReadOnly = true;
            this.textBox_listaNome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNome.Size = new System.Drawing.Size(180, 312);
            this.textBox_listaNome.TabIndex = 3;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaNome);
            this.Controls.Add(this.button_AdicionarLista);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form_principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeCompleto;
        private Button button_AdicionarLista;
        private TextBox textBox_listaNome;
    }
}