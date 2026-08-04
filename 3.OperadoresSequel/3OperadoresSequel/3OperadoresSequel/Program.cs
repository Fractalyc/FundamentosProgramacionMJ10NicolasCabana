using System;
using System.Diagnostics.SymbolStore;

namespace _3OperadoresSequel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Orden de evaluación de operadores numéricos
            float dato1 = 4f * 3 / 2;
            float dato2 = 4f / 3 * 2;
            float dato3 = 4f * (3 / 3);
            float dato4 = 29f - 8 * 3;
            float dato5 = 4f / (5 * 2 + 1) - 6;
            Console.WriteLine(dato1 + dato2 * dato3 / dato4 * dato5);

            //Operadores lógicos

            // AND / &&
            Console.WriteLine("TABLA CONJUNCIÓN");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("-----------------------------");

            // OR / ||
            Console.WriteLine("TABLA DISYUNCIÓN");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("-----------------------------");

            // NO / !
            bool dato6 = true;
            bool dato7 = !dato6;

            //Operadores de comparación
            bool dato8 = 5 > 4;
            bool dato9 = 100 == 4392;
            bool dato10 = 130 != 87;
            bool dato11 = 5 <= 6;
            bool dato12 = 4 == 5 &&  4 < 8;
            bool dato13 = !dato9 || 0 >= 3 && dato12;
        }
    }
}
