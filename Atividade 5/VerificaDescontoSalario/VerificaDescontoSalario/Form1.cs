using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaDescontoSalario
{
    public partial class Form1 : Form
    {
        double salBruto, salLiquido, salFamilia, numFilho, aliqINSS, aliqIRPF, descINSS, descIRPF;
        string generoTratamento, estadoCivil;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            mskbxNumFilhos.Clear();
            mskbxSalario.Clear();
            mskbxAliqINSS.Clear();
            mskbxAliqIRPF.Clear();
            mskbxDesINSS.Clear();
            mskbxDesIRPF.Clear();
            mskbxSalFamilia.Clear();
            mskbxSalLiquido.Clear();
            cklbEhCasado.Checked = false;
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cklbEhCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
           if((double.TryParse(mskbxSalario.Text, out salBruto)) &&(double.TryParse(mskbxNumFilhos.Text, out numFilho)))
            {
                
                salFamilia = CalculaSalFamilia(salBruto, numFilho);
                generoTratamento = TestarGenero();
                estadoCivil = EstadoCivil();
                CalculaINSS(salBruto);
                CalculaIRPF(salBruto);



                salLiquido = salBruto - descINSS - descIRPF + salFamilia;

                //Exibindo mensagem no formato Label
                lblMensagem.Text = "Os descontos do salário " + generoTratamento + txtName.Text + " que é " + estadoCivil + " e tem " + mskbxNumFilhos.Text + " filho(s) são:";

                //Exibindo saidas
                MessageBox.Show(aliqINSS + " " + +aliqIRPF+ " " +  salFamilia+ " " + salLiquido+ " " +  descINSS+ " " + descIRPF);
            }

            else
            {
                MessageBox.Show("Entrada inválida ou campo em branco");
            }
        }

        private string TestarGenero()
        {
            string genero = " ";

            if (rbtnFeminino.Checked)
            {
                genero = " da Sra. ";
            }
            else if (rbtnMasculino.Checked)
            {
                genero = " do Sr. ";
            }

            else
            {
                MessageBox.Show("Selecione o gênero");
            }

            return genero;
        }

        private string EstadoCivil()
        {
            string ehCasado = " ";

            if (cklbEhCasado.Checked)
            {
                if (rbtnFeminino.Checked)
                {
                    ehCasado = "casada";
                }

                else if (rbtnMasculino.Checked)
                {
                    ehCasado = "casado";
                }
            }

            else
            {
                if (rbtnFeminino.Checked)
                {
                    ehCasado = "solteira";
                }

                else if (rbtnMasculino.Checked)
                {
                    ehCasado = "solteiro";
                }
            }

            return ehCasado;
        }

        private void CalculaINSS(double salBruto)
        {
            if(salBruto <= 2801.56)
            {
                if (salBruto <= 800.47)
                {
                    aliqINSS = (7.65/100);
                }

                else if (salBruto > 800.47 && salBruto <= 1050)
                {
                    aliqINSS = (8.65 / 100);
                }

                else if (salBruto > 1050 && salBruto <= 1400.77)
                {
                    aliqINSS = (9 / 100);
                }

                else //if (salBruto > 1400.77 && salBruto <= 2801.56)
                {
                    aliqINSS = (11 / 10);
                }

                descINSS = aliqINSS * salBruto;

            }

            else
            {
                descINSS = 308.17;
            }

            //return descINSS;
        }

        private void CalculaIRPF(double salBruto)
        {
            if (salBruto > 1257.12)
            {
                if (salBruto <= 2512.08)
                {
                    aliqIRPF = (15/100);
                }

                else 
                {
                    aliqIRPF = (27.5/100);
                }

                descIRPF = aliqIRPF * salBruto;
            }

            else
            {
                descIRPF = 0;
            }

            //return descIRPF;
        }

        private double CalculaSalFamilia(double salBruto, double numFilho)
        {
            if (salBruto < 654.61)
            {
                if (salBruto <= 435.52)
                {
                    salFamilia = 22.33 * numFilho;
                }

                else
                {
                    salFamilia = 15.74 * numFilho;
                }
            }

            else
            {
                salFamilia = 0;
            }

            return salFamilia;
        }
    }
}

