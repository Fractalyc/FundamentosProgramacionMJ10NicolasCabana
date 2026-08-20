using System;

namespace Parcial2NJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Midterm #2 by Nicolás José Cabana Restrepo

            //Primer punto
            //Desarrolle un programa en C# que determine el elemento zodiacal de una persona a partir de su mes de nacimiento y su signo zodiacal.

            //Variables a utilizar
            string mes = "";
            string signo = "";

            //Se piden los datos
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Descubra su elemento según su signo zodiacal!");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Por favor escriba su signo zodiacal en minúsculas y con tildes: ");
            signo = Console.ReadLine();
            Console.Write("Por favor escriba su mes de nacimiento en minúsculas: ");
            mes = Console.ReadLine();

            //Se evalúan las respuestas
            if (signo == "aries" || signo == "sagitario" || signo == "leo")
            {
                if (mes == "marzo" || mes == "abril" || mes == "julio" || mes == "agosto" || mes == "noviembre" || mes == "diciembre")
                {
                    Console.WriteLine("Su elemento es el Fuego!");
                }
                else
                {
                    Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal o están mal redactados.");
                }
            }
            else if (signo == "tauro" || signo == "virgo" || signo == "capricornio")
            {
                if (mes == "mayo" || mes == "abril" || mes == "septiembre" || mes == "agosto" || mes == "enero" || mes == "diciembre")
                {
                    Console.WriteLine("Su elemento es la Tierra!");
                }
                else
                {
                    Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal o están mal redactados.");
                }
            }
            else if (signo == "géminis" || signo == "libra" || signo == "acuario")
            {
                if (mes == "mayo" || mes == "junio" || mes == "septiembre" || mes == "octubre" || mes == "enero" || mes == "febrero")
                {
                    Console.WriteLine("Su elemento es el Aire!");
                }
                else
                {
                    Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal o están mal redactados.");
                }
            }
            else if (signo == "cáncer" || signo == "escorpión" || signo == "piscis")
            {
                if (mes == "marzo" || mes == "junio" || mes == "julio" || mes == "octubre" || mes == "noviembre" || mes == "febrero")
                {
                    Console.WriteLine("Su elemento es el Agua!");
                }
                else
                {
                    Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal o están mal redactados.");
                }
            }
            else
            {
                Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal o están mal redactados.");
            }
        }
    }
}
