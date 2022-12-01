using PrimeiroWFADONET;
using WinFormsADONet;

namespace PrimeiroWSADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravaDepto_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(txtb_nomeDPTO.Text, txtb_locDPTO.Text, txtb_orcamentoDPTO.Text);
            if (d.gravarDepartamento())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");


        }
        private void btn_GravaEmp_Click(object sender, EventArgs e)
        {
            Empregado empregado = new Empregado(txtb_nomeEMP.Text, txtb_idGerenteEMP.Text, txtb_funcaoEMP.Text, txtb_idDeptoEMP.Text, txtb_dataAdmissaoEMP.Text, txtb_salarioEMP.Text, txtb_comissaoEMP.Text);
            if(empregado.gravarEmpregado())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Empregado!", "Erro!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();
            b.abrirConexao();
        }

    }
}