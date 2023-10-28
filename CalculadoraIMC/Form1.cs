using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double txbPeso, txbAltura, txbImc;
                txbPeso = double.Parse(txbNum1.Text);
                txbAltura = double.Parse(txbNum2.Text);
                txbImc = txbPeso / (txbAltura * txbAltura);
                txbResultado.Text = txbImc.ToString();

                if (txbImc < 18.5)
                {
                    lblInformacao.ForeColor = Color.Orange;
                    lblInformacao.Text = "Você esta abaixo do peso!";

                }
                else if (txbImc >= 18.6 && txbImc <= 24.9)
                {
                    lblInformacao.ForeColor = Color.Green;
                    lblInformacao.Text = "Peso ideal (parabéns!)";
                }
                else if (txbImc >= 25.0 && txbImc <= 29.9)
                {
                    lblInformacao.ForeColor = Color.Yellow;
                    lblInformacao.Text = "Levemente acima do peso";
                }
                else if (txbImc >= 30.0 && txbImc <= 34.9)
                {
                    lblInformacao.ForeColor = Color.OrangeRed;
                    lblInformacao.Text = "Obesidade grau I";
                }
                else if (txbImc >= 35.0 && txbImc <= 39.9)
                {
                    lblInformacao.ForeColor = Color.Red;
                    lblInformacao.Text = "Obesidade Grau II";
                }
                else if (txbImc >= 40.0)
                {
                    lblInformacao.ForeColor = Color.DarkRed;
                    lblInformacao.Text = "Obesidade III";
                }
                
            }
            catch
            {
                MessageBox.Show("Erro inesperado!");
            }


        }
    }
}
