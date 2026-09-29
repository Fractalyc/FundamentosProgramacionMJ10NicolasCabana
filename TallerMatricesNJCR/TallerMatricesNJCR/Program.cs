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

            //Contar frecuencia de nums del 1 al 10 en una matriz 5x5
            int[,] matrizFrecuencia = new int[5, 5];
            int[] FrecCounter = new int[10];
            Random matFrec = new Random();
            for (int i = 0; i < matrizFrecuencia.GetLength(1); i++)
            {
                for (int j = 0; j < matrizFrecuencia.GetLength(0); j++)
                {
                    matrizFrecuencia[j, i] = matFrec.Next(1, 11);
                    Console.Write(matrizFrecuencia[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
