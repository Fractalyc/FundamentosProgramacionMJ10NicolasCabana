using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ProgramModularNJCR
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char resume;

            do
            {
                //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
                Console.WriteLine("Llenaremos una matriz con múltiplos del 5");
                int rows = Rows();
                int columns = Columns();
                Console.WriteLine($"La matriz será de {rows} x {columns}");
                int[,] matrix5 = new int[rows, columns];
                Fill(matrix5);
                Console.WriteLine("La matriz es: ");
                Show(matrix5);
                Console.WriteLine("Desea llenar otra matriz?");
                Console.WriteLine("N para  salir, S para seguir y borrar pantalla");
                resume = char.Parse(Console.ReadLine());
                if (resume == 'S')
                {
                    Clear();
                }
            } while (resume == 'S');
        }

        static void Show(int[,] matrix5)
        {
            for (int i = 0; i < matrix5.GetLength(0); i++)
            {
                for (int j = 0; j < matrix5.GetLength(1); j++)
                {
                    Console.Write($"{matrix5[i, j]} ");
                    
                }
                Console.WriteLine(" ");
            }
        }

        static void Fill(int[,] matrix5)
        {
            for (int i = 0; i < matrix5.GetLength(0); i++)
            {
                for(int j = 0; j < matrix5.GetLength(1); j++)
                {
                    int elementToEvaluate;

                    do
                    {
                        Console.Write($"Escriba el elemento para [{i},{j}]: ");
                        elementToEvaluate = int.Parse(Console.ReadLine());

                        if (!Multiple(elementToEvaluate))
                        {
                            Console.WriteLine("No es un múltiplo de 5, intente otra vez");
                        }

                    }
                    while (!Multiple(elementToEvaluate));

                    matrix5[i, j] = elementToEvaluate;
                }
            }
        }

        static int Columns()
        {
            Console.WriteLine("Escriba el número de columnas");
            return int.Parse(Console.ReadLine()); ;
        }

        static int Rows()
        {
            Console.WriteLine("Escriba el número de filas");
            return int.Parse(Console.ReadLine()); ;
        }

        static void Clear()
        {
            Console.Clear();
        }

        static bool Multiple(int number)
        {
            return number % 5 == 0;
        }
    }
}
