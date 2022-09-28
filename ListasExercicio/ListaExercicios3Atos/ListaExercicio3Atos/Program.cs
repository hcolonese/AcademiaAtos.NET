using System.Security.Cryptography.X509Certificates;

namespace ListaExercicios3Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios Loop For
            ////somatorio entre 55 e 127
            //int contagem = 0;
            //for(int i = 56; i < 127; i++)
            //{
            //    contagem += i;
            //}

            //contagem dos pares entre 55 e 127
            //int contagem =0;
            //for(int i = 56; i < 127; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //    contagem++;
            //    }
            //}
            //Console.WriteLine("Pares são: " + contagem);

            //Soma dos pares e contagem dos impares entre 55 e 127
            //int contagem = 0, soma = 0;
            //for(int i = 56; i < 127; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        soma += i;
            //    }
            //    else
            //        contagem++;
            //}
            //Console.WriteLine(soma);
            //Console.WriteLine(contagem);

            //soma dos pares e contagem dos impares entre intervalo passado por usuario
            //int valInf, valSup;
            //Console.WriteLine("Digite primeiro valor do intervalo");
            //int v1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite segundo valor do intervalo");
            //int v2 = int.Parse(Console.ReadLine());
            //if (v1 > v2)
            //{
            //    valInf = v2;
            //    valSup = v1;
            //}
            //else
            //    valInf = v1;
            //    valSup = v2;
            //int contagem = 0, soma = 0;
            //for (int i = valInf+1; i < valSup; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        soma += i;
            //    }
            //    else
            //        contagem++;
            //}
            //Console.WriteLine("A soma é: "+soma);
            //Console.WriteLine("A contagem é: "+contagem);

            //Exercicio While
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////Exercicio DoWhile
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 5);

            //Contar valores pares digitados até receber um negativo
            // da pra fazer com while tbm, e se o primeiro já for negativo, usa um if<0 com break;
            //int numero = 0, cont = 0;
            //do
            //{
            //    Console.WriteLine("Digite um número: ");
            //    numero = int.Parse(Console.ReadLine());
            //    if(numero % 2 == 0 && numero>=0)
            //    {
            //        cont++;
            //    }
            //} while (numero >= 0);
            //Console.WriteLine("A quantidade de números pares é: "+cont);

            //Exercicio 1 e 2

            //int numero;
            //string again = "";
            //string print = "";
            //do
            //{
            //    Console.WriteLine("Digite um número: ");
            //    numero = int.Parse(Console.ReadLine());
            //    while(numero < 0)
            //    {
            //        Console.WriteLine("Valor incorreto!Digite novamente: ");
            //        numero = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Número digitado: "+numero);
            //    Console.WriteLine("Números inteiros entre 1 e " + numero+":");
            //    for(int i =1; i < numero; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            print += i;
            //            if (i + 2 < numero)
            //            {
            //                print += ", ";
            //            }
            //            else
            //                print += ".";
            //        }
            //    }
            //    Console.WriteLine(print);
            //    print = "";
            //    Console.WriteLine("Deseja informar outro número (S/N)?");
            //    again = Console.ReadLine();
            //} while (again != "N");

            //Exercicio 3
            //int numero = 1;
            //while (numero != 0)
            //{
            //    Console.WriteLine("Informe um número");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero == 0)
            //    {
            //        break;
            //    }
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("É par");
            //    }
            //    else
            //    {
            //        Console.WriteLine("É impar");
            //    }
            //    if (EhPrimo(numero) == true)
            //    {
            //        Console.WriteLine("É primo");
            //    }
            //}

            //Exercicio 4 E 5
            //string entrada = "";
            //int vJoao=0, vZeca=0, vBranco=0, vNulo=0;
            //do
            //{
            //    Console.WriteLine("Digite seu voto");
            //    entrada = Console.ReadLine();
            //    if (entrada == "JOAO")
            //    {
            //        vJoao++;
            //    }
            //    else if (entrada == "ZECA")
            //    {
            //        vZeca++;
            //    }
            //    else if (entrada == "BRANCO")
            //    {
            //        vBranco++;
            //    }
            //    else if(entrada == "FIM")
            //    {
            //        break;
            //    }
            //    else
            //        vNulo++;
            //} while (entrada != "FIM");
            //Console.WriteLine("A quantidade de votos brancos é "+vBranco);
            //Console.WriteLine("A quantidade de votos do joão é " + vJoao);
            //Console.WriteLine("A quantidade de votos do zeca é " + vZeca);
            //Console.WriteLine("A quantidade de votos nulos " + vNulo);
            //if(vZeca == vJoao)
            //{
            //    Console.WriteLine("Empate");
            //}
            //else if (vZeca > vJoao)
            //{
            //    Console.WriteLine("Zeca venceu");
            //}
            //else
            //    Console.WriteLine("Joao venceu");

            //Exercicio 6
            //int idade = 0;
            //Console.WriteLine("Digite a sua idade");
            //while (idade<=0)
            //{
            //    idade = int.Parse(Console.ReadLine());
            //    if (idade > 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Digite uma idade válida, deve ser maior que 0");
            //    }
            //}
            //Console.WriteLine("A idade digitada foi: "+idade);

            //Exercicio 7
            //Console.WriteLine("Digite seu nome: ");
            //string nome = Console.ReadLine();
            //bool containsInt = nome.Any(char.IsDigit);
            //if (containsInt == true)
            //{
            //    System.Console.WriteLine("Formato incorreto, não pode conter números");
            //    return;
            //}
            //Console.WriteLine("Dite a sua idade: ");
            //int idade = int.Parse(Console.ReadLine());
            //if (idade <= 0)
            //{
            //    System.Console.WriteLine("Formato incorreto, não pode ser menor ou igual a zero");
            //    return;
            //}
            //Console.WriteLine("Digite seu salário");
            //float salario = float.Parse(Console.ReadLine());
            //if (salario <= 0)
            //{
            //    System.Console.WriteLine("Formato incorreto, não pode ser menor ou igual a zero");
            //    return;
            //}
            //Console.WriteLine("Nome lido: "+nome);
            //Console.WriteLine("Idade lido: " + idade);
            //Console.WriteLine("Salário lido: " + salario);

            //Exercicio 8
            //string again = "N";
            //do
            //{
            //    Console.WriteLine("Digite um número inteiro");
            //    float numero =  float.Parse(Console.ReadLine());
            //    int inteiro = (int)numero;
            //    while(numero - inteiro != 0)
            //    {
            //        Console.WriteLine("Número não inteiro, digite novamente: ");
            //        numero = float.Parse(Console.ReadLine());
            //        inteiro = (int)numero;
            //    }
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("É par");
            //    }
            //    else
            //        Console.WriteLine("é impar");
            //    Console.WriteLine("Deseja inserir outro número (S/N): ");
            //    again = Console.ReadLine();
            //} while (again != "N" || again != "n");

            //Exercicio 9
            //int f0 = 0, f1a3 = 0, f4a7 = 0, f8mais = 0, quant;
            //for(int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("Digite a quantidade de filhos da pessoa "+i+".");
            //    quant = int.Parse(Console.ReadLine());
            //    if (quant >= 8)
            //    {
            //        f8mais++;
            //    }
            //    else if (quant >= 4)
            //    {
            //        f4a7++;
            //    }
            //    else if (quant >= 1)
            //    {
            //        f1a3++;
            //    }
            //    else
            //        f0++;
            //}
            //Console.WriteLine("Pessoas que tem entre 1 e 3 filhos "+f1a3);
            //Console.WriteLine("Pessoas que tem entre 4 e 7 filhos "+f4a7);
            //Console.WriteLine("Pessoas que tem mais de 8 filhos "+f8mais);
            //Console.WriteLine("Pessoas que não tem filhos "+f0);

            //Exercicio 10
            //int contMasc=0, contFem=0, menos30=0, mais60=0, idade, loop =3;
            //float media=0;
            //string nome = "", sexo = "";

            //for (int i = 0; i < loop; i++)
            //{
            //    Console.WriteLine("Digite nome da pessoa " + i + ".");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Digite o sexo da pessoa " + i + "(M/F).");
            //    sexo = Console.ReadLine();
            //    Console.WriteLine("Digite a idade da pessoa " + i + ".");
            //    idade = int.Parse(Console.ReadLine());
            //    if (sexo == "M")
            //    {
            //        contMasc++;
            //        if (idade < 30)
            //        {
            //            menos30++;
            //        }
            //        if (idade > 60)
            //        {
            //            mais60++;
            //        }
            //    }
            //    else
            //    {
            //        contFem++;
            //        if (idade < 30)
            //        {
            //            menos30++;
            //        }
            //        if (idade > 60)
            //        {
            //            mais60++;
            //        }
            //            media += idade;
            //    }
            //}
            //Console.WriteLine("Número de pessoas do sexo masculino: " + contMasc);
            //Console.WriteLine("Número de pessoas do sexo feminino: " + contFem);
            //Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + menos30);
            //Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + mais60);
            //Console.WriteLine("Média da idade das mulheres: " + media/ contFem);




        }
            public static bool EhPrimo(int num)
            {
            int contador=0;
                for(int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                }
                if(contador == 2)
                {
                    return true;
                }
                else
                    return false;
            } 
    }
}
