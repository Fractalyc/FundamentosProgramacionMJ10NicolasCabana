using System;

namespace _17.MatricesNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor.
            Requerimientos:
            Solicitar al usuario las dimensiones de la matriz (número de filas y columnas).
            Capturar los valores numéricos para llenar la matriz.
            Solicitar el valor límite u objetivo (N).
            Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento < N.
            Mostrar la matriz resultante.
            */
            Console.WriteLine("Ingrese número de filas de la matriz");
            int numFil = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número de columnas de la matriz");
            int numCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numFil, numCol];
            int Umbral = 0;
            Random numsMatrix = new Random();
            Console.WriteLine(" ");
            Console.WriteLine("Desea rellenar la matriz con números aleatorios (entre el 0 y 1000)? Responda SI para acpetar, otra tecla para negar.");
            string Respuesta = Console.ReadLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (Respuesta == "SI")
                    {
                        matrix[i, j] = numsMatrix.Next(0, 1001);
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.WriteLine($"Escriba número para la celda[{i}, {j}]");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Escriba el valor umbral N");
            Umbral = int.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > Umbral)
                    {
                        matrix[i, j] = Umbral;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
