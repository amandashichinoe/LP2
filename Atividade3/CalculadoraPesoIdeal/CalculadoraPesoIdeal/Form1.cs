using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPesoIdeal
{
    public partial class Form1 : Form
    {
        double altura, peso, pesoIdeal;
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
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private double CalcularPesoIdeal(double altura)
        {
            if (rbtnFeminino.Checked)
            {
                pesoIdeal = ((62.1 * altura) - 44.7);
            }

            else if (rbtnMasculino.Checked)
            {
                pesoIdeal = ((72.7 * altura) - 58);
            }

            else
            {
                MessageBox.Show("Selecione o gênero.");
            }
            return pesoIdeal;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if ((double.TryParse(mskbxAltura.Text, out altura)) && (double.TryParse(mskbxPeso.Text, out peso)))
            {
                pesoIdeal = Math.Round((CalcularPesoIdeal(altura)), 2);

                MessageBox.Show("Seu peso ideal e " + pesoIdeal.ToString("N2") + "Kg");

                if (peso < pesoIdeal)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }

                else if (peso == pesoIdeal)
                {
                    MessageBox.Show("Você está com o peso ideal");
                }

                else if (peso > pesoIdeal)
                {
                    MessageBox.Show("Regime obrigatório já");
                }
            }

            else
            {
                MessageBox.Show("Campo em Branco ou valor inválido!");
            }
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
