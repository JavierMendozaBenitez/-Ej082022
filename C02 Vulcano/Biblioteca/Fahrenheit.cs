﻿using System;

namespace Biblioteca
{
    public class Fahrenheit
    {
        private double temperatura;
        private static double tempRespectoFahrenheit;

        static Fahrenheit()
        {
            Fahrenheit.tempRespectoFahrenheit = Celsius.GetTempRespectoFahrenheit * (9 / 5) + 32;
        }
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Fahrenheit(double temperatura, double tempRespectoFahrenheit)
            : this(temperatura)
        {
            Fahrenheit.tempRespectoFahrenheit = tempRespectoFahrenheit;
        }

        public double GetTemperatura
        {
            get
            {
                return this.temperatura;
            }
        }

        public static double GetTempRespectoFahrenheit
        {
            get
            {
                return Fahrenheit.tempRespectoFahrenheit;
            }
        }

        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Celsius(Fahrenheit f)//quiero convertir a Celsius los Fahrenheit que recibo
        {
            //return new Celsius(f.temperatura * Celsius.GetTempRespectoFahrenheit);
            return new Celsius((f.temperatura - 32) * 5 / 9);
        }

        public static explicit operator Kelvin(Fahrenheit f)//quiero convertir a kelvi los Fahrenheit que recibo
        {
            //return new Kelvin(f.temperatura * Kelvin.GetTempRespectoFahrenheit);
            return new Kelvin((f.temperatura + 459.67) * 5 / 9);
        }




        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetTemperatura == f2.GetTemperatura;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1.GetTemperatura == f2.GetTemperatura);
        }



        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return ((f.GetTemperatura == ((Fahrenheit)c).GetTemperatura));
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !((f.GetTemperatura == ((Fahrenheit)c).GetTemperatura));
        }



        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return ((f.GetTemperatura == ((Fahrenheit)k).GetTemperatura));
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !((f.GetTemperatura == ((Fahrenheit)k).GetTemperatura));
        }





        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((f.GetTemperatura + ((Fahrenheit)c).GetTemperatura));
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((f.GetTemperatura + ((Fahrenheit)k).GetTemperatura));
        }



        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((f.GetTemperatura - ((Fahrenheit)c).GetTemperatura));
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((f.GetTemperatura - ((Fahrenheit)k).GetTemperatura));
        }
    }
}

