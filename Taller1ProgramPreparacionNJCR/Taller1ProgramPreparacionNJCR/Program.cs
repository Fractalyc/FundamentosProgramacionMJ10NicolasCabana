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

            /*int p1x = 0;
            int p1y = 0;
            int p2x = 0;
            int p2y = 0;
            int p3x = 0;
            int p3y = 0;

            //We ask for the points needed for the triangle
            Console.WriteLine("Let's see if we can make a triangle with 3 points on a plane!");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Please input coordinate X of the first point: ");
            p1x = int.Parse(Console.ReadLine());
            Console.Write("Please input coordinate Y of the first point: ");
            p1y = int.Parse(Console.ReadLine());
            Console.Write("Please input coordinate X of the second point: ");
            p2x = int.Parse(Console.ReadLine());
            Console.Write("Please input coordinate Y of the second point: ");
            p2y = int.Parse(Console.ReadLine());
            Console.Write("Please input coordinate X of the third point: ");
            p3x = int.Parse(Console.ReadLine());
            Console.Write("Please input coordinate Y of the third point: ");
            p3y = int.Parse(Console.ReadLine());

            //We calculate the distances between each point, in  other words, the sides of the triangle
            double lado12 = Math.Sqrt(((p2x - p1x) ^ 2) + ((p2y - p1y) ^ 2));
            double lado13 = Math.Sqrt(((p3x - p1x) ^ 2) + ((p3y - p1y) ^ 2));
            double lado23 = Math.Sqrt(((p3x - p2x) ^ 2) + ((p3y - p2y) ^ 2));

            //Se puede hacer un triángulo?
            if ((lado12 + lado13) > lado23 && (lado12 - lado13) < lado23)
            {
                if ((lado12 + lado23) > lado13 && (lado12 - lado23) < lado13)
                {
                    if ((lado13 + lado23) > lado12 && (lado13 - lado23) < lado12)
                    {
                        Console.WriteLine("It IS  possible to  make a triangle with this set of points");
                    }
                    else
                    {
                        Console.WriteLine("Side A does not meet the porperties of a triangle");
                    }
                }
                else
                {
                    Console.WriteLine("At least Side B does not meet the porperties of a triangle");
                }
            }
            else
            {
                Console.WriteLine("At least Side C does not meet the porperties of a triangle");
            }
            */

            //-------------------------------------------------------------PUNTO 4--------------------------------------------------------------------
            //Uso "d" y "a" porque así es el movimiento WASD en los juegos.

            string movimiento = "";
            Console.WriteLine("Move your character");
            Console.WriteLine("Press D to go to the right");
            Console.WriteLine("Press A to go to the left");
            movimiento = Console.ReadLine();

            if (movimiento == "d" || movimiento == "D")
            {
                Console.WriteLine("The character is moving to the right");
            }
            else if (movimiento == "a" || movimiento == "A")
            {
                Console.WriteLine("The character is moving to the left");
            }
            else
            {
                Console.WriteLine("Invalid direction.");
            }
        }
    }
}
