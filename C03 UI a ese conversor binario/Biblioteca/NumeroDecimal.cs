﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumeroDecimal
        {
            get
            {
                return this.numero;
            }
        }

        /*public static implicit operator double (NumeroDecimal nuDecimal)//covierto a double los NumeroDecimal que recibo
        {
            return nuDecimal;
        }
        public static explicit operator NumeroDecimal(double nuDecimal)//covierto a NumeroDecimal los double que recibo
        {
            return new NumeroDecimal(nuDecimal);
        }*/

        //Agregado el 18-09-22, no aparecia en los otros ejercicios
        public static explicit operator NumeroDecimal(NumeroBinario nuBinario)//covierto a Decimal los Binarios que recibo
        {
            return new NumeroDecimal(Conversor.ConvertirBinarioADecimal(nuBinario.numero));
        }


        public static explicit operator double(NumeroDecimal nuDecimal)//covierto a double los NumeroDecimal que recibo
        {
            return nuDecimal.numero;
        }

        public static implicit operator NumeroDecimal(double nuDecimal)//covierto a NumeroDecimal los double que recibo
        {
            return new NumeroDecimal(nuDecimal);
        }

        public static double operator +(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero + Conversor.ConvertirBinarioADecimal(nuBinario.numero);
        }

        public static double operator -(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero - Conversor.ConvertirBinarioADecimal(nuBinario.numero);
        }
        public static bool operator ==(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero == Conversor.ConvertirBinarioADecimal(nuBinario.numero);
        }

        public static bool operator !=(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return !(nuDecimal.numero == Conversor.ConvertirBinarioADecimal(nuBinario.numero));
        }
    }
}