namespace SistemaCadastroJogadores
{
    public partial class Form1 : Form
    {
        const string filePath = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ListasExercicio\SistemaCadastroJogadores\SistemaCadastroJogadores\pessoas.csv";
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
            Util.WriteFileToList(listaPessoas, filePath);
            foreach (var pessoa in listaPessoas)
            {
                txtListaJogadores.Text += pessoa.Nome + " - " + pessoa.Email + Environment.NewLine;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            insertTextBoxList();
        }
        
        private void insertTextBoxList()
        {
            Pessoa p;
            string[] tamNome;
            tamNome = txtNomeJogador.Text.Split(" ");
            if (txtNomeJogador.Text == "")
            {
                MessageBox.Show("Para adicionar nome, é necessário digitar um nome!");
            }
            else if (tamNome.Length < 2)
            {
                MessageBox.Show("Nome deve ser composto");
            }
            else
            {
                if (Util.ExistePessoa(listaPessoas, txtNomeJogador.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já existente", "Atenção");
                }
                else
                {
                    string email = tamNome[tamNome.Length -1] + "." + tamNome[0] + "@gmail.com";
                    p = new Pessoa(txtNomeJogador.Text.ToUpper(), email);
                    listaPessoas.Add(p);
                    Util.WritePeopleToFile(p, filePath);
                    Util.OrdenaListaPessoa(listaPessoas);
                }
                txtListaJogadores.Text = String.Empty;
                foreach (var pessoa in listaPessoas)
                {
                    txtListaJogadores.Text += pessoa.Nome + " - "+ pessoa.Email + Environment.NewLine;
                }
                txtNomeJogador.Text = String.Empty;
            }
            txtNomeJogador.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaPessoas.Clear();
            txtListaJogadores.Text = String.Empty;
            txtNomeJogador.Text = String.Empty;
        }

        private void txtNomeJogador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                insertTextBoxList();
            }
        }
    }
}