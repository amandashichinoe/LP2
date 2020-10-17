using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosMenu
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("São iguais!");

            else
                MessageBox.Show("São diferentes!");
        }

        private void btnInsere1em2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length-meio); 
        }

        private void btnInsereAsteriscos_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Clear();
            txtPalavra2.Clear();
        }
    }
}
