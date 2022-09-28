namespace PrimeiraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            float num1,num2,media;
            Console.WriteLine("Digite o primeiro número:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = float.Parse(Console.ReadLine());
            media = (num1 + num2) / 2;
            Console.WriteLine("Media é:"+media);
            */
            //Exercício 2
            /*
            float num1,num2,num3,num4,media;
            Console.WriteLine("Digite o primeiro número:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num4 = float.Parse(Console.ReadLine());
            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Media é:"+media);
            */
            //Exercício 3
            /*float num1 = 5.5F, num2 = 2.5F, aux;
            Console.WriteLine("Os valores de entrada são: " + num1 + " e " + num2);
            aux = num1;
            num1 = num2;
            num2 = aux;
            Console.WriteLine("Os valores de saida invertidos são: "+num1+" e "+num2);
            */
            ////Exercício 4
            //int ano, mes, dia;
            //Console.WriteLine("Digite o dia da data:");
            //dia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o mÊs da data:");
            //mes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o ano da data:");
            //ano = int.Parse(Console.ReadLine());
            //string anoMesDia = new DateTime(ano, mes, dia).ToString("yyyy/MM/dd");
            //Console.WriteLine("Data é: "+anoMesDia);
            //anoMesDia = new DateTime(ano, mes, dia).ToString("yy/MM/dd");
            //Console.WriteLine("Data é: " + anoMesDia);

            ////Exercício 5
            //float dist, combustivel, consumo;
            //Console.WriteLine("Digite a distância percorrida: ");
            //dist = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantida de combustível gasto: ");
            //combustivel = float.Parse(Console.ReadLine());
            //consumo = dist/ combustivel;
            //Console.WriteLine("O consumo por litro é: "+ consumo);

            ////Exercício 6
            //int qntPeca;
            //string codigo;
            //float  valUnit, porcentIPI;
            //Console.WriteLine("Digite as informações do parafuso A");
            //Console.WriteLine("Codigo: ");
            //codigo = Console.ReadLine();
            //Console.WriteLine("Quantidade de Peças: ");
            //qntPeca = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor unitário: ");
            //valUnit = float.Parse(Console.ReadLine());
            //Console.WriteLine("Porcentagem IPI: ");
            //porcentIPI = float.Parse(Console.ReadLine());
            //Console.WriteLine("As informações do parafuso A são: ");
            //Console.WriteLine("Codigo: "+codigo+" qnt peças: "+ qntPeca+" Valor unitário: "+ valUnit);

            //Console.WriteLine("Digite as informações do parafuso B");
            //Console.WriteLine("Codigo: ");
            //codigo = Console.ReadLine();
            //Console.WriteLine("Quantidade de Peças: ");
            //qntPeca = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor unitário: ");
            //valUnit = float.Parse(Console.ReadLine());
            //Console.WriteLine("Porcentagem IPI: ");
            //porcentIPI = float.Parse(Console.ReadLine());

            //Console.WriteLine("As informações do parafuso B são: ");
            //Console.WriteLine("Codigo: " + codigo + " qnt peças: " + qntPeca + " Valor unitário: " + valUnit);

            //Exercicio 7
            //int numVend;
            //float salarioFixo, percentualVenda, totalVendas, salario;
            //Console.WriteLine("Digite o número do vendedor:");
            //numVend = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite seu salário fixo: ");
            //salarioFixo = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor total de vendas do vendedor:");
            //totalVendas = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite percentual sobre vendas: ");
            //percentualVenda = float.Parse(Console.ReadLine());

            //salario = salarioFixo+(percentualVenda*totalVendas);
            //Console.WriteLine("O salário total do vendedor de número "+numVend+" é: "+salario);

            //Exercicio 8
            //float celsius, fahrenheit;
            //Console.WriteLine("Digite a temperatura em graus Celsius: ");
            //celsius = float.Parse(Console.ReadLine());
            //fahrenheit = (9 * celsius + 160) / 5;
            //Console.WriteLine("A temperatura em graus Fahrenheit é: "+fahrenheit);

            //Exercicio 9
            //float entrada, p1, mercadoria;
            //Console.WriteLine("Digite o valor da mercadoria: ");
            //mercadoria = float.Parse(Console.ReadLine());
            //if (mercadoria % 3 == 0)
            //{
            //    entrada = mercadoria / 3;
            //    p1 = mercadoria / 3;
            //}
            //else
            //{
            //    entrada =  (mercadoria- (mercadoria % 3))/3+ (mercadoria % 3);
            //    p1 = (mercadoria - entrada) / 2;
            //}
            //Console.WriteLine("O valor da entrada é :"+entrada+" e o valor das parcelas:"+p1);

            //Exercicio 10
            //int saque,n100=0,n50=0, n20=0, n10=0,n5=0, n2=0,n1=0;
            //Console.WriteLine("Digite o valor do saque: ");
            //saque = int.Parse(Console.ReadLine());
            //    n100 = saque / 100;
            //    saque = saque - n100 * 100;
            //    n50 = saque / 50;
            //    saque = saque - n50 * 50;
            //    n20 = saque / 20;
            //    saque = saque - n20 * 20;
            //    n10 = saque / 10;
            //    saque-= n10 * 10;
            //    n5 = saque / 5;
            //    saque -=  n5 * 5;
            //    n2 = saque/2;
            //    saque -= n2 * 2;
            //    n1 = saque;
            //Console.WriteLine("Quantidade de notas de 100 e:"+ n100+" de 50 é: "+n50+" de 20 é:"+n20);
            //Console.WriteLine("Quantidade de notas de 10 e:"+n10+" de 5 é: "+n5+" de 2 é:"+n2+" e de 1 é: "+n1);

            //Exercicio 11
            //float eleitores,branco, nulo, valido;
            //Console.WriteLine("Digite a quantidade de votos branco");
            //branco = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de votos nulo");
            //nulo = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de votos valido");
            //valido = float.Parse(Console.ReadLine());
            //eleitores = branco + nulo + valido;
            //Console.WriteLine("A porcentagem de votos nulos é: "+(nulo/eleitores));
            //Console.WriteLine("A porcentagem de votos branco é: " + (branco / eleitores));
            //Console.WriteLine("A porcentagem de votos valido é: " + (valido / eleitores));

            //Exercicio 12
            //float kmInicio, kmFim, nLitros, totalGanho;
            //Console.WriteLine("Digite a kilometragem no inicio do dia: ");
            //kmInicio = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a kilometragem no fim do dia: ");
            //kmFim = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de litros gasta no dia: ");
            //nLitros = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o total recebido no dia: ");
            //totalGanho = float.Parse(Console.ReadLine());
            //Console.WriteLine("Média do consumo no dia: "+((kmFim-kmInicio)/nLitros));
            //Console.WriteLine("Lucro líquido do dia: "+(totalGanho-nLitros*(6.90)));

            //Exercicio 13 
            //float salMinimo, custoBici, numBici, salFinal;
            //Console.WriteLine("Digite o valor do salário mínimo: ");
            //salMinimo = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do custo unitário das bicicletas: ");
            //custoBici = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de bicicletas vendidas: ");
            //numBici = float.Parse(Console.ReadLine());
            //salFinal = salMinimo*2 + (0.15F*(custoBici*1.5F))* numBici;
            //Console.WriteLine("O salário do funcionário é: "+ salFinal);


            
        }
    }
}