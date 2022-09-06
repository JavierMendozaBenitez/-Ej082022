using System;

namespace I06_Años_bisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desde;
            int hasta;

            Console.WriteLine("Ingrese un numero desde");

            while(!int.TryParse(Console.ReadLine(), out desde) || desde < 1)
            {
                Console.WriteLine("Error reingrese desde");
            }

            Console.WriteLine("Ingrese un numero hasta");

            while (!int.TryParse(Console.ReadLine(), out hasta) || hasta > 3000)
            {
                Console.WriteLine("Error reingrese hasta");
            }

            for(int i = desde; i <= hasta; i++)
            {
                if(i % 400 == 0)
                {
                    Console.WriteLine("{0} Es un año bisiesto", i);
                }
                else if(i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine("{0} Es un año bisiesto", i);
                }
            }
        }
    }
}
