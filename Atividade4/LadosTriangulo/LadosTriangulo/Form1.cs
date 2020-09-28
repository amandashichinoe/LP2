using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadosTriangulo
{
    public partial class Form1 : Form
    {
        double valorA, valorB, valorC;
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
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtA.Text == String.Empty || txtB.Text == String.Empty || txtC.Text == String.Empty)
            {
                MessageBox.Show("Não pode haver campos em branco.");
            }
            else
            {
                if((double.TryParse(txtA.Text, out valorA)) && (double.TryParse(txtB.Text, out valorB)) && (double.TryParse(txtC.Text, out valorC)))
                {
                    if((Math.Abs(valorB - valorC) < valorA && valorA < (valorB + valorC)) && 
                        (Math.Abs(valorA - valorC) < valorB && valorB < (valorA + valorC)) && 
                        (Math.Abs(valorA - valorB) < valorC && valorC < (valorA + valorB)))
                    {
                        if(valorA == valorB && valorB == valorC)
                        {
                            MessageBox.Show("Os valores informados formam um Triângulo Equilátero!");
                        }

                        else if(valorA != valorB & valorB !=valorC && valorC != valorA)
                        {
                            MessageBox.Show("Os valores informados formam um Triângulo Escaleno!");
                        }

                        else
                        {
                            MessageBox.Show("Os valores informados formam um Triângulo Isósceles!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Não é possível formar um triângulo com os valores informados.");
                    }
                }
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
