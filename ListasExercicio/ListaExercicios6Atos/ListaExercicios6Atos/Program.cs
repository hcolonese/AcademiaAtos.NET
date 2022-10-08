using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace ListaExercicios6Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //    string nome = "";
            //    string[] palavras;
            //    List<string> nomes = new List<string>();
            //    while (nome != "Sair")
            //    {
            //        Console.WriteLine("Digite um nome completo(mínimo 2 palavras)");
            //        nome = Console.ReadLine();
            //        if (nome.Contains("Sair"))
            //        {
            //            break;
            //        }
            //        palavras = nome.Split(' ');
            //        nome = nome.ToUpper();
            //        if (palavras.Count() > 1 && !nomes.Contains(nome))
            //            {
            //            nomes.Add(nome);
            //            Console.WriteLine("Nome cadastrado com sucesso!");
            //            }
            //        else
            //            Console.WriteLine("Nome com 1 única palavra ou já existente");
            //    }
            //    foreach(var name in nomes)
            //        Console.WriteLine("Nome: "+name);

            //Exercicio 2
            //Console.WriteLine("Digite a quantidade de números que deseja inserir: ");
            //int quant = int.Parse(Console.ReadLine());
            //List<int> numbersRand = new List<int>();
            //Random rand = new Random();
            //for(int i = 0; i < quant; i++)
            //{
            //    numbersRand.Add(rand.Next(1000));
            //}
            //foreach (var number in numbersRand)
            //    Console.WriteLine("Número: "+ number);

            //Exercicio 3
            //List<string> emails = new List<string>();
            //string email;
            //string[] palavras;
            //int op;
            //while (true)
            //{
            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1 - Cadastrar email");
            //    Console.WriteLine("2 - Listar");
            //    Console.WriteLine("3 - Sair");
            //    op = int.Parse(Console.ReadLine());
            //    switch (op)
            //    {
            //        case 1:
            //            Console.WriteLine("Digite seu email: ");
            //            email = Console.ReadLine();
            //            palavras = email.Split('@');
            //            while (palavras.Count() < 2)
            //            {
            //                Console.WriteLine("Deve ser um email válido, digite novamente:");
            //                email = Console.ReadLine();
            //                palavras = email.Split('@');
            //            }
            //            email = email.ToUpper();
            //            if (!emails.Contains(email))
            //            {
            //                emails.Add(email);
            //            }
            //            break;
            //        case 2:
            //            foreach(var e_mail in emails)
            //                Console.WriteLine("Email: "+e_mail);
            //            break;
            //        case 3:
            //            return;
            //        default:
            //            Console.WriteLine("Operação inválida, digite novamente: ");
            //            op = int.Parse(Console.ReadLine());
            //            break;
            //    }

            //Exercicio 4
            //List<string> cryptoMoedas = new List<string>();
            //string cryptoMoeda;
            //string[] palavras;
            //int op;
            //Console.WriteLine("Menu");
            //while (true)
            //{
            //    Console.WriteLine("1 - Cadastrar CriptoMoedas");
            //    Console.WriteLine("2 - Listar CriptoMoedas");
            //    Console.WriteLine("3 - Remover CriptoMoedas");
            //    Console.WriteLine("4 - Sair");
            //    op = int.Parse(Console.ReadLine());
            //    switch (op)
            //    {
            //        case 1:
            //            Console.WriteLine("Digite o nome da CryptoMoeda: ");
            //            cryptoMoeda = Console.ReadLine();
            //            cryptoMoeda = cryptoMoeda.ToUpper();
            //            if (!cryptoMoedas.Contains(cryptoMoeda))
            //            {
            //                cryptoMoedas.Add(cryptoMoeda);
            //                cryptoMoedas.Sort();
            //                Console.WriteLine("Moeda criada com sucesso!");
            //            }
            //            else
            //                Console.WriteLine("Moeda já existente!");
            //            break;
            //        case 2:
            //            foreach (var crypto in cryptoMoedas)
            //                Console.WriteLine("CryptoMoeda: " + crypto);
            //            break;
            //        case 3:
            //            Console.WriteLine("Digite o nome da CryptoMoeda que deseja retirar: ");
            //            cryptoMoeda = Console.ReadLine();
            //            cryptoMoeda = cryptoMoeda.ToUpper();
            //            if (cryptoMoedas.Remove(cryptoMoeda))
            //            {
            //                Console.WriteLine("Remoção da CryptoMoeda "+ cryptoMoeda+" feita com sucesso!");
            //            }
            //            else
            //                Console.WriteLine("CryptoMoeda não encontrada!");
            //            break;
            //        case 4:
            //            return;
            //        default:
            //            Console.WriteLine("Operação inválida, digite novamente: ");
            //            op = int.Parse(Console.ReadLine());
            //            break;
            //    }

            //Exercicio 5
            //Console.WriteLine("Digite a quantidade de números que deseja inserir na lista 1: ");
            //int quant1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de números que deseja inserir na lista 2: ");
            //int quant2 = int.Parse(Console.ReadLine());
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>();
            //Random rand = new Random();
            //for (int i = 0; i < quant1; i++)
            //{
            //    list1.Add(rand.Next(100, 200));
            //}
            //for (int i = 0; i < quant2; i++)
            //{
            //    list2.Add(rand.Next(100, 200));
            //}
            //Console.WriteLine("Números em Comum nas 2 listas: ");
            //foreach (var number1 in list1)
            //    foreach(var number2 in list2)
            //        if(number1 == number2)
            //        {
            //            Console.Write("-"+number1);
            //        }

            //Exercicio 6
            string nome = "", fullSobrenome="";
            string[] palavras;
            int idFamilia;
            List<string> nomes = new List<string>();
            List<string> sobrenomes = new List<string>();
            List<string> familiares = new List<string>();
            while (nome != "Sair")
            {
                Console.WriteLine("Digite um nome completo(mínimo 2 palavras)");
                nome = Console.ReadLine();
                if (nome.Contains("Sair"))
                {
                    break;
                }
                nome = nome.ToUpper();
                palavras = nome.Split(' ');
                if (palavras.Count() > 1)
                {
                    if (!nomes.Contains(nome))
                    {
                        nomes.Add(palavras[0]);
                        fullSobrenome = palavras[1];
                        if (palavras.Count() >= 2)
                        {
                            for (int i=2;i<palavras.Count(); i++)
                            {
                                fullSobrenome += " "+palavras[i];
                            }
                        }
                        if (sobrenomes.Contains(fullSobrenome))
                        {
                            idFamilia = sobrenomes.IndexOf(fullSobrenome);
                            string parente1 = nomes.Last();
                            string parente2 = nomes[idFamilia];
                            familiares.Add("As pessoas " + parente1 + " e " + parente2 + " são da mesma família.\n");
                        }
                        sobrenomes.Add(fullSobrenome);
                        Console.WriteLine("Nome cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Nome já existente");
                    }
                }
                else
                    Console.WriteLine("Nome com 1 única palavra");
            }
            foreach (var surname in sobrenomes)
                Console.WriteLine("Sobrenome: " + surname);
            foreach (var familiar in familiares)
                Console.WriteLine(familiar);

        }


    }
}