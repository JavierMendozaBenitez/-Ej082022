using System;

namespace I09_Dibu_tri_equilátero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ingresado;
            int resp = 1;

            do
            {
                Console.WriteLine("Ingrese numero");
                while (!int.TryParse(Console.ReadLine(), out ingresado))
                {
                    Console.WriteLine("ERROR. Reingrese.");
                }

                for (int i = 1; i <= ingresado; i++)
                {
                    for (int j = 1; j <= ingresado - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Desea continuar? SI 1 NO 2");
                while (!int.TryParse(Console.ReadLine(), out resp) || resp < 1 || resp > 2)
                {
                    Console.WriteLine("ERROR. Reingrese.");
                }
            } while (resp == 1);

            Console.ReadKey();
        }
    }
}
