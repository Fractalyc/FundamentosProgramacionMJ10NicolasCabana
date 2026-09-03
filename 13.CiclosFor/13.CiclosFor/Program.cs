using System;

namespace _13.CiclosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo For
            int acumulador = 0;

            //Se puede usar "i" como si fuera la inicialización de una sumatoria, porque eso es lo que realmente es.

            for (int i = 1; i <= 5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine($"La suma de los primeros 5 enteros es {acumulador}");
        }
    }
}
