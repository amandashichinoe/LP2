using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InputBox_e_Vetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarJuntar_Click(object sender, EventArgs e) //Exercicio 1
        {
            double[] vetor = new double[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número" + (i + 1).ToString(), "Entrada de Dados");

                if (double.TryParse(auxiliar, out vetor[i]))
                {
                    vetor[i] = Convert.ToDouble(auxiliar);
                    saida =vetor[i].ToString() + "\n" + saida; //Forma 2 de inverter a saída (mais simples)
                }

                else
                {
                    MessageBox.Show("Entrada inválida");
                    i -= 1;
                }
            }

            MessageBox.Show(saida);

            /* Forma 1 de inverter a saída do Vetor
            auxiliar = "";

            for (var i = vetor.Length - 1; i >= 0; i--)
                auxiliar += vetor[i].ToString() + "\n";

            MessageBox.Show(auxiliar);
            */
        }

        private void btnListarJuntarReverse_Click(object sender, EventArgs e) //Exercício 2
        {
            double[] vetor = new double[20];
            string auxiliar = "", valor = "";

            for(int i=0; i<vetor.Length; i++)
            {
                valor = Interaction.InputBox("Digite o número: " + (i + 1), "Entrada de Dados");

                if(!double.TryParse(valor, out vetor[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                }
            }

            Array.Reverse(vetor); // invertendo o vetor usando Reverse

            for (int i = 0; i < vetor.Length; i++)
                auxiliar += vetor[i] + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btn3_Click(object sender, EventArgs e) //Exercício 3
        {
            double[] qtde = new double[10];
            double[] preco = new double[10];
            string aux = "";
            bool avancar;

            for (int i = 0; i < 10; i++)
            {
                avancar = false;
                do
                {
                    aux = Interaction.InputBox("Insira a quantidade: " + (i + 1), "Entrada de Dados");
                    if (double.TryParse(aux, out qtde[i]))
                        avancar = true;

                    else
                    {
                        MessageBox.Show("Valor inválido!");
                        avancar = false;
                    }

                } while (avancar == false);

                do
                {
                    aux = Interaction.InputBox("Insira o preço: " + (i + 1), "Entrada de Dados");
                    if (double.TryParse(aux, out preco[i]))
                        avancar = true;

                    else
                    {
                        MessageBox.Show("Valor inválido!");
                        avancar = false;
                    }

                } while (avancar == false);
            }

            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += qtde[i] * preco[i];
            }

            MessageBox.Show("O faturamento total é: R$" + total.ToString("N2"));

        }

        private void btnTotalAlunos_Click(object sender, EventArgs e) //Exercicio 4
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Júnior", "Leonardo", "José", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for(I = 0; I< N-1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show("Total vale: " + Total);
        }

        private void btnInserirAlunos_Click(object sender, EventArgs e) //Exercicio 5
        {
            ArrayList alunos = new ArrayList(10);

            for (int i = 0; i < 10; i++)
            {
                alunos.Add("Ana");
                alunos.Add("André");
                alunos.Add("Débora");
                alunos.Add("Fátima");
                alunos.Add("João");
                alunos.Add("Janete");
                alunos.Add("Otávio");
                alunos.Add("Marcelo");
                alunos.Add("Pedro");
                alunos.Add("Thais");
            }

            alunos.Remove("Otavio");

            string juntarNomes = "";

            for (int i = 0; i < 9; i++)
                juntarNomes += alunos[i] + " ";

            MessageBox.Show(juntarNomes);
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e) //Exercicio 6
        {
            double [,] notasAlunos  = new double [20, 3];
            double[] media = new double[20];
            string nota;
            string saida = "";

            for(int i = 0; i < 20; i++)
            {
                media[i] = 0;

                for(int j=0; j<3; j++)
                {
                    while (true)
                    {
                        nota = Interaction.InputBox("Aluno: " + (i + 1) + "\nDisciplina: " + (j + 1));

                        if (double.TryParse(nota, out notasAlunos[i, j]))
                        {
                            media[i] += notasAlunos[i, j];
                            break;
                        }

                        else
                            MessageBox.Show("Entrada inválida!");
                    }
                }
            }

            for (int i = 0; i < 20; i++)
                saida += "Aluno " + (i + 1) + ": média: " + (media[i] / 3).ToString("N2") + "\n";

            MessageBox.Show(saida);
        }

        private void btnExercicio7_Click(object sender, EventArgs e) //Exercicio 7
        {
            frmExercicio7 frmExercicio7 = new frmExercicio7();
            frmExercicio7.Show();
        }
    }
}
