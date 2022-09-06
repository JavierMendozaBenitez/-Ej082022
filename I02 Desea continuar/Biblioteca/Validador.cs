using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool ValidarRespuesta(string respuesta, string letraCorrecta)
        {
            bool retorno = false;

            if(respuesta == letraCorrecta)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
