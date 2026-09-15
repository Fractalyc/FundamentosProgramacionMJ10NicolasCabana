using System;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arreglos Unidimensonales - Vectores
            int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            //numeros[5] = 11;

            Console.WriteLine($"El número almacenado en la posición 4 con índice 3 es: {numeros[3]}");
            //Otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] {'6','7','☻', 't' };
            bool[] valoresVerdad = { true, false, true, false, true, true };
            //Recorrer para llenar de datos el vector
            string[] nombres = new string[7];
            for(int i = 0; i<7; i++)
            {
                Console.WriteLine($"Ingrese el nombre para P{i+1}:I{i}:");
                nombres[i] = Console.ReadLine();
            }
            Console.Clear();
            //Para recuperar datos almacenados
            for(int i = 0;i<nombres.Length; i++)
            {
                Console.Write($"{nombres[i]} |");
            }
            */
            /*
            int[] enteros = new int[100];
            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
                Console.Write($"| {enteros[i]} |");
            }
            Console.Clear();

            int[] numAProm = new int[10];
            int prom = 0;
            int promAcum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número para P{i + 1}:I{i}:");
                numAProm[i] = int.Parse(Console.ReadLine());
                promAcum += numAProm[i];
            }
            Console.Clear();
            for (int i = 0; i < numAProm.Length; i++)
            {
                Console.Write($"| {numAProm[i]} |");
            }
            prom = promAcum / 10;
            Console.WriteLine(" ");
            Console.WriteLine("El promedio es " + prom);
            */
            int[] nums = new int[15];
            int mayor = 0;
            int menor = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el número para P{i + 1}:I{i}:");
                nums[i] = int.Parse(Console.ReadLine());
                mayor = nums[i];
                menor = nums[i];
                if(nums[i] > mayor)
                {
                    mayor = nums[i];
                }
                if (nums[i] < menor)
                {
                    menor = nums[i];
                }
            }
            Console.Clear();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"| {nums[i]} |");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"El mayor fue {mayor}, el menor fue {menor}.");
        }
    }
}
