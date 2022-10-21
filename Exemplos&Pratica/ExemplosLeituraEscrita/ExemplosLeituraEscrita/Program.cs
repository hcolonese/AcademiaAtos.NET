namespace ExemplosLeituraEscrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de try e catch
            //try
            //{
            //    int x;
            //    Console.WriteLine("Digite o valor para x:");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("O valor de x é: "+ x);
            //    Console.WriteLine("O valor 50, dividido por " + x + "resulta em "+ (50/x));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Não é possível dividir por zero");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Apenas números devem ser digitados!");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Número informado inválido: Muito grande!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally//optativo
            //{
            //    //ele executa apos o try, ou apos o catch
            //}


            //Exemplo de leitura e escrita de arquivos
            try
            {
                List<string> linhas = new List<string>();
                if (File.Exists(@"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ExemploDeStreamWrite.txt"))
                {
                    StreamReader reader = new StreamReader(@"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ExemploDeStreamWrite.txt");
                    string linha = "";
                    linha = reader.ReadLine();

                    Console.WriteLine("----------------");
                    while (linha != null)
                    {
                        Console.WriteLine(linha);
                        linhas.Add(linha);
                        linha = reader.ReadLine();
                    }
                    Console.WriteLine("----------------");
                    reader.Close();
                }

                //StreamWriter writer = new StreamWriter("C:\\Users\\Henrique\\OneDrive\\Documentos\\AcademiaAtos\\AcademiaAtos.NET");
                StreamWriter writer = new StreamWriter(@"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ExemploDeStreamWrite.txt");
                foreach (string lin in linhas)
                {
                    writer.WriteLine(lin);
                }
                List<Pessoa> listaPessoas = new List<Pessoa>();
                string nome = "", sexo = "", email = "", fone = "", estado = "";
                int casa = 0, quant = 0, idade = 0;
                float aluguel = 0;
                Console.WriteLine("Digite a quantidade de pessoas que deseja inserir:");
                quant = int.Parse(Console.ReadLine());
                for (int i = 0; i < quant; i++)
                {
                    nome = ""; sexo = ""; email = ""; fone = ""; estado = "";
                    casa = 0; idade = 0;
                    Console.WriteLine("Informe o nome");
                    nome = Console.ReadLine();
                    while (nome == "")
                    {
                        Console.WriteLine("Nome obrigatório, digite novamente:");
                        nome = Console.ReadLine();
                    }
                    Console.WriteLine("Informe a idade");
                    idade = int.Parse(Console.ReadLine());
                    while (idade == 0)
                    {
                        Console.WriteLine("Idade obrigatória, digite novamente:");
                        idade = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Informe o sexo");
                    sexo = Console.ReadLine();
                    Console.WriteLine("Informe o email");
                    email = Console.ReadLine();
                    Console.WriteLine("Informe o fone");
                    fone = Console.ReadLine();
                    Console.WriteLine("Informe o estado civil");
                    estado = Console.ReadLine();
                    Console.WriteLine("Possui casa propria? (1 = SIM, 2 = NÃO)");
                    casa = int.Parse(Console.ReadLine());
                    while (casa != 1 && casa != 2)
                    {
                        Console.WriteLine("Pergunta obrigatória, digite novamente, \nPossui casa propria? (1 = SIM, 2 = NÃO)");
                        idade = int.Parse(Console.ReadLine());
                    }
                    if (casa == 2)
                    {
                        Console.WriteLine("Informe o aluguel");
                        aluguel = float.Parse(Console.ReadLine());
                    }
                    Pessoa p = new Pessoa();
                    p.Nome = nome;
                    p.Idade = idade;
                    p.Sexo = sexo;
                    p.Email = email;
                    p.Telefone = fone;
                    p.EstadoCivil = estado;
                    p.Casa = casa;
                    listaPessoas.Add(p);
                }
                foreach (Pessoa pessoa in listaPessoas)
                {
                    string escreve;
                    escreve = pessoa.RetornaDados();
                    writer.WriteLine(escreve);

                }

                writer.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}