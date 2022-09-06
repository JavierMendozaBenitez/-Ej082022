using System;
using Biblioteca;

namespace I04_La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seguir = "S";
            string opElegida;
            int op1;
            int op2;
            double resultado;


            do
            {
                Console.WriteLine("Ingrese el primer operando");

                while(!int.TryParse(Console.ReadLine(), out op1))
                {
                    Console.WriteLine("Error");                    
                }

                Console.WriteLine("Ingrese el segundo operando");
                while (!int.TryParse(Console.ReadLine(), out op2))
                {
                    Console.WriteLine("Error");
                }

                Console.WriteLine("Ingrese la operación");
                opElegida = Console.ReadLine();
                while (opElegida != "-" && opElegida != "+" && opElegida != "*" && opElegida != "/")
                {
                    Console.WriteLine("Error");
                    opElegida = Console.ReadLine();
                }

                Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(op1, op2, opElegida));

                Console.WriteLine("Seguir? S/N");
                seguir = Console.ReadLine();

            } while(seguir == "S");
        }
    }
}
