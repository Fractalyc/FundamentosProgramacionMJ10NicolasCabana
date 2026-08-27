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
            /*int numInput = 0;
            int numInputLim = 0;
            int cantNumInput = 0;
            int contPos = 0;
            int contNeg = 0;
            int contNil = 0;

            Console.WriteLine("Ingresará una cantidad de números a su elección.");
            Console.WriteLine("Cuantos números quiere que el programa reconozca?");
            Console.Write("Escriba su respuesta: ");
            cantNumInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora escriba los números de su elección.");

            while (numInputLim < cantNumInput)
            {
                Console.Write("Escriba un número: ");
                numInput = int.Parse(Console.ReadLine());
                if (numInput > 0)
                {
                    contPos++;
                }
                else if (numInput < 0)
                {
                    contNeg++;
                }
                else if (numInput == 0)
                {
                    contNil++;
                }
                numInputLim++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("La cantidad de números positivos es: " + contPos);
            Console.WriteLine("La cantidad de números negativos es: " + contNeg);
            Console.WriteLine("La cantidad de números nulos es: " + contNil);*/

            /*int numEven = 0;
            int endRang = 0;

            Console.Write("Escriba un número: ");
            endRang = int.Parse(Console.ReadLine());
            numEven = endRang / 2;
            Console.WriteLine($"La cantidad de números pares entre 1 y {endRang} es {numEven}");*/

            int contNum = 1;
            int endRang = 0;
            int contEven = 0;
            Console.Write("Escriba un número: ");
            endRang = int.Parse(Console.ReadLine());
            while (contNum <= endRang)
            {
                if (contNum % 2 == 0)
                {
                    contEven++;
                    Console.Write($"{contNum}, ");
                }
                contNum++;
                
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Cantidad de números pares en {endRang} es: {contEven}");
        }
    }
}