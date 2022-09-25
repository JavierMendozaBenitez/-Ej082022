﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this.Saldo = saldoInicial;
        }
        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial)
            :this(new Cliente(tipo, nombre), numero, saldoInicial)
        {
            
        }
        public Cliente Dueño
        {
            get
            {
                return this._dueño;
            }
        }
        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }
        public static bool operator == (CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return (cos1._numeroCuenta == cos2._numeroCuenta && cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias());
            //if (cos1 is not null && cos2 is not null)
            //{
            //    if ((cos1._numeroCuenta == cos2._numeroCuenta) && (cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias()))
            //    {
            //        return true;
            //    }

            //    return false;
            //}

            //return false;
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
    }
}
