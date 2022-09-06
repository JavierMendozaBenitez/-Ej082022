/*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: 
 * el valor máximo, el valor mínimo y el promedio..​*/

using System;

namespace I01_Max_min_pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int contador = 0;
            int acumulador = 0;
            int numMin = int.MaxValue;
            int numMax = int.MinValue;
            float prom;

            do
            {
                Console.WriteLine("Ingrese un numero");
                numIngresado = int.Parse(Console.ReadLine());

                if (numIngresado < numMin)
                {
                    numMin = numIngresado;
                }
                else if (numIngresado > numMax)
                {
                    numMax = numIngresado;
                }

                acumulador += numIngresado;
                contador++;

            } while (contador < 5);

            prom = (float)acumulador / contador;

            Console.WriteLine("El numero minimo es: {0}", numMin);
            Console.WriteLine($"El numero maximo es: {numMax}");
            Console.WriteLine($"El promedio es: {prom}");

            Console.ReadKey();
        }
    }
}
