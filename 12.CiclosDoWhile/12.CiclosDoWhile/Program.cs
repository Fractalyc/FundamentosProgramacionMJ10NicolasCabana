using System;


namespace _12.CiclosDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string usuario = "";
            int numeroDeCuenta = 0;
            int saldo = 0;
            int promedioSaldos = 0;
            int iteraciones = 0;
            int sumaDeSaldos = 0;
            string deseaContinuar = "";
            Console.WriteLine("Bienvenido, por favor ingrese los datos requeridos.");
            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta: ");
                numeroDeCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo: ");
                saldo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Hola, {usuario}, número de cuenta: {numeroDeCuenta} tiene un saldo de {saldo}.");
                sumaDeSaldos += saldo;
                if (saldo >= 3000000)
                {
                    Console.WriteLine("Es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine("No es apto para el crédito.");
                }
                iteraciones++;
                Console.WriteLine("Desea revisar otra cuenta? Responda SI para continuar.");
                deseaContinuar = Console.ReadLine();
            }
            while (deseaContinuar == "SI");

            promedioSaldos = sumaDeSaldos / iteraciones;
            Console.WriteLine($"Revisó {iteraciones} cuentas.");
            Console.WriteLine($"El promedio de los saldos entre las cuentas fue: {promedioSaldos}.");*/

            //adivina la contraseña

            const string password = "Manila";
            string passwordAtt = "";
            int passAttNum = 0;
            
            do
            {
                Console.WriteLine("Ingrese la contraseña correcta: ");
                passwordAtt = Console.ReadLine();
                passAttNum++;
                if (passwordAtt != password)
                {
                    Console.WriteLine("Incorrecto, intente de nuevo.");
                }
            }
            while (passwordAtt != password);

            Console.WriteLine("Contraseña correcta");
            Console.WriteLine($"Intentos = {passAttNum}");
        }
    }
}
