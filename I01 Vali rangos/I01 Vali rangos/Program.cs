/*Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/


using System;
using Biblioteca;

namespace I01_Vali_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;
            float promedio;

            do
            {
                Console.WriteLine("Ingrese un numero");

                while(!int.TryParse(Console.ReadLine(), out numero) || !Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Error");
                }                

                if(numero < minimo)
                {
                    minimo = numero;
                }
                else if(numero > maximo)
                {
                    maximo = numero;
                }

                acumulador += numero;

                contador++;

            } while (contador < 10);

            promedio = (float)acumulador / contador;

            Console.WriteLine("El minimo es: {0}. El maximo es: {1}. El promedio es: {2}", minimo, maximo, promedio);
        }
    }
}
