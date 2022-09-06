using System;
using Biblioteca;

namespace I08_El_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresada;

            Console.WriteLine("Ingrese dia, mes y año de nacimiento: (mm/dd/aaaa)");
            fechaIngresada = Console.ReadLine();

            Console.WriteLine("Los numeros de dias vividos son: {0}", Fecha.calculadorDeDias(fechaIngresada));
        }
    }
}
