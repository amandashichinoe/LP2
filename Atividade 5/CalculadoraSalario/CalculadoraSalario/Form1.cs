using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSalario
{
    public partial class Form1 : Form
    {
        double aliqINSS, descINSS, aliqIRPF, descIRPF, salBruto, numFilhos, salFamilia, salLiquido;

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAliqINSS.Clear();
            mskbxAliqIRPF.Clear();
            mskbxDescINSS.Clear(); 
            mskbxDescIRPF.Clear(); 
            txtNome.Clear();
            mskbxNumFilhos.Clear(); 
            mskbxSalBruto.Clear();
            mskbxSalFamilia.Clear();
            mskbxSalLiquido.Clear();
            ckbxIsMarried.Checked = false;
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;
            

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if((double.TryParse(mskbxSalBruto.Text, out salBruto)) && (double.TryParse(mskbxNumFilhos.Text, out numFilhos)))
            {
                //Exibindo mensagem no formato Label
                lblMensagem.Text = "Os descontos do salário " + TestarGenero() + txtNome.Text + " que é " + EstadoCivil() + " e tem " + mskbxNumFilhos.Text + " filho(s) são:";

                CalculaINSS(salBruto);
                CalculaIRPF(salBruto);
                CalculaSalFamilia(salBruto, numFilhos);

                salLiquido = salBruto - descINSS - descIRPF + salFamilia;

                mskbxAliqINSS.Text = aliqINSS.ToString("N2");
                mskbxAliqIRPF.Text = aliqIRPF.ToString("N2");
                mskbxDescIRPF.Text = descIRPF.ToString("N2");
                mskbxDescINSS.Text = descINSS.ToString("N2");
                mskbxSalFamilia.Text = salFamilia.ToString("N2");
                mskbxSalLiquido.Text = salLiquido.ToString("N2");

            }
            else
            {
                MessageBox.Show("Entradas inválidas ou campo em branco.");
            }
        }

        private string TestarGenero()
        {
            string genero = " ";

            if (rbtnFeminino.Checked)
            {
                genero = "da Sra. ";
            }
            else if (rbtnMasculino.Checked)
            {
                genero = "do Sr. ";
            }

            else
            {
                MessageBox.Show("Selecione o gênero");
            }

            return genero;
        }

        private string EstadoCivil()
        {
            string isMarried = " ";

            if (ckbxIsMarried.Checked)
            {
                if (rbtnFeminino.Checked)
                {
                    isMarried = "casada";
                }

                else if (rbtnMasculino.Checked)
                {
                    isMarried = "casado";
                }
            }

            else
            {
                if (rbtnFeminino.Checked)
                {
                    isMarried = "solteira";
                }

                else if (rbtnMasculino.Checked)
                {
                    isMarried = "solteiro";
                }
            }

            return isMarried;
        }

        private void CalculaINSS(double salBruto)
        {
            if (salBruto > 2801.56)
            {
                descINSS = 308.17;
                //se a aliquota for o teto, como escrever isso na caixa de texto ?
            }

            else
            {
                if(salBruto <= 800.47)
                {
                    aliqINSS = 7.65;
                }

                else if(salBruto > 800.47 && salBruto <= 1050)
                {
                    aliqINSS = 8.65;
                }

                else if(salBruto > 1050 && salBruto <= 1400.77)
                {
                    aliqINSS = 9;
                }

                else if(salBruto > 1400.77 && salBruto <= 2801.56)
                {
                    aliqINSS = 11;
                }

                descINSS = salBruto * (aliqINSS / 100);
            }
        }

        private void CalculaIRPF(double salBruto)
        {
            if(salBruto > 2512.08)
            {
                aliqIRPF = 27.5;
            }

            else if (salBruto <= 1257.12)
            {
                aliqIRPF = 0;
            }

            else
            {
                aliqIRPF = 15;
            }

            descIRPF = salBruto * (aliqIRPF / 100);
        }

       private void CalculaSalFamilia(double salBruto, double numFilhos)
        {
            if(salBruto > 654.61)
            {
                salFamilia = 0;
            }

            else if(salBruto <= 435.52)
            {
                salFamilia = 22.33 * numFilhos;
            }

            else //if(salBruto > 435.52 && salBruto <= 654.61)
            {
                salFamilia = 15.74 * numFilhos;
            }
        }
    }
}
