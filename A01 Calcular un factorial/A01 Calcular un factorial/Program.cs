﻿using System;
using Biblioteca;

namespace A01_Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroIng;

            do
            {
                Console.WriteLine("Ingrese un numero entero positivo");

                numeroIng = double.Parse(Console.ReadLine());

            } while (verificar(numeroIng));

            Console.WriteLine($"El factorial de {numeroIng} es {Factorial.CalculadoraDeFactorial(numeroIng)}.");
        }
        public static bool verificar(double n)
        {
            return n <= 0;
        }
    }
}
