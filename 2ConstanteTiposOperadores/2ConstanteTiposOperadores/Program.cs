using System;

namespace _2ConstanteTiposOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva = "19%";
            string nombres = "Mauricio";
            nombres = "Nicolás";
            //iva = "30%"; no se puede ya que las constantes no pueden cambiar su valor.

            //Tipos de datos.
            byte dato1 = 3;
            int dato2 = -4;
            ulong dato3 = 5000000000;
            float dato4 = 5.4f; //la f del final es 100% necesaria.
            double dato5 = 54321.54321d; //la d del final no es necesaria.
            char dato6 = 'ð';
            string dato7 = "hklkfjdӁ2dfgh";
            bool dato8 = false;
            object dato9 = null;
            object dato10 = new object();

            //Operadores Numéricos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = - dato11;
            int dato13 = + dato12;
            Console.WriteLine("dato11: {0}, dato12: {1}, dato13: {2}", dato11, dato12, dato13);
            //Aritméticos
            int dato14 = 6 - 5;
            int dato15 = 7 + dato14;
            int dato16 = 8 * dato15;
            int dato17 = dato16 / 16;
            Console.WriteLine("resta: {0}, suma: {1}, multiplicación: {2}, división: {3}", dato14, dato15, dato16, dato17);
            //Incremento y Disminución
            int dato18 = 1;
            dato18++; //dato18 = dato18 + 1;
            dato18++; //dato18 =dato18 - 1;
            dato18 += 3;
            dato18 /= 2;
        }
    }
}
