using System;

namespace ListaExercicios8Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //List<Personagem> listaPersonagem = new List<Personagem>();
            //listaPersonagem.Add(new Personagem("Pantera Negra", 95));
            //listaPersonagem.Add(new Personagem("Hulk",100));
            //Personagem thor = new Personagem();
            //thor.Nome = "Thor";
            //thor.Poder = 90;
            //listaPersonagem.Add(thor);
            //listaPersonagem.Sort(delegate (Personagem p1, Personagem p2)
            //{
            //    return p2.Poder.CompareTo(p1.Poder);
            //});
            //Console.WriteLine(listaPersonagem[0].Nome + " com poder igual a "+ listaPersonagem[0].Poder);

            //Exercicio 2
            //string tipo;
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Digite seu animal de estimação (Gato/Cachorro/Peixe) :");
            //    tipo = Console.ReadLine();
            //    while(tipo != "Gato" && tipo != "Cachorro" && tipo != "Peixe")
            //    {
            //        Console.WriteLine("Espécie inválida, digite novamente (Gato/Cachorro/Peixe): ");
            //        tipo = Console.ReadLine();
            //    }
            //    if (tipo == "Gato")
            //    {
            //        string nome, cor;
            //        Console.WriteLine("Digite o nome do seu Gato: ");
            //        nome = Console.ReadLine();
            //        Console.WriteLine("Digite a cor do seu Gato: ");
            //        cor = Console.ReadLine();
            //        Gato animal = new Gato(nome, cor);
            //        Console.WriteLine("O nome do seu Gato é "+animal.Nome+ " e a cor é "+animal.Cor);
            //    }
            //    else if (tipo == "Cachorro")
            //    {
            //        string nome, raca;
            //        Console.WriteLine("Digite o nome do seu Cachorro: ");
            //        nome = Console.ReadLine();
            //        Console.WriteLine("Digite a raça do seu Cachorro: ");
            //        raca = Console.ReadLine();
            //        Cachorro animal = new Cachorro(nome, raca);
            //        Console.WriteLine("O nome do seu Cachorro é " + animal.Nome + " e a raça é " + animal.Raca);
            //    }
            //    else if (tipo == "Peixe")
            //    {
            //        string nome;
            //        int nadadeiras;
            //        Console.WriteLine("Digite o nome do seu Peixe: ");
            //        nome = Console.ReadLine();
            //        Console.WriteLine("Digite a quantidade de nadadeiras do seu Peixe: ");
            //        nadadeiras = int.Parse(Console.ReadLine());
            //        Peixe animal = new Peixe(nome, nadadeiras);
            //        Console.WriteLine("O nome do seu Peixe é " + animal.Nome + " e a quantidade de nadadeiras é " + animal.Nadadeiras);
            //    }
            //}

            //Exercicio 3
            //List<Asteroide> listaAsteroides = new List<Asteroide>();
            //Asteroide asteroide1 = new Asteroide();
            //asteroide1.X = 1;
            //asteroide1.Y = 1;
            //listaAsteroides.Add(asteroide1);
            //listaAsteroides.Add(new Asteroide(2,2,5,5,5));
            //listaAsteroides.Add(new Asteroide(3, 3));
            //foreach(var asteroide in listaAsteroides)
            //{
            //    Console.WriteLine("Posição X: "+asteroide.X +" - Posição Y: "+asteroide.Y);
            //}

            //Exercicio 4
            //ItemCenario item = new ItemCenario("Janela branca", new DateTime(2008, 6, 1),1.5F);
            //item.ImprimirDados();
            //item.TempoCriacao();

            //Exercicio 5
            //List<Ponto> listaPontos = new List<Ponto>();
            //float x, y;
            //Console.WriteLine("Digite quantos pontos deseja adicionar: ");
            //int quant = int.Parse(Console.ReadLine());
            //for(int i = 0; i < quant; i++)
            //{
            //    Console.WriteLine("Digite a cordenada x do ponto "+ i + ":");
            //    x = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite a cordenada y do ponto " + i + ":");
            //    y = float.Parse(Console.ReadLine());
            //    listaPontos.Add(new Ponto(x,y));
            //}
            //Console.WriteLine("Lista de pontos:");
            //foreach(Ponto ponto in listaPontos)
            //{
            //    ponto.ExibirCoordenadas();
            //}

            //Exercicio 6
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            Funcionario f = new Gerente(), funcionarioBusca = new Gerente();
            string nome, depto, rg, nomeBusca="";
            int op;
            double salario, aumento;
            DateTime dataCriacao = DateTime.Today;
            string data = dataCriacao.ToShortDateString();

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar, 2 aumentar salário, 3 para demitir" +
                    " 4 para mostrar os dados e 5 para sair.");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual cargo do funcionário? 1 = Gerente, 2 = Operador");
                        int cargo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do funcionário");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o departamento do funcionário");
                        depto = Console.ReadLine();
                        Console.WriteLine("Digite o RG do funcionário");
                        rg = Console.ReadLine();
                        Console.WriteLine("Digite o salário do funcionário");
                        salario = float.Parse(Console.ReadLine());
                        if (cargo == 1)
                        {
                            f = new Gerente(nome, depto, data, rg, salario, true);
                        }
                        else if (cargo == 2)
                        {
                            f = new Operador(nome, depto, data, rg, salario, true);
                        }
                        listaFuncionario.Add(f);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do funcionário que deseja aumentar o salário:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if(funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        Console.WriteLine("Em quanto deseja aumentar o salário? ");
                        aumento = int.Parse(Console.ReadLine());
                        funcionarioBusca.Bonifica(aumento);
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do funcionário que deseja demitir:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if (funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        funcionarioBusca.Demite();
                        break;
                    case 4:
                        Console.WriteLine("------------");
                        foreach(Funcionario funcio in listaFuncionario)
                        {
                            funcio.MostraDados();
                            funcio.ExecutaTrabalho();
                            Console.WriteLine("------------");
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente:");
                        break;
                }
            }


            //Exercicio 7
            //DicionarioLivro dicLivro = new DicionarioLivro();
            //dicLivro.Adicionar("book1", 100);
            //dicLivro.Adicionar("book2", 200);
            //dicLivro.Adicionar("book3", 300);
            //dicLivro.Adicionar("book4", 400);
            //dicLivro.ConsultaTodosLivros();
            //dicLivro.PesquisaLivro("book1");
            //dicLivro.RemoverLivro("book1");
            //dicLivro.RemoverLivro("book5");



        }
    }
}