using System;
using Biblioteca;

namespace I05_Aprendete_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero");

            while(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Tabla de multiplicar de {0}:", numero);
            Console.WriteLine(Tablas.tabla(numero));

        }
    }
}
