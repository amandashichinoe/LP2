using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os dados
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text = String.Empty;

            txtRaio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if (double.TryParse(txtAltura.Text, out altura) && (double.TryParse(txtRaio.Text, out raio)))
            {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");
            }

            else
                MessageBox.Show("Valores inválidos!");
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) // testa se é enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; //desativa o beep
            }
        }
    }
}
