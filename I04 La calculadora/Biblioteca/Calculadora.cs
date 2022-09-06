using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static double Calcular(int op1, int op2, string opElegida)
        {
            double resultado = 0;

            switch (opElegida)
            {
                case "-":
                    resultado = op1 - op2;
                    break;
                case "+":
                    resultado = op1 + op2;
                    break;
                case "*":
                    resultado = op1 * op2;
                    break;
                case "/":
                    if (Calculadora.Validar(op2))
                    {
                        resultado = op1 / op2;
                    }
                    else
                    {
                        break;
                    }
                    break;
                    default:
                    break;
            }

            return resultado;
        }

        private static bool Validar(int op2)
        {
            bool retorno = false;

            if(op2 != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
