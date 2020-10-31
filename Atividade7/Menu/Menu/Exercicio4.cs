using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double gratificacao, salario;
            int producao;

            if ((double.TryParse(txtSalario.Text, out salario)) && (double.TryParse(txtGratif.Text, out gratificacao)) &&
                int.TryParse(txtProducao.Text, out producao))
            {
                int B=0, C = 0, D = 0;
                double salBruto;

                if (producao >= 100)
                {
                    B = 1;
                    if (producao >= 120)
                    {
                        C = 1;
                        if (producao >= 150)
                            D = 1;
                    }   
                }
                   
                salBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                if(salBruto > 7000)
                {
                    if (producao >= 150 && gratificacao > 0)
                        MessageBox.Show(("O valor do salário bruto é R$: " + salBruto.ToString("N2") + "."));

                    else
                        MessageBox.Show("O valor do salário bruto é R$ 7000,00");
                }

                else
                    MessageBox.Show(("O valor do salário bruto é: R$ " + salBruto.ToString("N2") + "."));
            }

            else
                MessageBox.Show("Valor inválido.");
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            txtGratif.Clear();
            txtNInscricao.Clear();
            txtNome.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
        }
    }
}
