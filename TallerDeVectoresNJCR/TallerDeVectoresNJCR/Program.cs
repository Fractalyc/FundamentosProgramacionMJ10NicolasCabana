using System;

namespace TallerDeVectoresNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] vector = new int[15];
            int mayor = 0;
            int menor = 0;

            
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el número para P{i + 1}:I{i}:");
                vector[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = vector[0];
                    menor = vector[0];
                }
                
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine($"El mayor número del conjunto es: {mayor}");
            Console.WriteLine($"El menor número del conjunto es: {menor}");
            */
            /*
            Console.WriteLine("Escriba un número de elementos para un vector");
            int numRango = int.Parse(Console.ReadLine());
            int[] vector1 = new int[numRango];
            int[] vector2 = new int[numRango];
            int contador = 0;
            int eIguales = 0;

            while(contador < numRango)
            {
                Console.WriteLine($"Ingrese el número para P{contador + 1}:I{contador}: del vector 1");
                vector1[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el número para P{contador + 1}:I{contador}: del vector 2");
                vector2[contador] = int.Parse(Console.ReadLine());
                if (vector1[contador] == vector2[contador])
                {
                    eIguales++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de datos de mismo valor y posición es: {eIguales}");
            */

            int[] posNeg = new int[20];
            int counter = 0;
            int promedio = 0;
            int reCounter = 0;
            int comparerMay = 0;
            int counterMay = 0;
            int comparerMen = 0;
            int counterMen = 0;

            while(counter < 20)
            {
                Console.WriteLine($"Ingrese el número para P{counter + 1}:I{counter}: del vector 1");
                posNeg[counter] = int.Parse(Console.ReadLine());
                promedio += posNeg[counter];
                counter++;
            }
            promedio = promedio / 20;
            Console.WriteLine($"EL promedio es {promedio}");

            while(reCounter < 20)
            {
                if(reCounter == 0)
                {
                    comparerMay = posNeg[reCounter];
                    comparerMen = posNeg[reCounter];
                }
                if (comparerMay > promedio)
                {
                    counterMay++;
                }
                if (comparerMen < promedio)
                {
                    counterMen++;
                }
                reCounter++;
            }
        }
    }
}
