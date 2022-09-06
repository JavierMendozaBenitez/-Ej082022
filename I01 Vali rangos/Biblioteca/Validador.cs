using System;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validado = false;

            if(valor >= min && valor <= max)
            {
                validado = true;
            }

            return validado;
        }
    }
}
