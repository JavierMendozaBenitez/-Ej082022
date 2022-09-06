using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titulr, decimal cantidad)
        {
            this.titular = titulr;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetTitular());
            sb.AppendLine(GetCantidad().ToString());

            return sb.ToString();
        }

        public void Ingresar(decimal montoAAcreditar)
        {
            if (montoAAcreditar > 0)
            {
                this.cantidad += montoAAcreditar;
            }
        }

        public void Retirar(decimal montoADebitar)
        {
            this.cantidad -= montoADebitar;
        }
    }
}
