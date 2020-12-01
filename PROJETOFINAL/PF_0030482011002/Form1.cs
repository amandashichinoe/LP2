using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482011002
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCity = new frmCidade();
            frmCity.MdiParent = this;
            frmCity.WindowState = FormWindowState.Maximized;
            frmCity.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-4EAH33T\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.MdiParent = this;
            frmSobre.WindowState = FormWindowState.Maximized;
            frmSobre.Show();
        }

        private void menuCadastroCidades_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];

            if (fc != null)
                fc.Close();
        }
    }
}
