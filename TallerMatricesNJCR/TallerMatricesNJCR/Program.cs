using System;

namespace TallerMatricesNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Suma de matriz interna
            int[,] matriz1 = new int[10, 20];
            Random nums = new Random();
            int sumaColumnas = 0;
            for(int i = 0; i<matriz1.GetLength(1); i++)
            {
                for (int j = 0; j <matriz1.GetLength(0); j++)
                {
                    matriz1[j,i] = nums.Next(0,101);
                    Console.Write(matriz1[j,i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matriz1.GetLength(1); i++)
            {
                sumaColumnas = 0;
                for (int j = 0; j < matriz1.GetLength(0); j++)
                {
                    sumaColumnas += matriz1[j, i];
                }
                Console.WriteLine($"Suma de la columna {i+1} = {sumaColumnas}");
                Console.WriteLine();
            }
            */
            /*
            //Usuario llena matriz intrcambiar fila 1 con fila n
            Console.WriteLine("Escriba número de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba número de columnas");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matrizNM = new int[filas, columnas];
            int[,] matrizMN = new int[filas, columnas];
            int primeraFila = 0;
            int ultimaFila = matrizMN.GetLength(0) - 1;

            for (int i = 0; i < matrizNM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizNM.GetLength(1); j++)
                {
                    Console.WriteLine($"Escriba número para la celda[{i}, {j}]");
                    matrizNM[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La matriz escrita es:");
            for (int i = 0; i < matrizNM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizNM.GetLength(1); j++)
                {
                    Console.Write(matrizNM[i, j] + " ");
                }
                Console.WriteLine();
            }
            int auxiliar = 0;
            for (int i = 0; i < matrizNM.GetLength(1); i++)
            {
                auxiliar = matrizNM[0, i];
                matrizNM[0, i] = matrizNM[(matrizNM.GetLength(0) - 1), i];
                matrizNM[(matrizNM.GetLength(0) - 1), i]= auxiliar; 
            }
            Console.WriteLine();
            for (int i = 0; i < matrizNM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizNM.GetLength(1); j++)
                {
                    Console.Write(matrizNM[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            /*
            //Contar frecuencia de nums del 1 al 10 en una matriz 5x5
            int[,] matrizFrecuencia = new int[5, 5];
            int[] FrecCounter = new int[11];
            Random matFrec = new Random();
            for (int i = 0; i < matrizFrecuencia.GetLength(1); i++)
            {
                for (int j = 0; j < matrizFrecuencia.GetLength(0); j++)
                {
                    matrizFrecuencia[j, i] = matFrec.Next(1, 11);
                    Console.Write(matrizFrecuencia[j, i] + " ");
                    FrecCounter[matrizFrecuencia[j, i]]++;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Número {i}: se repite {FrecCounter[i]} veces");
            }
            */
            /*
            //Adivinar donde está la x en matriz 5x5
            char[,] guessX = new char[5,5];
            Random assigner = new Random();
            int guessF = 0;
            int guessF1 = 0;
            int guessF2 = 0;
            int guessF3 = 0;
            int guessC = 0;
            int guessC1 = 0;
            int guessC2 = 0;
            int guessC3 = 0;
            int counterCorrect = 0;

            for (int i = 0; i < guessX.GetLength(1); i++)
            {
                for (int j = 0; j < guessX.GetLength(0); j++)
                {
                    guessX[i,j] = '0';
                }
            }
            Console.WriteLine();

            for(int k = 0; k < 3; k++)
            {
                guessX[assigner.Next(1, 5), assigner.Next(1, 5)] = 'X';
            }
            
            Console.WriteLine("Adivine donde están las X");
            for (int l = 0; l < 3; l++)
            {
                Console.WriteLine((l + 1) + "Ingrese número de fila");
                guessF = int.Parse(Console.ReadLine());
                Console.WriteLine((l + 1) + "Ingrese número de columna");
                guessC = int.Parse(Console.ReadLine());
                if (guessX[guessF,guessC] == 'X')
                {
                    counterCorrect++;
                    if(counterCorrect == 1)
                    {
                        guessF1 = guessF;
                        guessC1 = guessC;
                    }
                    if (counterCorrect == 2)
                    {
                        guessF2 = guessF;
                        guessC2 = guessC;
                    }
                    if (counterCorrect == 3)
                    {
                        guessF3 = guessF;
                        guessC3 = guessC;
                    }
                }
            }

            if(counterCorrect == 0)
            {
                Console.WriteLine("No ha acertado ninguna X");
                for (int i = 0; i < guessX.GetLength(1); i++)
                {
                    for (int j = 0; j < guessX.GetLength(0); j++)
                    {
                        Console.Write(guessX[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (counterCorrect == 1)
            {
                Console.WriteLine($"Encontraste la X en [{guessF1},{guessC1}]");
            }
            else if (counterCorrect == 2)
            {
                Console.WriteLine($"Encontraste la X en [{guessF1},{guessC1}] y [{guessF2},{guessC2}]");
            }
            else if (counterCorrect == 3)
            {
                Console.WriteLine($"Encontraste la X en [{guessF1},{guessC1}], [{guessF2},{guessC2}] y [{guessF3},{guessC3}]");
            }
            */


        }
    }
}
