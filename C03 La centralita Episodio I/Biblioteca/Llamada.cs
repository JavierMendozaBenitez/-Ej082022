﻿using System;
using System.Text;

namespace Biblioteca
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada { Local, Provincial, Todas }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion: " + Duracion);
            sb.AppendLine("Nro de destino: " + NroDestino);
            sb.AppendLine("Nro de origen: " + NroOrigen);

            return sb.ToString();
        }

        //-1 llamada1 es mayor a llamada2, 1 llamada2 es mayor a llamada1, 0 si son iguales
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return -1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                return 1;
            }

            return 0;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
    }
}