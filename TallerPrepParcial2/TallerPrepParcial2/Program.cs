using System;

namespace TallerPrepParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller de preparación para el parcial #2

            //1) Calc promedio
            /*
            double nota = 0;
            double numDatos = 0;
            double promedio = 0;
            string continuar = "";

            Console.WriteLine("Calculador de promedio");
            Console.WriteLine(" ");
            do
            {
                Console.WriteLine("Ingrese la nota: ");
                nota = double.Parse(Console.ReadLine());
                promedio += nota;
                numDatos++;
                Console.WriteLine("Desea ingresar otra nota? Responda SI o NO");
                continuar = Console.ReadLine();
            }
            while (continuar == "SI");
            promedio = promedio / numDatos;
            Console.WriteLine($"Su promedio es: {promedio}");
            */

            //2) Divisores d un número
            /*
            int numSelect = 0;
            int posDivisores = 1;
            int numDivisores = 0;

            Console.WriteLine("Escriba un número: ");
            numSelect = int.Parse(Console.ReadLine());
            while(posDivisores <= numSelect)
            {
                if(numSelect % posDivisores == 0)
                {
                    Console.Write($"{posDivisores}, ");
                    numDivisores++;
                }
                posDivisores++;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"{numSelect} tiene {numDivisores} divisores.");
            */

            //3) Base y exponente
            /*
            int Base = 1;
            int exponent = 1;
            int contExp = 1;
            int result = 1;
            string salir = "";

            Console.WriteLine("Calculadora exponencial.");
            do
            {
                Console.WriteLine("Ingrese la base");
                Base = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el exponente");
                exponent = int.Parse(Console.ReadLine());
                while(contExp <= exponent)
                {
                    result *= Base;
                    contExp++;
                }
                Console.WriteLine("Resultado = " + result);
                contExp = 1;
                result = 1;
                Console.WriteLine("Para salir presione n  |  Otra tecla para continuar.");
                salir = Console.ReadLine();
            }
            while (salir != "n");
            */

            //4) Porcentaje de una encuesta

            int totalResp = 0;
            int contResp = 0;
            int selection = 0;
            int inFavor = 1;
            int Against = 2;
            int noContest = 3;
            int ifPercent = 0;
            int aPercent = 0;
            int ncPercent = 0;

            Console.WriteLine("Ingrese el número de participantes: ");
            totalResp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número según lo votado: A Favor = 1  |  En Contra = 2  |  No Responde = 3");
            do
            {
                Console.WriteLine("Ingrese el voto: ");
                selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    inFavor++;
                }
                else if(selection == 2)
                {
                    Against++;
                }
                else if(selection == 3)
                {
                    noContest++;
                }
                contResp++;
            }
            while (contResp <= totalResp);

            ifPercent = (100 / totalResp) * inFavor;
            aPercent = (100 / totalResp) * Against;
            ncPercent = (100 / totalResp) * ncPercent;
            Console.WriteLine($"El porcentaje de personas a favor es {ifPercent}");
            Console.WriteLine($"El porcentaje de personas en contra es {aPercent}");
            Console.WriteLine($"El porcentaje de personas sin responder es {ncPercent}");
        }
    }
}
