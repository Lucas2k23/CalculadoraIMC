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
            double txbPeso,txbAltura,txbImc;
            txbPeso = double.Parse(txbNum1.Text);
            txbAltura = double.Parse(txbNum2.Text);
            txbImc = txbPeso / (txbAltura * 2);
            txbResultado.Text = txbImc.ToString();
        }
    }
}
