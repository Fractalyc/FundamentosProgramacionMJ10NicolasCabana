using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;

namespace _4.ConditionalsSSAndDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //Condicional simple
            //1. Filtro de edad para página web
            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //if True
                Console.WriteLine("Bienvenidos a mi sitio web!");
            }*/



            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos

            /*float sueldo = 0f;
            Console.WriteLine("Nombre Completo: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo: ");
            
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo >= 3000.0f);
            { 
                Console.WriteLine(nombre + " por favor recuerde abonar impuestos.");
            }*/

            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //if True
                Console.WriteLine("Bienvenidos a mi sitio web!");
            }
            else
            {
                //if False
                Console.WriteLine("No es apto para el contenido del sitio web.");
            }*/
            /*float sueldo = 0f;
            Console.WriteLine("Nombre Completo: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo: ");

            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo >= 3000.0f)
            {
                Console.WriteLine(nombre + " por favor recuerde abonar impuestos.");
            }
            else
            {
                Console.WriteLine(nombre + " está exento de impuestos.");
            }*/
            
            Console.WriteLine("Ingrese un número");
            float primerNumero = 0;
            primerNumero = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            float segundoNumero = 0;
            segundoNumero = Convert.ToSingle(Console.ReadLine());

            float suma = primerNumero + segundoNumero;
            float resta = primerNumero - segundoNumero;
            float producto = primerNumero * segundoNumero;
            float division = primerNumero / segundoNumero;

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("La suma de los números es: " + suma  + " y su resta es " + resta);
            }
            else
            {
                Console.WriteLine("El producto de los números es: " + producto + " y su división es " + division);
            }
        }
    }
}
