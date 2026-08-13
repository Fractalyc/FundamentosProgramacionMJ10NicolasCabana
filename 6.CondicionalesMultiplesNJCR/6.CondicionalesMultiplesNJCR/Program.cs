using System;

namespace _6.CondicionalesMultiplesNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;
            //Condicionales múltiples
            //Cree un algortimo donde se elija una de 5 opciones, error si no se detecta un valor válido
            Console.WriteLine("------------Menú-----------");
            Console.WriteLine("1. Opción 1     2. Opción 2");
            Console.WriteLine("3. Opción 3     4. Opción 4");
            Console.WriteLine("5. Opción 5");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Seleccione el número de UNA opción.");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligió la Opción 1");
                    break;
                case 2:
                    Console.WriteLine("Eligió la Opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligió la Opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligió la Opción 4");
                    break;
                case 5:
                    Console.WriteLine("Eligió la Opción 5");
                    break;
                default:
                    Console.WriteLine("Elija una opción válida");
                    break;
            }
        }
    }
}
