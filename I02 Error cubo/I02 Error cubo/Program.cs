/*Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar 
que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
using System;

namespace I02_Error_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double numeroCuadrado;
            double numeroCubo;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            while(numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }

            numeroCuadrado = Math.Pow(numero, 2);
            numeroCubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de {0} es: {1}", numero, numeroCuadrado);
            Console.WriteLine($"El cubo de {numero} es: {numeroCubo}");
        }
    }
}
