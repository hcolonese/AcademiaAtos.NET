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
            Cliente cliente1 = new Cliente("Henrique", 23);
            Carro carro1 = new Carro("LKK1634", "Vinho", "Jeep", 0.00F);
            Carro carro2 = new Carro("OQF0823", "Laranja", "Jeep", 0.00F);
            Aluguel aluguel = new Aluguel("04/10/2022", 100, 500F, carro1, cliente1);
            aluguel.MostrarDadosAluguel();
            aluguel.Carro = carro2;
            aluguel.Carro.Kilometragem = 100F;
            aluguel.MostrarDadosAluguel();

        }
    }
}