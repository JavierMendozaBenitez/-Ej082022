using System;

namespace I08_Dibu_tri_rec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ingresado;
            int seguir = 1;

            do
            {

                Console.WriteLine("Ingrese un  numero");
                while (!int.TryParse(Console.ReadLine(), out ingresado))
                {
                    Console.WriteLine("Error");
                }

                for (int i = 1; i <= ingresado; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Seguir. Si 1, no 2");
                while (!int.TryParse(Console.ReadLine(), out seguir) || seguir < 1 || seguir > 2)
                {
                    Console.WriteLine("Error");
                }

            } while (seguir == 1);
        }
    }
}
