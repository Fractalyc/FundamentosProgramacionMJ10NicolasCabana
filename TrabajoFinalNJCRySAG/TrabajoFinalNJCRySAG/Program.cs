using System;

namespace TrabajoFinalNJCRySAG
{
    internal class Program
    {
        static string[,] articulos = new string[20, 4];
        static int contadorArticulos = 0;

        static void Main(string[] args)
        {
            Articulos();
        }

        static void Articulos()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione");
            Console.WriteLine("1. Mostrar lista de artículos");
            Console.WriteLine("2. Nuevo Artículo");
            Console.WriteLine("3. Editar Artículo");
            Console.WriteLine("4. Regresar al menú principal");
            Console.WriteLine("-------------------------------");
            int seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    MostrarListaArticulos();
                    break;
                case 2:
                    NuevoArticulo();
                    break;
                case 3:
                    EditarArticulo();
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Seleccione una opción válida.");
                    break;
            }
        }

        static void MostrarListaArticulos()
        {
            Console.WriteLine("Productos disponibles: ");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < articulos.GetLength(0); i++)
            {
                for (int j = 0; j < articulos.GetLength(1); j++)
                {
                    Console.Write($"{articulos[i,j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------------------");
            Articulos();
        }

        static void NuevoArticulo()
        {
            if (contadorArticulos >= articulos.GetLength(0))
            {
                Console.WriteLine("Alcanzó el límite de 20 artículos.");
                Articulos();
                return;
            }

            Console.WriteLine("---Registrar Nuevo Artículo---");

            Console.Write("Ingrese ID: ");
            articulos[contadorArticulos, 0] = Console.ReadLine();

            Console.Write("Ingrese nombre: ");
            articulos[contadorArticulos, 1] = Console.ReadLine();

            Console.Write("Ingrese cantidad en stock: ");
            articulos[contadorArticulos, 2] = Console.ReadLine();

            Console.Write("Ingrese el precio: $");
            articulos[contadorArticulos, 3] = Console.ReadLine();

            contadorArticulos++;
            Console.WriteLine("Artículo guardado");

            MostrarListaArticulos();
        }

        static void EditarArticulo()
        {
            Console.WriteLine("---Editar Artículo---");

            Console.Write("Ingrese el ID del artículo para editar: ");
            string idArticuloEdit = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < articulos.GetLength(0); i++)
            {
                if (articulos[i, 0] == idArticuloEdit)
                {
                    encontrado = true;
                    Console.Write($"Nuevo nombre (Nombre actual: {articulos[i, 1]}): ");
                    articulos[i, 1] = Console.ReadLine();

                    Console.Write($"Ingrese nueva cantidad en stock (Stock actual: {articulos[i, 2]}): ");
                    articulos[i, 2] = Console.ReadLine();

                    Console.Write($"Ingrese el precio actualizado (Precio actual: {articulos[i, 3]}): $");
                    articulos[i, 3] = Console.ReadLine();

                    Console.WriteLine("Artículo modificado.");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Artículo no encontrado.");
            }

            MostrarListaArticulos();
        }

        static void MainMenu()
        {

        }
    }
}
