namespace ListaExercicios2Atos
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {


            //Exercicio 1
            //int b, alt;
            //Console.WriteLine("Digite a base do triangulo: ");
            //b = int.Parse(Console.ReadLine());
            //if(b == 0)
            //{
            //    Console.WriteLine("Valor não pode ser 0, digite novamente: ");
            //    b = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Digite a altura do triangulo: ");
            //alt = int.Parse(Console.ReadLine());
            //if (alt == 0)
            //{
            //    Console.WriteLine("Valor não pode ser 0, digite novamente: ");
            //    alt = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("A area do triangulo é: "+b*alt);

            //Exercicio 2
            //int n;
            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());
            //if(n%2 == 0)
            //{
            //    Console.WriteLine("O número é par");
            //}
            //else
            //    Console.WriteLine("O número é impar");

            //Exercicio 3
            //float n1, n2, n3, n4, media;
            //Console.WriteLine("Digite o primeiro número: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro número: ");
            //n3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o quarto número: ");
            //n4 = int.Parse(Console.ReadLine());
            //media = (n1 + n2 + n3 + n4) / 4;
            //if (n1 > media)
            //{
            //    Console.WriteLine("Número " + n1 + " maior que a média");
            //}
            //if (n2 > media)
            //{
            //    Console.WriteLine("Número " + n2 + " maior que a média");
            //}
            //if (n3 > media)
            //{
            //    Console.WriteLine("Número " + n3 + " maior que a média");
            //}
            //if (n4 > media)
            //{
            //    Console.WriteLine("Número " + n4 + " maior que a média");
            //}

            //Exercicio 4
            //float h1, h2, v1, v2;
            //Console.WriteLine("Digite a quantidade de aulas dadas pelo professor 1: ");
            //h1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor pago por aula para o professor 1: ");
            //v1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de aulas dadas pelo professor 2: ");
            //h2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor pago por aula para o professor 2: ");
            //v2 = float.Parse(Console.ReadLine());
            //if(h1*v1 > h2 * v2)
            //{
            //    Console.WriteLine("Professor 1 tem o maior salário total");
            //}
            //else
            //    Console.WriteLine("Professor 2 tem o maior salário total");

            //Exercicio 5
            //float n1, n2, media;
            //Console.WriteLine("Digite a nota da prova 1: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a nota da prova 2: ");
            //n2 = float.Parse(Console.ReadLine());
            //media = n1 + n2 / 2;
            //if (media >= 7.0F)
            //{
            //    Console.WriteLine("Digite a nota do Exame: ");
            //    float nExame = float.Parse(Console.ReadLine());
            //    if ((nExame + media) / 2 <= 5.0F)
            //    {
            //        Console.WriteLine("Reprovado!!");
            //    }
            //    else
            //        Console.WriteLine("Aprovado!!");
            //}
            //else
            //    Console.WriteLine("Aprovado!!");

            //Exercicio
            //string nome;
            //float altura, peso, imc;
            //Console.WriteLine("Digite o nome do paciente: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite a altura do paciente em metros: ");
            //altura = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o peso do paciente em Kg: ");
            //peso = float.Parse(Console.ReadLine());
            //nome = nome.ToUpper();
            //imc = peso / (altura * altura);
            //Console.WriteLine("nome: "+nome);
            //Console.WriteLine("\nIMC: ");
            //if (imc < 18)
            //{
            //    Console.WriteLine("Peso Baixo");
            //}
            //else if (imc < 25)
            //{
            //    Console.WriteLine("Peso Normal");
            //}
            //else if (imc < 30)
            //{
            //    Console.WriteLine("Sobrepeso");
            //}
            //else if (imc < 35)
            //{
            //    Console.WriteLine("Obesidade");
            //}
            //else if (imc >= 35)
            //{
            //    Console.WriteLine("Obesidade grau sério");
            //}

            //Exercicio 7
            //string frase, palavra;
            //Console.WriteLine("Digite uma frase: ");
            //frase = Console.ReadLine();
            //Console.WriteLine("Digite uma palavra: ");
            //palavra = Console.ReadLine();
            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("Frase contém palavra");
            //}
            //else
            //    Console.WriteLine("Frase não contém palavra");

            //Exercicio 8
            //Console.WriteLine("Digite o nome do funcionario");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o código do funcionario");
            //string codigo = Console.ReadLine();
            //Console.WriteLine("Digite o salario do funcionario");
            //float salario = float.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o total vendido pelo funcionario");
            //float totalVendas = float.Parse(Console.ReadLine());
            //if(totalVendas >= 5000.0F)
            //{
            //    salario *= 1.10F;
            //}
            //else if (totalVendas >= 1000.0F)
            //{
            //    salario *= 1.07F;
            //}
            //else if (totalVendas >= 500.0F)
            //{
            //    salario *= 1.05F;
            //}
            //Console.WriteLine("Salário final é: "+salario);

            //Exercicio 9
            //float[] glicemia =  new float[3];
            //Console.WriteLine("Digite o primeiro valor para glicemia: ");
            //glicemia[0] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor para glicemia: ");
            //glicemia[1] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor para glicemia: ");
            //glicemia[2] = float.Parse(Console.ReadLine());
            //float media=0;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (glicemia[i]<=65)
            //    {
            //        Console.WriteLine("Corre risco de hipoglicemia no dia "+i);
            //    }
            //    if (glicemia[i] >= 250)
            //    {
            //        Console.WriteLine("Corre risco de hiperglicemia no dia " + i);
            //    }
            //    media += glicemia[i];
            //}
            //if (media / 3 <= 80)
            //{
            //    Console.WriteLine("É preciso diminuir 2 unidades de insulina");
            //}
            //if (media / 3 >150)
            //{
            //    Console.WriteLine("É preciso adicionar 2 unidades de insulina");
            //}

            //Exercicio 10
            //Console.WriteLine("Digite nome, idade e altura, respectivamente, do primeiro atleta");
            //string nome1 = Console.ReadLine();
            //int idade1 = int.Parse(Console.ReadLine());
            //float altura1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite nome, idade e altura, respectivamente, do segundo atleta");
            //string nome2 = Console.ReadLine();
            //int idade2 = int.Parse(Console.ReadLine());
            //float altura2 = float.Parse(Console.ReadLine());
            //if(idade1 < idade2 && altura1 > altura2)
            //{
            //    Console.WriteLine("O atleta mais alto e mais novo é :"+nome1+" com "+idade1+" anos e "+altura1+" de altura");
            //}
            //else
            //    Console.WriteLine("O atleta mais alto e mais novo é :" + nome2 + " com " + idade2 + " anos e " + altura2 + " de altura");

            //Exercicio 11
            //Console.WriteLine("Digite um horario, primeiro as horas e depois os minutos: ");
            //int hora = int.Parse(Console.ReadLine());
            //int minutos = int.Parse(Console.ReadLine());
            //if(hora > 0 && hora < 23 && minutos > 0 && minutos < 59)
            //{
            //    Console.WriteLine("Hora válida");
            //}
            //else
            //{
            //    if(hora<0 || hora> 23)
            //    {
            //        Console.WriteLine("Horas digitadas em formado errado, deve ser entre 0-23, digite novamente: ");
            //        hora = int.Parse(Console.ReadLine());
            //    }
            //    if (minutos < 0 || minutos > 59)
            //    {
            //        Console.WriteLine("Minutos digitados em formado errado, deve ser entre 0-59, digite novamente: ");
            //        minutos = int.Parse(Console.ReadLine());
            //    }
            //    if (hora > 0 && hora < 23 && minutos > 0 && minutos < 59)
            //    {
            //        Console.WriteLine("Hora válida");
            //    }
            //}

            //Exercicio 12
            //Console.WriteLine("digite o código do funcionário: ");
            //string codigo = Console.ReadLine();
            //Console.WriteLine("digite o número de horas trabalhadas pelo funcionário: ");
            //float numHoras = float.Parse(Console.ReadLine());
            //float salario = 0;
            //if(numHoras > 50)
            //{   
            //    float extras = numHoras - 50;
            //    extras = 20 * extras;
            //    Console.WriteLine("Salário extra " + extras));
            //    Console.WriteLine("Salário total "+(extras+500.0F));
            //}
            //else
            //{
            //    Console.WriteLine("Salário total " + numHoras*10.0F);
            //}

            //Exercicio 13
            //Console.WriteLine("Digite a altura da pessoa em metros: ");
            //float altura = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o sexo da pessoa, F para feminino, M para masculino");
            //string sexo = Console.ReadLine();
            //if (sexo == "M")
            //{
            //    float peso = (72.7F * altura) - 58;
            //    Console.WriteLine("Peso ideal para este homem é: "+ peso);
            //}
            //if (sexo == "F")
            //{
            //    float peso = (62.1F * altura) - 44.7F;
            //    Console.WriteLine("Peso ideal para este homem é: " + peso);
            //}

            //Exercicio 14
            //Console.WriteLine("Digite o tamanho do arquivo em MB: ");
            //float tam = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a velocidade de download em Mbps: ");
            //float vel = float.Parse(Console.ReadLine());
            //float tempo = (tam / vel)/60;
            //Console.WriteLine("Tempo de download esimado em minutos é: "+ tempo);

            //Exercicio 15
            //Console.WriteLine("Digite o tamanho, em metros quadrados a ser pintado: ");
            //float area = float.Parse(Console.ReadLine());
            //float litros = area / 3;
            //int latas = (int)Math.Ceiling((litros / 18));    
            //Console.WriteLine("Devem ser compradas "+latas+" latas de tinta e custarão "+latas*80+" reais.");

            //Exercicio 16
            //Console.WriteLine("Digite o placar do primeiro jogo, na forma timeDeCasa X timeDeFora: ");
            //String placar = Console.ReadLine();
            //String separador = " X ";
            //int count = separador.Length;
            //String [] valoresPlacar = placar.Split(separador, count);
            //int v1 = int.Parse(valoresPlacar[0]);
            //int v2 = int.Parse(valoresPlacar[1]);
            //if (v2 >= v1 + 2)
            //{
            //    Console.WriteLine("O time de fora já se classificou");
            //}
            //else
            //{
            //    Console.WriteLine("Os dois times se enfrentarão em um novo jogo");
            //    Console.WriteLine("Digite o placar do segundo jogo: ");
            //    placar = Console.ReadLine();
            //    valoresPlacar = placar.Split(separador, count);
            //    v1 = int.Parse(valoresPlacar[0]);
            //    v2 = int.Parse(valoresPlacar[1]);
            //    if (v1 > v2)
            //    {
            //        Console.WriteLine("Time da casa se classificou");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Time de fora se classificou");
            //    }
            //}

            //Exercicio 17 
            //int a, b, c;
            //Console.WriteLine("Digite os 3 lados do triangulo, a, b, c:");
            //Console.WriteLine("Digite a:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite b:");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite c:");
            //c = int.Parse(Console.ReadLine());
            //if((a<(b+c))&& (b < (a + c)) && (c < (a + b)))
            //{
            //    Console.WriteLine("É triangulo: ");
            //    if (a == b && a == c)
            //    {
            //        Console.WriteLine("Equilatero");
            //    }
            //    else if (a == b || a == c || b==c)
            //    {
            //        Console.WriteLine("Isoceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Escaleno");
            //    }
            //}

            //Exercicio 18
            //Console.WriteLine("Digite o primeiro valor: ");
            //float [] valores = new float [3];
            //valores[0] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //valores[1] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //valores[2] = float.Parse(Console.ReadLine());
            //float maior = valores.Max();
            //int maxIndex = valores.ToList().IndexOf(maior);
            //if (valores[0] == maior)
            //{
            //    Console.WriteLine("O primeiro valor é o maior");
            //}
            //else if (valores[1] == maior)
            //{
            //    Console.WriteLine("O segundo valor é o maior");
            //}
            //else
            //    Console.WriteLine("O terceiro valor é o maior");

            //Exercicio 19
            //Console.WriteLine("Digite o primeiro valor: ");
            //float[] valores = new float[3];
            //valores[0] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //valores[1] = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //valores[2] = float.Parse(Console.ReadLine());
            //for(int i=0; i<3; i++)
            //{
            //    float maior = valores.Max();
            //    int maxIndex = valores.ToList().IndexOf(maior);
            //    Console.WriteLine(valores[maxIndex]+"\n");
            //    valores[maxIndex] = 0;
            //}

            //Exercicio 20
            //Random rnd = new Random();
            //int numero = rnd.Next(10);
            //Console.WriteLine("Digite seu primeiro palpite, você terá 3 chances para acertar: ");
            //Console.WriteLine("Dica, o número está entra 0 e 10");
            //int palpite = int.Parse(Console.ReadLine());
            //for(int i = 0; i < 3; i++)
            //{
            //    if(palpite == numero)
            //    {
            //        break;
            //    }
            //    if(palpite > numero)
            //    {
            //        Console.WriteLine("Seu palpite é maior que o número digitado, tente novamente: ");
            //        palpite = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Seu palpite é menor que o número digitado, tente novamente: ");
            //        palpite = int.Parse(Console.ReadLine());
            //    }
            //}
            //if(palpite == numero)
            //{
            //    Console.WriteLine("Parabéns, você acertou!!");
            //}
            //else
            //    Console.WriteLine("Suas chances acabaram, o número era "+numero);

        }
    }
}