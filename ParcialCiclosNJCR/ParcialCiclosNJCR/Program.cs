using System;

namespace ParcialCiclosNJCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numAlum = 18f;
            int contador = 0;
            int contadorAprobados = 0;
            double acumuladorPromedio = 0f;
            double notaAlum = 0f;
            double promedio = 0f;
            double mayor = 0f;
            double menor = 10f;

            Console.WriteLine("Calculadora de notas. Va a ingresar la nota de 18 estudiantes.");
            while(contador <= numAlum - 1)
            {
                Console.WriteLine("Ingrese la nota del estudiante: ");
                notaAlum = double.Parse(Console.ReadLine());
                if (notaAlum >= 0.0f && notaAlum <=10.0f)
                {
                    if(notaAlum > mayor)
                    {
                        mayor = notaAlum;
                    }
                    if (notaAlum < menor)
                    {
                        menor = notaAlum;
                    }
                    if (notaAlum >= 6.0f)
                    {
                        contadorAprobados++;
                    }
                    contador++;
                    acumuladorPromedio += notaAlum;
                }
                else
                {
                    Console.WriteLine("Dato inválido, ingrese un dato válido.");
                }
            }
            promedio = acumuladorPromedio / numAlum;
            Console.WriteLine($"El promedio del curso fue: {promedio}");
            Console.WriteLine($"La mejor nota es: {mayor}");
            Console.WriteLine($"La menor nota es: {menor}");
            Console.WriteLine($"El número de estudiantes aprobados fue: {contadorAprobados}");
        }
    }
}
