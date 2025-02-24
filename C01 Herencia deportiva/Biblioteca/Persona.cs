﻿using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Persona(string nombre)
            : this(0, nombre)
        {

        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);

            return sb.ToString();
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}