using System;

namespace _11.CiclosDoWhileNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclos DoWhile
            /*
            int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } 
            while (contador <= 5);

            Console.WriteLine($"La suma de los 5 primeros dígito enteros es {acumulador}");*/

            //Pida un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.

            /*int numsol = 1;
            int contador = 1;
            int acumulador = 1;
            bool pregunta = true;
            string respuesta = "";
            do
            {
                Console.WriteLine("Por favor ingrese un número: ");
                numsol = int.Parse(Console.ReadLine());
                Console.Write($"Tabla hasta el 10 de {numsol} es: ");
                contador = 1;
                acumulador = 1;
                do
                {
                    acumulador = numsol * contador;
                    contador++;
                    Console.Write($"{acumulador}, ");
                }
                while (contador <= 10);
                Console.WriteLine(" ");
                Console.WriteLine("Desea seguir? Responda SI si quiere continuar.");
                respuesta = Console.ReadLine();
                if (respuesta == "SI")
                {
                    pregunta = true;
                }
                else
                {
                    pregunta = false;
                }
            }
            while (pregunta == true);*/

            //Algoritmo que calcule números primos hasta el 100.
            int contador = 1;
            int analizador = 1;
            int limitador = 0;
            do
            {
                do
                {
                    if(contador % analizador == 0)
                    {
                        limitador++;
                    }
                    analizador++;
                }
                while (analizador <= contador);
                analizador = 1;

                if(limitador == 2)
                {
                    Console.Write($"{contador}, ");
                }
                //Console.Write($"{contador}, ");
                limitador = 0;
                contador++;
            }
            while (contador <= 100);
        }
    }
}
