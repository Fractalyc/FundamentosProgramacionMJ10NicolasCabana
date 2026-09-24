using System;

namespace _15.Arreglos2DMatricesNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arreglos bidimencionales o matrices
            int[,] numeros = new int[2,3];

            //Se sale del rango, pq no deberíamos indicar el número de fila, indicamos el índice.= numeros[2, 1] = 10;
            numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 8;
            numeros[1, 2] = 10;

            Console.WriteLine($"El valor almacendo en numeros[1,0] es: {numeros[1,0]}");
            char[,] characters = new char[3, 2];
            for(int i=0; i<3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para símbolos: [{i},{j}]:");
                    characters[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar datos
            for (int i = 0; i < characters.GetLength(0); i++)//GetLength(0) devuelve el número de filas.
            {
                for(int j = 0; j < characters.GetLength(1); j++)//GetLength(1) devuelve el número de columnas.
                {
                    Console.Write($"{characters[i,j]}");
                }
                Console.WriteLine();
            }

            //Otra forma de declarar e inicializar matrices

            string[,] nombres =
            {
                {"Ana", "Joao", "Hinako", "Yussef" },
                {"Alessio", "Yernby", "Mafuga", "Hilton" },
                {"Brosvich", "Ignius", "琴", "Ricardo" }
            };
            */
            /*
            //1)Crear una matriz[10,20] en cada posición poner el número 100
            int[,] matriz1020 = new int[10, 20];
            int valor1 = 100;

            for (int i = 0; i < 10; i++)//Recorre las filas
            {
                for (int j = 0; j < 20; j++)//Recorre las columnas
                {
                    matriz1020[i, j] = valor1;
                    Console.WriteLine($"{matriz1020[i,j]}");
                }
            }
            */

            //Suma de dos matrices
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];

            for (int i = 0; i < 2; i++)//Recorre las filas
            {
                for (int j = 0; j < 3; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el valor para la primera matriz en la siguiente posición: [{i},{j}]:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)//Recorre las filas
            {
                for (int j = 0; j < 3; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el valor para la segunda matriz en la siguiente posición: [{i},{j}]:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizSuma.GetLength(0); i++)//GetLength(0) devuelve el número de filas.
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)//GetLength(1) devuelve el número de columnas.
                {
                    matrizSuma[i,j] = matriz1[i,j] + matriz2[i,j];
                    Console.Write($"{matrizSuma[i, j]}");
                }
            }
        }
    }
}
