using System.Linq;

namespace Exercicio2Lista11
{
    public partial class Exercicio2 : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btn_AddPessoa_Click(object sender, EventArgs e)
        {
            insertPessoa();
        }

        private void insertPessoa()
        {
            string[] tamNome;
            tamNome = txtBox_Nome.Text.ToUpper().Split(" ");
            if (txtBox_Nome.Text == "")
            {
                MessageBox.Show("Para adicionar nome, é necessário digitar um nome!");
            }
            else if (tamNome.Length < 2)
            {
                MessageBox.Show("Nome deve ser composto");
            }
            else
            {
                //Fazer com Find em função a parte
                //if (listaPessoas.Contains(txtBox_Nome.Text.ToUpper()))
                //{
                //    MessageBox.Show("Nome já existente", "Atenção");
                //}
                else
                {
                    listaPessoas.Add(new Pessoa(txtBox_Nome.Text.ToUpper(), txtBox_Email.Text.ToUpper()));
                    listaPessoas.Sort();
                }
                txtBox_Nome.Text = String.Empty;
                foreach (var name in listaPessoas)
                {
                    txtBox_Nome.Text += name + Environment.NewLine;
                }
                txtBox_Nome.Text = String.Empty;
            }
            txtBox_Nome.Focus();
        }
    }
}