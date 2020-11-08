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

namespace InputBox_e_Vetores
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int meuRA = 2; //o último dígito do meu RA é 2
            string[] nomes = new string[meuRA];
            int[] numChars = new int[meuRA];
            string nome;
            string[] nomeSemEspaco = new string[meuRA];

            for (int i = 0; i < meuRA; i++)
            {
                nome = Interaction.InputBox("Nome " + (i + 1) + ":");
                nomes[i] = nome;
                nomeSemEspaco[i] = nome.Replace(" ","");
                numChars[i] = nomeSemEspaco[i].Length;
            }

            lbxSaida.BeginUpdate();
            for(int i=0; i<meuRA; i++)
                lbxSaida.Items.Add(" O nome " + nomes[i] + " tem " + numChars[i] + " caracteres (sem espaço).\n");

            lbxSaida.EndUpdate();
        }
    }
}
