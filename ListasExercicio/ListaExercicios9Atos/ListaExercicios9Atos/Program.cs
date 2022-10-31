using System.Reflection.Metadata;

namespace ListaExercicios9Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de concatenação de string
            //string displayName = $"{nameList[n].LastName}, {nameList[n].FirstName}";
            
            //Exercicio 1
            //const string filePath = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ListasExercicio\ListaExercicios9Atos\ListaExercicios9Atos\pessoas.csv";
            //string[] tamNome;
            //string nome, email, op;
            //Pessoa p;
            //List<Pessoa> listaPessoas = new List<Pessoa>();
            ////Recuperando pessoas do arquivo e salvando na lista
            //Util.SalvarArquivoListaPessoa(listaPessoas, filePath);
            //foreach (Pessoa pessoa in listaPessoas)
            //{
            //    Console.WriteLine("Nome: " + pessoa.Nome + " Email: " + pessoa.Email);
            //}
            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para adicionar uma nova pessoa, outra tecla para sair:");
            //    op = Console.ReadLine();
            //    if (op == "1")
            //    {
            //        Console.WriteLine("Digite o nome:");
            //        nome = Console.ReadLine();
            //        tamNome = nome.Split(" ");
            //        while(tamNome.Length < 2)
            //        {
            //            Console.WriteLine("Nome não composto, digite novamente:");
            //            nome = Console.ReadLine();
            //            tamNome = nome.Split(" ");
            //        }
            //        Console.WriteLine("Digite o email:");
            //        nome = nome.ToUpper();
            //        email = Console.ReadLine();
            //        p = new Pessoa(nome, email);
            //        if (!Util.ExistePessoa(listaPessoas, nome))
            //        {
            //            Util.gravarPessoaArquivo(p, filePath);
            //        }
            //        else
            //            Console.WriteLine("Pessoa já existe");
            //    }
            //    else
            //        return;
            //}

            //Exercicio 2
            //const string filePath = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ListasExercicio\ListaExercicios9Atos\ListaExercicios9Atos\emails.csv";
            //string[] nomeDomino;
            //string email, op;
            //Email emai;
            //List<Email> listaEmail = new List<Email>();
            ////Recuperando pessoas do arquivo e salvando na lista
            //Util.SalvarArquivoListaEmail(listaEmail, filePath);
            //foreach (Email e in listaEmail)
            //{
            //    Console.WriteLine("Nome: " + e.Nome + " Dominio: " + e.Dominio);
            //}
            //while (true)
            //{
            //    Console.WriteLine("\nDigite 1 para Cadastrar novo email, 2 para Listar domínios e 3 para Sair:");
            //    op = Console.ReadLine();
            //    if (op == "1")
            //    {
            //        Console.WriteLine("Digite o Email:");
            //        email = Console.ReadLine();
            //        nomeDomino = email.Split("@");
            //        emai = new Email(nomeDomino[0], nomeDomino[1]);
            //        if (!Util.ExisteEmail(listaEmail, emai))
            //        {
            //            Util.gravarEmailArquivo(emai, filePath);
            //        }
            //        else
            //            Console.WriteLine("Email já existe");
            //    }
            //    else if (op == "2")
            //    {
            //        string[] dominios =  new string[listaEmail.Count];
            //        int i = 0;
            //        foreach(Email e in listaEmail)
            //        {
            //            if (!dominios.Contains(e.Dominio))
            //            {
            //                Console.WriteLine(e.Dominio);
            //                dominios[i] = e.Dominio;
            //                i++;
            //            }
            //        }
            //    }
            //    else if(op == "3")
            //    {
            //        return;
            //    }
            //    else
            //        Console.WriteLine("Opção inválida, digite novamente");
            //}

            //Exercicio 3
            string op="";
            const string filePathRepetidas = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ListasExercicio\ListaExercicios9Atos\ListaExercicios9Atos\figurinhasRepetidas.csv";
            const string filePathFaltantes = @"C:\Users\Henrique\OneDrive\Documentos\AcademiaAtos\AcademiaAtos.NET\ListasExercicio\ListaExercicios9Atos\ListaExercicios9Atos\figurinhasFaltantes.csv";
            string codigo, selecao, jogador;
            Figurinha fig;
            List<Figurinha> figurinhasRepetidas = new List<Figurinha>();
            List<Figurinha> figurinhasFaltantes = new List<Figurinha>();
            Util.LerArquivoEscreveLista(figurinhasRepetidas, filePathRepetidas);
            Util.LerArquivoEscreveLista(figurinhasFaltantes, filePathFaltantes);
            while (true)
            {
                Console.WriteLine("1- Cadastrar figurinha repetida");
                Console.WriteLine("2- Cadastrar figurinha faltante");
                Console.WriteLine("3- Listar figurinhas repetidas");
                Console.WriteLine("4- Listar figurinhas faltantes");
                Console.WriteLine("5- Sair");
                op = Console.ReadLine();
                Console.Clear();
                switch (op)
                {
                    case "1":
                        Util.CriaFigurinhaNaLista(filePathRepetidas,figurinhasRepetidas);
                        break;
                    case "2":
                        Util.CriaFigurinhaNaLista(filePathFaltantes,figurinhasFaltantes);
                        break;
                    case "3":
                        Console.WriteLine("\nFigurinhas Repetidas: ");
                        Console.WriteLine("----------");
                        foreach (Figurinha repetida in figurinhasRepetidas)
                        {
                            Console.WriteLine("Código: "+repetida.Codigo + " Seleção: " + repetida.Selecao + " Jogador: " + repetida.NomeJogador);
                            Console.WriteLine("----------");
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nFigurinhas Faltantes: ");
                        Console.WriteLine("----------");
                        foreach (Figurinha faltante in figurinhasFaltantes)
                        {
                            Console.WriteLine("Código: " + faltante.Codigo + " Seleção: " + faltante.Selecao + " Jogador: " + faltante.NomeJogador);
                            Console.WriteLine("----------");
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }


        }



    }
}