using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace C02_Vulcano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheitA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if (double.TryParse(this.txtFahrenheitA.Text, out tempIng))
            {
                Fahrenheit fahrenheit = new Fahrenheit(tempIng);
                txtFahrenheitAFahrenheit.Text = Convert.ToString(fahrenheit.GetTemperatura);

                Celsius celsius = (Celsius)fahrenheit;
                txtCelsiusAFahrenheit.Text = Convert.ToString(celsius.GetTemperatura);

                Kelvin kelvin = ((Kelvin)fahrenheit).GetTemperatura;
                txtKelvinAFahrenheit.Text = Convert.ToString(kelvin.GetTemperatura);
            }
        }

        private void btnCelsiusA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if (double.TryParse(this.txtCelsiusA.Text, out tempIng))
            {

                Celsius celsius = new Celsius(tempIng);
                txtCelsiusACelsius.Text = Convert.ToString(celsius.GetTemperatura);

                Fahrenheit fahrenheit = (Fahrenheit)celsius;
                txtFahrenheitACelsius.Text = Convert.ToString(fahrenheit.GetTemperatura);

                Kelvin kelvin = ((Kelvin)celsius).GetTemperatura;
                txtKelvinACelsius.Text = Convert.ToString(kelvin.GetTemperatura);
            }
        }

        private void btnKelvinA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if (double.TryParse(this.txtKelvinA.Text, out tempIng))
            {
                Kelvin kelvin = new Kelvin(tempIng);
                txtKelvinAKelvin.Text = Convert.ToString(kelvin.GetTemperatura);

                Celsius celsius = (Celsius)kelvin;
                txtCelsiusAKelvin.Text = Convert.ToString(celsius.GetTemperatura);

                Fahrenheit fahrenheit = ((Fahrenheit)kelvin).GetTemperatura;
                txtFahrenheitAKelvin.Text = Convert.ToString(fahrenheit.GetTemperatura);
            }
        }
    }
}
