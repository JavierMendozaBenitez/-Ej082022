using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividad;

        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividad = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisosFiscales lugar)
            : this()
        {
            this._lugar = lugar;
        }
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("Fecha de Inicio: " + ParaisoFiscal.fechaInicioActividad);
            sb.AppendLine("Locación: " + this._lugar);

            sb.AppendLine("Cantidad de 'cuentitas': " + ParaisoFiscal.cantidadDeCuentas);
            sb.AppendLine("************************Listado de cuentas offshores************************");

            foreach (CuentaOffShore i in this._listadoCuentas)
            {                
                Cliente auxCliente = i.Dueño;

                sb.Append(Cliente.RetornarDatos(auxCliente));
                sb.AppendLine("Número de cuenta: " + (int)i);
                sb.AppendLine("Saldo: " + i.Saldo);
                sb.AppendLine("");
            }
            
            Console.WriteLine(sb.ToString());
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            foreach(CuentaOffShore i in pf._listadoCuentas)
            {
                if(i == cos)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            StringBuilder sb = new StringBuilder();

            if (pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                ParaisoFiscal.cantidadDeCuentas--;

                sb.Append("Se quito la cuenta del paraiso...");

            }
            else
            {
                sb.Append("La cuenta no existe en el paraiso...");
            }

            Console.WriteLine(sb.ToString());

            return pf;
        }
        public static ParaisoFiscal operator + (ParaisoFiscal pf, CuentaOffShore cos)
        {
            StringBuilder sb = new StringBuilder();

            if (pf != cos)
            {
                pf._listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;

                sb.Append("Se agrego la cuenta al paraíso...");

            }
            else
            {
                foreach (CuentaOffShore i in pf._listadoCuentas)
                {
                    i.Saldo += cos.Saldo;
                    sb.Append("Se actualizó el saldo de la cuenta...");
                    break;
                }
            }
            
            Console.WriteLine(sb.ToString());

            return pf;
        }
    }
}
