using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P30482011002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int quantidadeMeses = 2, semanasMes = 4; //final do meu RA = 2 , logo quantidadeMeses = 2
            double totalVendidoMes = 0, totalGeral = 0;
            double[,] vendas = new double[quantidadeMeses, semanasMes];
            string valor;
            bool avancar;

            //Validando valores numéricos
            for (int i = 0; i < quantidadeMeses; i++)
            {
                for (int j = 0; j < semanasMes; j++)
                {
                    avancar = false;
                    do
                    {
                        valor = Interaction.InputBox("Mês: " + (i + 1) + ", Semana: " + (j + 1));
                        if (double.TryParse(valor, out vendas[i, j]))
                        {
                            totalGeral += vendas[i, j];
                            avancar = true;
                        }

                        else
                            MessageBox.Show("Entrada Inválida!");
                    } while (avancar == false);
                }
            }

            // imprimindo a saída no ListBox
            lbxSaida.BeginUpdate();
            for (int i = 0; i < quantidadeMeses; i++)
            {
                for (int j = 0; j < semanasMes; j++)
                {
                    lbxSaida.Items.Add("Total do mês: " + (i + 1) + " Semana:" + (j + 1) + " R$" + vendas[i, j].ToString("N2"));
                    totalVendidoMes += vendas[i, j];
                    totalGeral += vendas[i, j];
                }
                lbxSaida.Items.Add(">> Total Mês: R$" + totalVendidoMes.ToString("N2"));
                lbxSaida.Items.Add("---------------------------");
            }
            lbxSaida.Items.Add(">> Total Geral: R$" + totalGeral.ToString("N2"));
            lbxSaida.EndUpdate();
        }
    }
}
