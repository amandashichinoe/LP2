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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumero1.Text) , num2 = Convert.ToInt32(txtNumero2.Text);

           if(num2 > num1)
           {
                Random sorteio = new Random();
                int numSorteado = sorteio.Next(num1,num2);
                
                MessageBox.Show("O número sorteado é: " + numSorteado);
           }

           else
           {
                MessageBox.Show("Insira um intervalo válido!");
           }
                
            
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
