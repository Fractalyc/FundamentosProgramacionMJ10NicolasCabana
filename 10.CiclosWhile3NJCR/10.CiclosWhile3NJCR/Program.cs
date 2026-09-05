using System;

namespace _10.CiclosWhile3NJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100.
            //El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto.
            //Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.
            //Utilizar la función Random para elegir el número aleatorio.

            int numero = 0;
            Random rnd = new Random();
            numero = rnd.Next(1, 101);
            int intento = 0;

            Console.WriteLine("Intente adivinar el número del 1 al 100.");
            //Console.WriteLine(numero);

            while (intento != numero)
            {
                Console.WriteLine("Seleccione un número: ");
                intento = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Correcto! El número es: {intento}");
        }
    }
}
