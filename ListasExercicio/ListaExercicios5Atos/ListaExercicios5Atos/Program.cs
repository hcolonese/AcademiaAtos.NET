using System.Net;

namespace ListaExercicios5Atos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //int[,] matriz = new int[5, 3];
            //for(int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.WriteLine("Digite o elemento "+i+" da primeira coluna:");
            //    matriz[i, 0] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    matriz[i, 1] = matriz[i,0]+10;
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    matriz[i, 2] = matriz[i, 0] *2;
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for(int j=0; j<matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i,j]+"|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 2
            //int[,] matriz = new int[3, 3];
            //int somaLinha, somaColuna=0;
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    somaColuna = 0;
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        somaColuna += matriz[j, i];
            //    }
            //    Console.WriteLine("A soma da Coluna " + i + " é:" + somaColuna);
            //}
            //for (int i = 0; i < matriz.GetLength(1); i++)
            //{
            //    somaLinha = 0;
            //    for (int j = 0; j < matriz.GetLength(0); j++)
            //    {
            //        somaLinha += matriz[i, j];
            //    }
            //    Console.WriteLine("A soma da Linha " + i + " é:" + somaLinha);
            //}

            //Exercicio 3
            //int[,] matriz = new int[4, 4];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(matriz[i,j]+"|");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 4
            //int pares = 0, impares = 0, negativos = 0, positivos = 0, zeros = 0;
            //int[,] matriz = new int[5, 5];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (matriz[i, j] != 0)
            //        {
            //            if(matriz[i, j] %2== 0)
            //            {
            //                pares++;
            //                if (matriz[i, j] > 0)
            //                {
            //                    positivos++;
            //                }
            //                else
            //                    negativos++;
            //            }
            //            else
            //            {
            //                impares++;
            //                if (matriz[i, j] > 0)
            //                {
            //                    positivos++;
            //                }
            //                else
            //                    negativos++;
            //            }
            //        }
            //        else
            //        {
            //            zeros++;
            //            pares++;
            //        }
            //    }
            //}
            //Console.WriteLine("A quantidade de pares é: "+pares);
            //Console.WriteLine("A quantidade de impares é: "+impares);
            //Console.WriteLine("A quantidade de positivos é: " + positivos);
            //Console.WriteLine("A quantidade de negativos é: " + negativos);
            //Console.WriteLine("A quantidade de zeros é: " + zeros);


            //Exercicio 5
            //double[,] matriz1 = new double[2, 3], matriz2 = new double[2, 3];
            //for (int i = 0; i < matriz1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz1.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz 1:");
            //        matriz1[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz2.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz 2:");
            //        matriz2[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz1.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz1.GetLength(1); j++)
            //    {
            //        matriz1[i, j] += matriz2[i, j];
            //        Console.Write(matriz1[i,j] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 6
            //int[,] matriz = new int[4, 4];
            //int randomNumber, maior=-1;
            //Random random = new Random();
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        randomNumber = random.Next(0, 10);
            //        matriz[i, j] = randomNumber;
            //        Console.Write(matriz[i, j] + "|");
            //        if(randomNumber > maior)
            //        {
            //            maior = randomNumber;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("O maior número da matriz é: "+maior);

            //Exercicio 7
            //int[,] matrizA = new int[3, 3], matrizB = new int[3, 3], matrizC = new int[3, 3];
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz A:");
            //        matrizA[i, j] = int.Parse(Console.ReadLine());
            //        matrizC[i, j] = matrizA[i, j];
            //    }
            //}
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz B:");
            //        matrizB[i, j] = int.Parse(Console.ReadLine());
            //        matrizC[i, j] -= matrizB[i, j];
            //    }
            //}
            //for (int i = 0; i < matrizC.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matrizC.GetLength(1); j++)
            //    {
            //        Console.Write(matrizC[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 8
            //int[,] matriz = new int[4, 4];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Impressão na ordem direta");
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Impressão na ordem inversa");
            //for (int i = matriz.GetLength(0)-1; i >= 0; i--)
            //{
            //    Console.Write("|");
            //    for (int j = matriz.GetLength(1)-1; j >= 0; j--)
            //    {
            //        Console.Write(matriz[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 9
            //int[,] matriz = new int[3, 3];
            //bool existe = false;
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Digite um número para buscar na matriz: ");
            //int numero = int.Parse(Console.ReadLine());
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (numero == matriz[i, j])
            //        {
            //            existe = true;
            //        }
            //    }
            //}
            //if (existe)
            //{
            //    Console.WriteLine("O número existe no vetor");
            //}
            //else
            //    Console.WriteLine("Número inexistente");

            //Exercicio 10
            //int[,] matrizA = new int[3, 3], matrizB = new int[3, 3];
            //int media=0, maior = 0, menor = 0;
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz A:");
            //        matrizA[i, j] = int.Parse(Console.ReadLine());
            //        media += matrizA[i, j];
            //    }
            //}
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz B:");
            //        matrizB[i, j] = int.Parse(Console.ReadLine());
            //        media += matrizB[i, j];
            //    }
            //}
            //media /= matrizA.GetLength(0) * matrizA.GetLength(1) + matrizB.GetLength(0) * matrizB.GetLength(1);
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        if (matrizA[i, j] > media)
            //        {
            //            maior++;
            //        }
            //        else
            //            menor++;
            //        if (matrizB[i, j] > media)
            //        {
            //            maior++;
            //        }
            //        else
            //            menor++;
            //    }
            //}
            //Console.WriteLine("A quantidade de elementos maiores que a média é: "+maior);
            //Console.WriteLine("A quantidade de elementos menores que a média é: " + menor);

            //Exercicio 11
            //double[,] matriz = new double[3, 3];
            //for (int i = 1; i <= matriz.GetLength(0); i++)
            //{
            //    for (int j = 1; j <= matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i-1, j-1] = double.Parse(Console.ReadLine());
            //        matriz[i - 1,j - 1] /= i + j;
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 12
            //int[,] matriz = new int[4, 3];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write(matriz[i, j] + "|");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 13
            //int diagPrincipal = 0, diagSecundaria = 0;
            //int[,] matriz = new int[5,5];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //        if (i == j)
            //        {
            //            diagPrincipal += matriz[i, j];
            //        }
            //    }
            //}
            //for (int i = matriz.GetLength(0)-1; i >=0; i--)
            //{
            //    for (int j = matriz.GetLength(1); j >=0; j--)
            //    {
            //        if (i == j)
            //        {
            //            diagSecundaria += matriz[i, j];
            //        }
            //    }
            //}
            //if(diagPrincipal == diagSecundaria)
            //{
            //    Console.WriteLine("Soma das diagonais principais e secundárias são iguais");
            //}
            //else
            //    Console.WriteLine("Soma das diagonais principais e secundárias são diferentes");

            //Exercicio 14
            //bool igual = true;
            //int[,] matriz = new int[5,5];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i=0; i <matriz.GetLength(0); i++)
            //{
            //    for (int j=0,l = matriz.GetLength(1)-1; j <matriz.GetLength(1); j++,l--)
            //    {
            //        if (i==j)
            //        {
            //            if(matriz[i, j] != matriz[i, l])
            //            {
            //                igual = false;
            //                break;
            //            }
            //        }
            //    }
            //}
            //if (igual)
            //{
            //    Console.WriteLine("Os elementos da diagonal principal e segundárias são iguais");
            //}
            //else
            //    Console.WriteLine("Os elementos da diagonal principal e segundárias são diferentes");

            //Exercicio 15
            //int[,] matriz1 = new int[4, 4], matriz2 = new int[4, 4];
            //for (int i = 0; i < matriz1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz1.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz 1:");
            //        matriz1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz2.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz 2:");
            //        matriz2[i, j] = int.Parse(Console.ReadLine());
            //        matriz1[i, j] += matriz2[i, j];
            //    }
            //}
            //for (int i = 0; i < matriz1.GetLength(0); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz1.GetLength(1); j++)
            //    {
            //        Console.Write(matriz1[i, j] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 16
            //int[,] matriz = new int[3, 4];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(1); i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < matriz.GetLength(0); j++)
            //    {
            //        Console.Write(matriz[j, i] + "|");
            //    }
            //    Console.WriteLine();
            //}

            //Exercicio 17
            int maior =0, menor,indI = 0, indJ = 0;
            int[,] matriz = new int[10, 10];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento da linha " + i + " coluna " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (i==0 && j == 0)
                    {
                        maior = matriz[i, j];
                        indI = i;
                        indJ = j;
                    }
                    if(matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        indI = i;
                        indJ = j;
                    }
                }
            }
            menor = maior;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                if(matriz[i, indJ] < menor)
                {
                    menor = matriz[i, indJ];
                    indI = i;
                }
                
            }
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[j, i] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("O elemento MinMax é:"+menor+" e está na posição I:"+indI+" J:"+indJ);


        }
    }
}