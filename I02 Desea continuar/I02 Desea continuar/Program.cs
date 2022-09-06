/*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

using System;
using Biblioteca;

namespace I02_Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra;
            int numero;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero");

                while(!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error");
                }

                acumulador += numero;

                Console.WriteLine("¿Desea continuar? (S/N)");

                letra = Console.ReadLine();

                Console.WriteLine("Eligio: {0}", letra);

                Console.WriteLine("Suma hasta ahora: {0}", acumulador);


            } while (Validador.ValidarRespuesta(letra, "S"));

            Console.WriteLine("Suma total: {0}", acumulador);
        }
    }
}
