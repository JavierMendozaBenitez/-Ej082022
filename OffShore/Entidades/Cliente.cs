using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente)
            : this()
        {
            this._tipoDeCliente = tipoCliente;
        }
        public Cliente(eTipoCliente tipoCliente, string nombre)
            : this(tipoCliente)
        {
            this._nombre = nombre;
        }
        private void CrearAlias()
        {
            Random rdn = new Random();

            this._aliasParaIncognito = $"{rdn.Next(1000, 9999).ToString()}{this._tipoDeCliente}";
        }
        public string GetAlias()
        {
            if (_aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
            }

            return _aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
                       
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Tipo: " + this._tipoDeCliente);
            sb.AppendLine("Alias: " + this.GetAlias());
            
            return sb.ToString();
        }
        public static string RetornarDatos(Cliente uncliente)
        {
            return uncliente.RetornarDatos();
        }

    }
}
