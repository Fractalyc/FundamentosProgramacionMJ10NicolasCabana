using System;

namespace _19.ProgramModularNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            Operate(ChooseOption());
        }

        static void MainMenu()
        {
            Console.WriteLine("-----------------MENÚ----------------");
            Console.WriteLine("1. Suma             2. Resta");
            Console.WriteLine("3. Producto             4. División");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese una opción del menú según su número:");
        }

        static int ChooseOption()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Operate(int option)
        {
            while (option !=0)
            {
                switch (option)
                {
                        case 1:
                            Console.WriteLine($"La SUMA de los números es: {Sum()} ");
                            break;
                        case 2:
                            Console.WriteLine($"La resta de los números es: {Substraction()} ");
                            break;
                        case 3:
                            Console.WriteLine($"El producto de los números es: {Product()} ");
                            break;
                        case 4:
                            Console.WriteLine($"La división de los números es: {Division()} ");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                }
                Console.ReadKey();
                Console.Clear();
                MainMenu();
                option = ChooseOption();
            }
        }

        static float Sum()
        {
            float sum = 0;
            float num = 0;
            char answer = ' ';

            do
            {
                Console.WriteLine("Ingrese un número");
                num = float.Parse(Console.ReadLine());
                sum += num;
                Console.WriteLine("Presione s para seguir sumando");
                answer = char.Parse(Console.ReadLine());
            }
            while (answer == 's');
            return sum;
        }
        static float Product()
        {
            float mult = 1;
            float num = 0;
            char answer = ' ';

            do
            {
                Console.WriteLine("Ingrese un número");
                num = float.Parse(Console.ReadLine());
                mult *= num;
                Console.WriteLine("Presione m para seguir multiplicando");
                answer = char.Parse(Console.ReadLine());
            }
            while (answer == 'm');
            return mult;
        }
        static float Substraction()
        {
            float result;
            Console.WriteLine("Ingrese el minuendo");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sustraendo");
            float num2 = float.Parse(Console.ReadLine());
            result = num1 - num2;
            return result;
        }
        static float Division()
        {
            float result;
            Console.WriteLine("Ingrese el dividendo");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            float num2 = float.Parse(Console.ReadLine());
            result = num1 / num2;
            return result;
        }
    }
}
