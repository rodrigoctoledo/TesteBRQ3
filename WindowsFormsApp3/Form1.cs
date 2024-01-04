using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double temperaturaCelsius))
            {
                // Converter para Kelvin
                double temperaturaKelvin = CelsiusParaKelvin(temperaturaCelsius);

                // Converter para Fahrenheit
                double temperaturaFahrenheit = CelsiusParaFahrenheit(temperaturaCelsius);

                // Exibir resultados
                lblKelvin.Text = $"Temperatura em Kelvin: {temperaturaKelvin} K";
                lblFahrenheit.Text = $"Temperatura em Fahrenheit: {temperaturaFahrenheit} °F";
            }
            else
            {
                MessageBox.Show("Entrada inválida. Certifique-se de inserir um número válido para a temperatura em Celsius.");
            }
        }

        private double CelsiusParaKelvin(double temperaturaCelsius)
        {
            // KELVIN = Tc + 273.15
            return temperaturaCelsius + 273.15;
        }

        private double CelsiusParaFahrenheit(double temperaturaCelsius)
        {
            // FAHRENHEIT = (Tf - 32) * 5 / 9
            return (temperaturaCelsius * 9 / 5) + 32;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
