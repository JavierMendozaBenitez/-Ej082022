using System;
using Biblioteca;

namespace I07_Pitágoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float baseIng;
            float altura;

            Console.WriteLine("Ingrese base");
            baseIng = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("La hipotenusa es: {0}", Pitagoras.Calculando(baseIng, altura));
        }
    }
}
