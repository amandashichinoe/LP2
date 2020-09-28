using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2;
        double resultado;

       // string texto = "global";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                if(numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();                  
                }

                else
                {
                    MessageBox.Show("O denominador não pode ser igual a zero!");
                }
               
            }
            else
                MessageBox.Show("Número inválido");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = " ";
            txtNum2.Clear();
            txtResultado.Text = String.Empty;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido");
        }

        private void clickEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
