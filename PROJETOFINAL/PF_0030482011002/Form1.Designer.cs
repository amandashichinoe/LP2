namespace PF_0030482011002
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuCadastroCidades = new System.Windows.Forms.MenuStrip();
            this.cadastroCidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCadastroCidades
            // 
            this.menuCadastroCidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCidadesToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuCadastroCidades.Location = new System.Drawing.Point(0, 0);
            this.menuCadastroCidades.Name = "menuCadastroCidades";
            this.menuCadastroCidades.Size = new System.Drawing.Size(714, 24);
            this.menuCadastroCidades.TabIndex = 0;
            this.menuCadastroCidades.Text = "menuStrip1";
            this.menuCadastroCidades.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuCadastroCidades_ItemClicked);
            // 
            // cadastroCidadesToolStripMenuItem
            // 
            this.cadastroCidadesToolStripMenuItem.Name = "cadastroCidadesToolStripMenuItem";
            this.cadastroCidadesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cadastroCidadesToolStripMenuItem.Text = "Cadastro Cidades";
            this.cadastroCidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastroCidadesToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 378);
            this.Controls.Add(this.menuCadastroCidades);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuCadastroCidades;
            this.Name = "frmPrincipal";
            this.Text = "Projeto Final";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuCadastroCidades.ResumeLayout(false);
            this.menuCadastroCidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCadastroCidades;
        private System.Windows.Forms.ToolStripMenuItem cadastroCidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

