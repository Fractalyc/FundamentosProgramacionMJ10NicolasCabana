using System;
using System.Xml.Linq;


namespace Taller1ProgramPreparacionNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------PUNTO 1-------------------------------------------------------------------

            //Programa que ordena 3 números

            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("INgrese 3 números diferentes: ");
            Console.WriteLine("Ingrese número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 3");
            num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    if(num2 > num3)
                    {
                        Console.WriteLine("El número mayor es " + num1 + " y en orden serían: " + num1 + ", " + num2 + ", " + num3 + ".");
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es " + num1 + " y en orden serían: " + num1 + ", " + num3 + ", " + num2 + ".");
                    }
                }
                else
                {
                    Console.WriteLine("El número mayor es " + num3 + " y en orden serían: " + num3 + ", " + num1 + ", " + num2 + ".");
                }
            }
            else
            {
                if(num3 > num2)
                {
                    Console.WriteLine("El número mayor es " + num3 + " y en orden serían: " + num3 + ", " + num2 + ", " + num1 + ".");
                }
                else
                {
                    if(num3 > num1)
                    {
                        Console.WriteLine("El número mayor es " + num2 + " y en orden serían: " + num2 + ", " + num3 + ", " + num1 + ".");
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es " + num2 + " y en orden serían: " + num2 + ", " + num1 + ", " + num3 + ".");
                    }
                }
            }*/

            //-------------------------------------------------------------PUNTO 2--------------------------------------------------------------------

            /*int ammo = 0;
            Random rnd = new Random();
            ammo = rnd.Next(1,11) - 1;
            byte invincible = 0;

            Console.WriteLine("---------------------------");
            Console.WriteLine("¿Es su personaje invencible?");
            Console.WriteLine("SI   ->   Marque la tecla 1");
            Console.WriteLine("NO   ->   Marque la tecla 2");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Ingrese su respuesta");
            invincible = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your ammo is: " + ammo);

            if(invincible == 1 && ammo >= 1)
            {
                Console.WriteLine("El personaje está disparando");
            }
            else
            {
                Console.WriteLine("No se pudo disparar.");
            }*/

            //-------------------------------------------------------------PUNTO 3--------------------------------------------------------------------

            int p1x = 0;
            int p1y = 0;
            int p2x = 0;
            int p2y = 0;
            int p3x = 0;
            int p3y = 0;


        }
    }
}
