using System.Linq;

namespace Desafio1Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declarando Variáveis
                string filepath = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\DesafioAtos\Desafio1Atos\Desafio1Atos\saida.txt";
                string codigo, nome, telefone, cidade, rg, cpf, linha = "", proxLinha = "";
                string matricula, codCurso, nomeCurso;
                string[] parametrosL1 = {};
                string[] parametrosL2 = {};
                List<Pessoa> listaPessoa = new List<Pessoa>();

                List<Aluno> listaAluno = new List<Aluno>();
                StreamReader reader = new StreamReader(filepath);

                //Comando usados para criar o arquivo de saída
                //StreamWriter writer = new StreamWriter(filepath);
                //writer.Close();

                //Lendo o arquivo
                linha = reader.ReadLine();
                while (linha!=null)
                {
                    parametrosL1 = Util.QuebraLinha(linha);
                    proxLinha = reader.ReadLine();
                    //Se for Linha X, ignora
                    if (parametrosL1[0] == "X") { }
                    
                    if(parametrosL1[0] == "Z")
                    {
                        nome = parametrosL1[1];
                        telefone = parametrosL1[2];
                        cidade = parametrosL1[3];
                        rg = parametrosL1[4];
                        cpf = parametrosL1[5];
                        
                        //Se for última linha do arquivo, só pode ser Pessoa
                        if (proxLinha == null )
                        {
                            //Parte extra para impedir que existam pessoas repetidas, deve ser descomentadas as linhas 47, 57 e 66
                            if (!PessoaRepetida(listaPessoa, nome))
                                listaPessoa.Add(new Pessoa(nome, telefone, cidade, rg, cpf));
                        }
                        else
                        {
                            parametrosL2 = Util.QuebraLinha(proxLinha);
                            //Se próxima linha não for Y, é Pessoa
                            if (parametrosL2[0] != "Y")
                            {
                                //Parte extra para impedir que existam pessoas repetidas, deve ser descomentadas as linhas 47, 57 e 66
                                if (!PessoaRepetida(listaPessoa, nome))
                                listaPessoa.Add(new Pessoa(nome, telefone, cidade, rg, cpf));
                            }
                            else //Não é ultima linha, e proxima é Y, é Aluno
                            {
                                matricula = parametrosL2[1];
                                codCurso = parametrosL2[2];
                                nomeCurso = parametrosL2[3];
                                //Parte extra para impedir que existam alunos repetidos, deve ser descomentadas as linhas 47, 57 e 66
                                if (!AlunoRepetido(listaAluno, nome))
                                listaAluno.Add(new Aluno(nome, telefone, cidade, rg, cpf, matricula, codCurso, nomeCurso));
                            }    
                        }

                    }
                    linha = proxLinha;
                }
                reader.Close();
                Console.WriteLine("----------------");
                Console.WriteLine("Existem "+ listaPessoa.Count +" pessoas e "+ listaAluno.Count + " no arquivo!");
                Console.WriteLine("Os alunos estão cursando os seguintes cursos: ");
                Console.WriteLine("----------------");
                foreach (Aluno a in listaAluno)
                {
                    Console.WriteLine(a.Nome+" cursa: " + a.NomeCurso);
                    Console.WriteLine("----------------");
                }

            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
        }

        public static bool PessoaRepetida(List<Pessoa> lista, string nome)
        {
            Pessoa p = null;
            p = lista.Find(delegate (Pessoa p) { return p.Nome == nome; });
            if(p == null)
            {
                return false;
            }
            return true;
        }
        public static bool AlunoRepetido(List<Aluno> lista, string nome)
        {
            Pessoa p = null;
            p = lista.Find(delegate (Aluno a) { return a.Nome == nome; });
            if (p == null)
            {
                return false;
            }
            return true;
        }
    }
}
