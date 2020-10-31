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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnWhiteSpace_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int whiteSpace = 0;
            while (cont < rchFrase.Text.Length)
            {
                if (char.IsWhiteSpace(rchFrase.Text[cont]))
                {
                    whiteSpace++;
                }
                cont++;
            }

            MessageBox.Show("O número de espaços em branco na frase é " + whiteSpace + "!");
        }

        private void btnQtdeR_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char c in rchFrase.Text)
            {
                if (c == 'R' || c == 'r')
                    cont++;
            }
            MessageBox.Show("A letra 'R' aparece " + cont + " vezes na frase!");
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int i;
            int cont = 0;

            for (i = 1; i < rchFrase.Text.Length; i++)
            {
                if (rchFrase.Text[i] == rchFrase.Text[i - 1])
                {
                    cont++;
                }
            }

            MessageBox.Show("Um par de letras ocorre " + cont + " vezes na frase.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchFrase.Clear();
        }
    }
}
