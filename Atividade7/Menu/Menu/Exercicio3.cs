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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            txtPalavra.Text = txtPalavra.Text.ToUpper(); //transformando todas as letras em maiusculas

            txtPalavra.Text = txtPalavra.Text.Replace(" ", ""); //removendo os espacos em branco

            string inversa = txtPalavra.Text;
            char[] aux = inversa.ToCharArray(); //invertendo a palavra
            Array.Reverse(aux);
            inversa = "";
            foreach (char c in aux)
                inversa += c.ToString();

            txtInversa.Text = inversa;

            if(String.Compare(txtPalavra.Text, inversa) == 0) //verificando se e um palindromo
            {
                MessageBox.Show("É um palíndromo.");
            }
            else
            {
                MessageBox.Show("Não é um palíndromo.");
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInversa.Clear();
            txtPalavra.Clear();
        }
    }
}
