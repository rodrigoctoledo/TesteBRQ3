using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            string input = textBoxVar.Text;

            try
            {
                int valor = Convert.ToInt32(input);

                if (valor % 2 == 0)
                    MessageBox.Show("O número é par.");
                else
                    MessageBox.Show("O número é ímpar.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
