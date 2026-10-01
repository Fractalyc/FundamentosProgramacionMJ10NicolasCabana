using System;

namespace _18.ProgramModularNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de fundamentos de programación");
            MostrarMensaje("Nicolás");
            MostrarMensaje("Nicolás José", "Cabana Restrepo");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedimientos sin parámetros

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parámetros

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido {nombre} al curso de fundamentos de programación");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos}, al curso de fundamentos de programación");

        }
    }
}
