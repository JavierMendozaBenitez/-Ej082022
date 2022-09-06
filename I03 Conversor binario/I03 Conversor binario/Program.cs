using System;
using Biblioteca;

namespace I03_Conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDecimal;
            string numBinario;

            Console.WriteLine("Ingrese un numero a convertir a binario");

            while(!int.TryParse(Console.ReadLine(), out numDecimal))
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine($"El numero ingresado es {numDecimal}.");
            Console.WriteLine($"Su equivalente binario es {Conversor.ConvertirDecimalABinario(numDecimal)}.");


            Console.WriteLine("Ingrese un numero binario a convertir a decimal");

            numBinario = Console.ReadLine();

            Console.WriteLine($"El numero ingresado es {numBinario}.");
            Console.WriteLine($"Su equivalente decimal es {Conversor.ConvertirBinarioADecimal(numBinario)}.");

        }
    }
}
