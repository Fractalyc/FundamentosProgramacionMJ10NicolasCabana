using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _8.CiclosWhile1NJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0;
            int suma = 0;

            Console.WriteLine("Por favor ingrese números enteros");
            Console.Write("El primer número: ");

            while (numeros >= 0)
            {
                numeros = int.Parse(Console.ReadLine());
                suma = suma + numeros;
                if (numeros >= 0)
                {
                    Console.Write("Siguiente número: ");
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("La suma de los números obtenidos es: " + suma);
        }
    }
}
