using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace ListaExercicios7Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //string nome, categoria, dataLancamento;
            //Console.WriteLine("Digite o nome do livro: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite a categoria do livro: ");
            //categoria = Console.ReadLine();
            //Console.WriteLine("Digite a data de lançamento do livro: ");
            //dataLancamento = Console.ReadLine();
            //Livro livro = new Livro(nome,categoria,dataLancamento);
            //Console.WriteLine("Nome do livro criado é: "+livro.Nome);
            //Console.WriteLine("Da categoria: " + livro.Categoria);
            //Console.WriteLine("Lançado no dia: " + livro.DataLancamento);

            //Exercicio 2
            //Console.WriteLine("Digite o nome da pessoa: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o sexo da pessoa (M/F): ");
            //string sexo = Console.ReadLine();
            //while(sexo!="M" && sexo != "F")
            //{
            //    Console.WriteLine("Entrada inválida, digite novamente (M/F):");
            //    sexo = Console.ReadLine();
            //}
            //Console.WriteLine("Digite a idade da pessoa: ");
            //int idade = int.Parse(Console.ReadLine());
            //while (idade<=0)
            //{
            //    Console.WriteLine("Entrada inválida, idade deve ser maior que 0, digite novamente:");
            //    idade = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Digite o peso da pessoa: ");
            //float peso = float.Parse(Console.ReadLine());
            //while (peso <= 0)
            //{
            //    Console.WriteLine("Entrada inválida, peso deve ser maior que 0, digite novamente:");
            //    peso = float.Parse(Console.ReadLine());
            //}
            //Pessoa pessoa = new Pessoa(nome, sexo, idade, peso);
            //Console.WriteLine("Nome da pessoa é: " + pessoa.Nome);
            //Console.WriteLine("Do sexo: " + pessoa.GetStringSexo());
            //Console.WriteLine("Com " + pessoa.Idade+ " anos");
            //Console.WriteLine("Pesando " + pessoa.Peso + " kgs");

            // Exercicio 3
            //Cliente cliente1 = new Cliente("Henrique", 23);
            //Carro carro1 = new Carro("LKK1634", "Vinho", "Jeep", 0.00F);
            //Carro carro2 = new Carro("OQF0823", "Laranja", "Jeep", 0.00F);
            //Aluguel aluguel = new Aluguel("04/10/2022", 100, 500F, carro1, cliente1);
            //aluguel.MostrarDadosAluguel();
            //aluguel.Carro = carro2;
            //aluguel.Carro.Kilometragem = 100F;
            //aluguel.MostrarDadosAluguel();

            // Exercicio 4
            //string[] parentesco = {"AvoM","AvoF","Mae","Pai","Voce"};
            //Console.WriteLine("Insira sua árvore genealógica:");
            //Console.WriteLine("Digite os dados do seu avô: ");
            //Pessoa avo1 = CriaPessoa();
            //Pessoa avo2 = CriaPessoa();
            //Pessoa pai = CriaPessoa();
            //Pessoa mae = CriaPessoa();
            //Pessoa eu = CriaPessoa();
            //eu.Mae = mae;
            //eu.Pai = pai;
            //mae.Mae = avo2;
            //mae.Pai = avo1;
            //eu.RetornaArvore();

            //Exercicio 5
            //List<Produto> listaProdutos = new List<Produto>();
            //List<Item> listaItems = new List<Item>();
            ////Criado produtos do mercado
            //Produto prod1 = new Produto("Uva",5.0F,10);
            //Produto prod2 = new Produto("Abacaxi", 5.0F, 10);
            //Produto prod3 = new Produto("Maça", 5.0F, 10);
            ////Criando items
            //Item item1 = new Item(prod1, 5);
            //Item item2 = new Item(prod2, 4);
            //Item item3 = new Item(prod3, 3);
            ////Criando Pedidos
            //Pedido pedido1 = new Pedido(), pedido2 = new Pedido();

            ////Adicionando produtos no mercado
            //listaProdutos.Add(prod1);
            //listaProdutos.Add(prod2);
            //listaProdutos.Add(prod3);
            ////Adicionando items aos pedidos
            //pedido1.Adicionar(item1);
            //pedido1.Adicionar(item2);
            //pedido2.Adicionar(item3);

            //SuperMercado mercado = new SuperMercado(listaProdutos);
            ////Adicionando pedidos ao mercado
            //mercado.AdicionarPedido(pedido1);
            //mercado.AdicionarPedido(pedido2);

            ////Funções retornando todos os items do mercado e verificando se um item existe
            //mercado.RetornaProdutosMercado();
            //mercado.RetornaPedidosMercado();
            ////mercado.VerificaProduto("Uva");

            //Exercicio 6
            //Agenda agenda = new Agenda();
            //agenda.ArmazenaPessoa("Carlos", "M", 40, 80.5F);
            //agenda.ArmazenaPessoa("Antônia", "M", 50, 60.3F);
            //agenda.ArmazenaPessoa("Pedro", "M", 15, 44.8F);
            //agenda.ArmazenaPessoa("Duda", "F", 18, 60.3F);
            //agenda.RemovePessoa("Carlos");
            //agenda.Encontrada(agenda.BuscaPessoa("Carlos"));
            //agenda.RemovePessoa("Antônia");
            //agenda.ImprimeAgenda();

            //Exercicio 7
            //Elevador elevador = new Elevador(2, 3);
            //elevador.Sobe();
            //elevador.Desce();
            //elevador.Sobe();
            //elevador.Entra();
            //elevador.Entra();
            //elevador.Entra();
            //elevador.Sai();
            //elevador.Sai();
            //Console.WriteLine("Este elevador tem "+elevador.TotalAndares+" andares,");
            //Console.WriteLine("com capacidade máxima de  " + elevador.Capacidade + " pessoas.");
            //Console.WriteLine("Quantidade de pessoas atual no elevador é: "+elevador.LotacaoAtual);
            //Console.WriteLine("No andar: " + elevador.AndarAtual);

            //Exercicio 8
            //Televisao tv = new Televisao();
            //ControleRemoto controle = new ControleRemoto(tv);
            //controle.TrocarCanal(30);
            //controle.AumentarCanal();
            //controle.AumentarCanal();
            //controle.AbaixarCanal();
            //controle.AumentarVolume();
            //controle.AumentarVolume();
            //controle.AbaixarVolume();
            //controle.InfoTv();

        }
    }
}