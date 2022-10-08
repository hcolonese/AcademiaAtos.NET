namespace ListaExercicios7Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Apresentando classes");
            //Lampada l1 = new Lampada();
            //l1.ligar();
            //l1.estaLigada();
            //l1.desligar();
            //l1.estaLigada();

            //TransacaoBancaria t1 = new TransacaoBancaria("3333","PIX","6458-7",10.5F);
            //t1.Depositar(500.50F);
            //Console.WriteLine(t1.ConsultarSaldo());
            //t1.Sacar(200.0F);
            //t1.ExibirDados();

            //Aviao a1 = new Aviao(500F,1000F);
            //a1.Acelerar(40.5F);
            //a1.Reduzir(20.5F);
            //a1.Subir(10000);
            //a1.Descer(5000);

            //Livro l1 = new Livro("nome1","categoria1","06/10/2022");
            //Console.WriteLine(l1.GetNome());
            //Console.WriteLine(l1.GetCategoria());
            //Console.WriteLine(l1.GetDataLancamento());

            //Pessoa p1 = new Pessoa("Henrique", "Masculino", 23, 85.5F);
            //Console.WriteLine(p1.GetNome());
            //Console.WriteLine(p1.GetSexo());
            //Console.WriteLine(p1.GetIdade());
            //Console.WriteLine(p1.GetPeso());

            //Carro c1 = new Carro();
            //c1.Ligar();
            //Console.WriteLine(c1.Modelo);
            //c1.Modelo = "NOVO MODELO";
            //Console.WriteLine(c1.Modelo);
            //if (c1.GetLigado())
            //{
            //    Console.WriteLine("Esta ligado");
            //}
            //else
            //    Console.WriteLine("Está desligado");

            //Temperatura temp = new Temperatura();
            //Console.WriteLine("Digite a temperatura em Fahrenheit");
            //temp.setCelsius(double.Parse(Console.ReadLine()));
            //Console.WriteLine("Atemperatura em Fahrenheit novamente é: " + temp.getFahrenheit());
            //Cliente c1 = new Cliente("Henrique", 23);
            //TransacaoBancaria t1 = new TransacaoBancaria("3333", "PIX", "6458-7", c1, 500.5F);
            //while (true)
            //{
            //Console.WriteLine("Nome do Cliente é: "+t1.Cliente.GetNome());
            //Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para consultar o saldo e 0 para sair:");
            //    {
            //        int op = int.Parse(Console.ReadLine());
            //        switch (op)
            //        {
            //            case 1:
            //                Console.WriteLine("Digite o valor do saque: ");
            //                t1.Sacar(float.Parse(Console.ReadLine()));
            //                break;
            //            case 2:
            //                Console.WriteLine("Digite o valor do depósito: ");
            //                t1.Depositar(float.Parse(Console.ReadLine()));
            //                break;
            //            case 3:
            //                Console.WriteLine("Seu saldo é: "+t1.ConsultarSaldo());
            //                break;
            //            default:
            //                return;

            //        }
            //    }

            //}

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