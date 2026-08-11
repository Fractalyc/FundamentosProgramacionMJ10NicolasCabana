using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados
            //algoritmo que muestre las relaciones entre diferentes números.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Ingrese 3 valores distintos.");
            Console.WriteLine("Ingrese el valor del primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer número");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("El primer número es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer número es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El segundo número es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer número es el mayor");
                }
            }
        }
    }
}
