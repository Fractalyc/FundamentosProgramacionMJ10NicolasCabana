using System;

namespace TallerPrepModularNJCR
{
    internal class Program
    {
        /*
        static string palabra;
        static char[] charVector;
        static void Main(string[] args)
        {
            CaptureWord();
            ConvertWord();
            Imprimir();
        }

        static string CaptureWord()
        {
            Console.WriteLine("Ingrese una palabra sin espacios ni caracteres especiales");
            palabra = Console.ReadLine();
            return palabra;
        }

        static void ConvertWord()
        {
            charVector = palabra.ToCharArray();
            Console.WriteLine(charVector);
        }
        
        static int CountVowelNumber()
        {
            int countV = 0;
            for(int i = 0; i < charVector.GetLength(0); i++)
            {
                if (charVector[i] == 'a' || charVector[i] == 'i' || charVector[i] == 'u' || charVector[i] == 'e' || charVector[i] == 'o' || charVector[i] == 'A' || charVector[i] == 'I' || charVector[i] == 'U' || charVector[i] == 'E' || charVector[i] == 'O')
                {
                    countV++;
                }
            }
            return (countV);
        }

        static int CountConsonantNumber()
        {
            int countC = 0;
            for (int i = 0; i < charVector.GetLength(0); i++)
            {
                if (charVector[i] != 'a' && charVector[i] != 'i' && charVector[i] != 'u' && charVector[i] != 'e' && charVector[i] != 'o' && charVector[i] != 'A' && charVector[i] != 'I' && charVector[i] != 'U' && charVector[i] != 'E' && charVector[i] != 'O')
                {
                    countC++;
                }
            }
            return (countC);
        }

        static void Imprimir()
        {
            Console.WriteLine($"El número de vocales es {CountVowelNumber()} y el de consonantes es {CountConsonantNumber()}");
        }
        */


        static void Main(string[] args)
        {
            MainMenu();
            OptionSelect();
        }

        static void MainMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Gestor de 5 tareas, elija una de las 3");
            Console.WriteLine("1) Agregar una tarea");
            Console.WriteLine("2) Eliminar una tarea");
            Console.WriteLine("3) Mostrar lista");
            Console.WriteLine("---------------------------");
        }

        static int OptionSelect()
        {
            return int.Parse(Console.ReadLine()); ;
        }

        static void ReadSelection()
        {
            Console.WriteLine("Ha seleccionado la opción" + OptionSelect());
            if(OptionSelect() == 1)
            {
                AddTask();
            }
            else if (OptionSelect() == 2)
            {
                DeleteTask();
            }
            else if (OptionSelect() == 3)
            {
                ShowList();
            }
        }
        static void AddTask()
        {

        }
        static void DeleteTask()
        {

        }
        static void ShowList()
        {

        }
    }
}
