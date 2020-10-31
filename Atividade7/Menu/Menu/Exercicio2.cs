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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void lblInfo2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N;
            if ((txtN.Text == string.Empty) || (!int.TryParse(txtN.Text, out N)))
            {
                MessageBox.Show("Valor inválido ou campo em branco!");
                txtN.Clear();
                rchH.Clear();
            }

            else
            {
                int i;
                double H = 0;
                N = int.Parse(txtN.Text);
               
                for (i = 1; i <= N; i++)
                {
                    H += 1 / (double)i;
                }
                
                rchH.Text = "O valor de H é " + H.ToString("N4") + ".";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            rchH.Clear();
        }
    }
}
