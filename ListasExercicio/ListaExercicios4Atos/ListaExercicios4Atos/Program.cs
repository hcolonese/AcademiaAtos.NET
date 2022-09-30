using System.Runtime.ConstrainedExecution;

namespace ListaExercicios4Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //int[] vet = new int[10];
            //int pares=0, impares=0;
            //for(int i = 0; i < vet.Length; i++)
            //{
            //    Console.WriteLine("Digite o valor "+i+":");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    if(vet[i]%2 == 0)
            //    {
            //        pares++;
            //    }
            //    else
            //        impares++;
            //}
            //Console.WriteLine("A quantidade de pares é: "+pares+" e de impares é: "+impares);

            //Exercicio 2
            //int[] vet1, vet2, vet3;
            //vet1 = new int[20];
            //vet2 = new int[20];
            //vet3 = new int[20];
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor 1:");
            //    vet1[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor " + i + " do vetor 2:");
            //    vet2[i] = int.Parse(Console.ReadLine());
            //    vet3[i] = vet1[i] + vet2[i];
            //}
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("O valor " + i + " do vetor 3 é: " + vet3[i]);
            //}

            //Exercicio 3
            //int[] vet = new int[10];
            //int[] primos = new int[10];
            //int j = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor 1:");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    if (EhPrimo(vet[i]))
            //    {
            //        primos[j]=i;
            //        j++;
            //    }
            //}
            //Console.WriteLine("O indice dos números primos são: ");
            //for(int i = 0; i < j; i++)
            //{
            //    Console.WriteLine(primos[i]+" ");
            //}

            //Exercicio 4
            //int[] vet1, vet2, vet3;
            //vet1 = new int[10];
            //vet2 = new int[10];
            //vet3 = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor 1:");
            //    vet1[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor " + i + " do vetor 2:");
            //    vet2[i] = int.Parse(Console.ReadLine());
            //    vet3[i] = vet1[i] * vet2[i];
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("O valor " + i + " do vetor 3 é: " + vet3[i]);
            //}

            //Exercicio 5
            //int[] vet = new int[10];
            //int menor, posm = 0;
            //Console.WriteLine("Digite o valor " + 0 + " :");
            //vet[0] = int.Parse(Console.ReadLine());
            //menor = vet[0];
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + ":");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    if (vet[i] < menor)
            //    {
            //        menor = vet[i];
            //        posm = i;
            //    }
            //}
            //Console.WriteLine("O menor elemento está no indice " + posm + " e tem valor de " + vet[posm]);

            //Exercicio 6
            //int[] vet1 = new int[10], vet2 = new int[10];
            //for(int i = 0,j=9; i < 10; i++,j--)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    vet1[i] = int.Parse(Console.ReadLine());
            //    vet2[j] = vet1[i];
            //}
            //Console.Write("|");
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write(vet2[i]+ "|");
            //}

            //Exercicio 7
            //int[] vet = new int[10], par = new int[10], impar = new int[10];
            //int j = 0, k = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    if (vet[i]%2==0)
            //    {
            //            par[j] = vet[i];
            //            j++;
            //    }
            //    else
            //    {
            //        impar[k] = vet[k];
            //        k++;
            //    }
            //}
            //Console.Write("|");
            //for(int i = 0; i < j; i++)
            //{
            //    vet[i] = par[i];
            //    Console.Write(vet[i] + "|");
            //}
            //Console.Write("\n|");
            //for (int i = j,l=0; i < 10; i++,l++)
            //{
            //    vet[i] = impar[l];
            //    Console.Write(vet[i] + "|");
            //}

            //Exercicio 8
            //int j = 0;
            //float[] entrada = new float[30], saida = new float[30];
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    entrada[i] = float.Parse(Console.ReadLine());
            //    if(entrada[i] < 0)
            //    {
            //        saida[j] = i;
            //        j++;
            //    }
            //}
            //Console.Write("\n|");
            //for (int i = 0; i < j; i++)
            //{
            //    Console.Write(saida[i] + "|");
            //}

            //Exercicio 9
            //int[] vet = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    vet[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < 10; i++)
            //{
            //    int aux=0;
            //    for(int j=1; j < 10-i; j++)
            //    {
            //        if(vet[j] < vet[j-1])
            //        {
            //            aux = vet[j-1];
            //            vet[j - 1] = vet[j];
            //            vet[j] = aux;
            //        }
            //    }
            //}
            //Console.Write("|");
            //for (int i =0; i < 10; i++)
            //{
            //    Console.Write(vet[i] + "|");
            //}

            //Exercicio 10
            //int[] vet = new int[10], saida;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    vet[i] = int.Parse(Console.ReadLine());
            //}
            //saida =new int[vet.Length];
            //for (int i = 0; i < 10; i++)
            //{
            //    if (vet[i] == 0)
            //    {
            //        saida[i] = 2;
            //    }
            //    else
            //        saida[i] = vet[i];
            //}
            //Console.Write("|");
            //for (int i = 0; i < saida.Length; i++)
            //{
            //    Console.Write(saida[i] + "|");
            //}

            //Exercicio 11
            //int[] vet = new int[5], inverso = new int[5];
            //for (int i = 0,j=(vet.Length-1); i < vet.Length; i++,j--)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    inverso[j] = vet[i];
            //}
            //Console.Write("|");
            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.Write(vet[i] + "|");
            //}
            //Console.WriteLine("\nVetor inverso");
            //Console.Write("|");
            //for (int i = 0; i < inverso.Length; i++)
            //{
            //    Console.Write(inverso[i] + "|");
            //}

            //Exercicio 12
            //int[] v = new int[10];
            //int n;
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    v[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Digite um número N para pesquisa no vetor:");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("|");
            //for (int i = 0; i < v.Length; i++)
            //{
            //    if (v[i] == n)
            //    {
            //    Console.Write(i + "|");
            //    }
            //}

            //Exercicio 13
            //int[] v = new int[10], quantidades2_4_8 = { 0, 0, 0 };
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    v[i] = int.Parse(Console.ReadLine());
            //    if (v[i] == -1)
            //    {
            //        break;
            //    }
            //    if (v[i]==2)
            //    {
            //        quantidades2_4_8[0]++;
            //    }
            //    if (v[i] == 4)
            //    {
            //        quantidades2_4_8[1]++;
            //    }
            //    if (v[i] == 8)
            //    {
            //        quantidades2_4_8[2]++;
            //    }
            //}
            //Console.WriteLine("A quantidade de valores 2, 4 e 8, respectivamente é: ");
            //for(int i = 0; i < quantidades2_4_8.Length; i++)
            //{
            //    Console.Write(quantidades2_4_8[i]+" ");
            //}

            //Exercicio 14
            //Console.WriteLine("Digite o código, 0 para terminar, 1 para impressão normal, " +
            //    "2 para impressão inversa:");
            //int codigo = int.Parse(Console.ReadLine());
            //int tam = 50;
            //int[] v = new int[tam];
            //if(codigo == 0)
            //{
            //    return;
            //}
            //else if(codigo == 1)
            //{
            //    for (int i = 0; i < v.Length; i++)
            //    {
            //        Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //        v[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.Write("|");
            //    for (int i = 0; i < v.Length; i++)
            //    {
            //        Console.Write(v[i] + "|");
            //    }
            //}
            //else if(codigo == 2)
            //{
            //    int[] saida = new int[tam];
            //    for (int i = 0,j=(v.Length-1); i < v.Length; i++,j--)
            //    {
            //        Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //        v[i] = int.Parse(Console.ReadLine());
            //        saida[j] = v[i];
            //    }
            //    Console.Write("|");
            //    for (int i = 0; i < v.Length; i++)
            //    {
            //        Console.Write(saida[i] + "|");
            //    }
            //}

            //Exercicio 15
            //int tam = 10;
            //int[] v = new int[tam], saida = new int[tam];
            //for (int i = 0, j = (v.Length - 1); i < v.Length; i++, j--)
            //{
            //    Console.WriteLine("Digite o valor " + i + " do vetor de entrada:");
            //    v[i] = int.Parse(Console.ReadLine());
            //    saida[j] = v[i];
            //}
            //Console.Write("\n|");
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.Write(v[i] + "|");
            //}
            //Console.Write("\n|");
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.Write(saida[i] + "|");
            //}

            //Exercicio 16
            int tam = 5,k=0,l=0;
            int[] v1 = new int[tam], v2 = new int[tam], uniao, intersecao = new int[tam], diferenca = new int[tam];

            //Lendo valores
            for (int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine("Digite o valor " + i + " do vetor 1 de entrada:");
                v1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o valor " + i + " do vetor 2 de entrada:");
                v2[i] = int.Parse(Console.ReadLine());
            }

            //Ordenando e retirando valores repetidos
            v1 = OrdenaeTiraRepetidoVet(v1, tam);
            v2 = OrdenaeTiraRepetidoVet(v2, tam);
            //Fazendo a união dos vetores
            uniao = new int[v1.Length + v2.Length];
            for (int i = 0; i < v1.Length; i++)
            {
                uniao[i] = v1[i];
            }
            for (int i = v1.Length, j = 0; i < v1.Length+v2.Length; i++, j++)
            {
                uniao[i] = v2[j];
            }
            uniao = OrdenaeTiraRepetidoVet(uniao,uniao.Length);
            //Printando uniao
            Console.WriteLine("Uniao");
            Console.Write("|");
            for (int i = 0; i < uniao.Length; i++)
            {
                Console.Write(uniao[i] + "|");
            }

            //Fazendo diferenca
            for (int i=0; i < v1.Length; i++)
            {
                bool existe = false;
                for(int j=0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    diferenca[k] = v1[i];
                    k++;
                }
            }
            diferenca = OrdenaeTiraRepetidoVet(diferenca, k);
            //Printando diferenca
            Console.WriteLine("\nDiferença");
            Console.Write("|");
            for (int i = 0; i < k; i++)
            {
                Console.Write(diferenca[i] + "|");
            }

            //Fazendo interseccao
            for (int i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        intersecao[l] = v1[i];
                        l++;
                    }
                }
            }
            intersecao = OrdenaeTiraRepetidoVet(intersecao, l);
            //Printando interseccao
            Console.WriteLine("\nIntersecção");
            Console.Write("|");
            for (int i = 0; i < l; i++)
            {
                Console.Write(intersecao[i] + "|");
            }


            //Exercicio aula de vetor
            //Ex 1: Leitura de vetor
            //int i;
            //int[] b = new int[5];
            //Console.WriteLine("Leitura dos valores");
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + ":");
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Valor índice " + i + " é igual a " + b[i]);
            //}
            //
            //Ex 2: Encontre o maior e menor elementos de um vetor e suas posições
            //int[] vet = new int[10];
            //int maior, posM = 0, menor, posm = 0;
            //Console.WriteLine("Digite o valor " + 0 + " :");
            //vet[0] = int.Parse(Console.ReadLine());
            //maior = vet[0];
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o valor " + i + ":");
            //    vet[i] = int.Parse(Console.ReadLine());
            //    if (vet[i] > maior)
            //    {
            //        maior = vet[i];
            //        posM = i;
            //    }
            //}
            //menor = vet[0];
            //for (int i = 1; i < 10; i++)
            //{
            //    if (vet[i] < menor)
            //    {
            //        menor = vet[i];
            //        posm = i;
            //    }
            //}
            //Console.WriteLine("O maior elemento está no indice " + posM + " e tem valor de " + vet[posM]);
            //Console.WriteLine("O menor elemento está no indice " + posm + " e tem valor de " + vet[posm]);
        }
        public static bool EhPrimo(int num)
        {
            int contador = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num == 1)
                {
                    contador++;
                }
                if (num % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                return true;
            }
            else
                return false;
        }
        public static int[] OrdenaVet(int[]v, int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                int aux = 0;
                for (int j = 1; j < tam - i; j++)
                {
                    if (v[j] < v[j - 1])
                    {
                        aux = v[j - 1];
                        v[j - 1] = v[j];
                        v[j] = aux;
                    }
                }
            }
            return v;
        }

        public static int[] OrdenaeTiraRepetidoVet(int[] v, int tam)
        {
            v = OrdenaVet(v, tam);
            int cont = 0;
            for (int i = 1; i < tam; i++)
            {
                if (v[i] == v[i - 1])
                {
                    v[i] = 0;
                    cont++;
                }
            }
            v= OrdenaVet(v, tam);
            int[] saida = new int[tam-cont];
            for(int i = cont,j=0 ; i < tam; i++,j++)
            {
                saida[j]= v[i];
            }
            return saida;
        }

    }
}