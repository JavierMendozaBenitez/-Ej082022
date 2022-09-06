using System;
using System.Text;

namespace Biblioteca
{
    public static class Tablas
    {
        public static string tabla(int num)
        {
            int resultado = 0;

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                sb.AppendLine($"{num} x {i} = {resultado}");
            }

            return sb.ToString();
        }
    }
}
