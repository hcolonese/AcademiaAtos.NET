namespace ListaExercicios11Atos
{
    public partial class Form_principal : Form
    {
        List<string> listaNomes = new List<string>();
        public Form_principal()
        {
            InitializeComponent();
        }

        private void button_AdicionarLista_Click(object sender, EventArgs e)
        {
            insertTextBoxList();
        }

        private void textBox_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                insertTextBoxList();
            }
        }

        private void insertTextBoxList()
        {
            string[] tamNome;
            tamNome = textBox_nomeCompleto.Text.ToUpper().Split(" ");
            if (textBox_nomeCompleto.Text == "")
            {
                MessageBox.Show("Para adicionar nome, é necessário digitar um nome!");
            }
            else if (tamNome.Length < 2)
            {
                MessageBox.Show("Nome deve ser composto");
            }
            else
            {
                if (listaNomes.Contains(textBox_nomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já existente","Atenção");
                }
                else
                {
                    listaNomes.Add(textBox_nomeCompleto.Text.ToUpper());
                    listaNomes.Sort();
                }
                textBox_listaNome.Text = String.Empty;
                foreach (var name in listaNomes)
                {
                    textBox_listaNome.Text += name + Environment.NewLine;
                }
                textBox_nomeCompleto.Text = String.Empty;
            }
            textBox_nomeCompleto.Focus();
        }
    }
}