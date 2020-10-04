namespace VerificaDescontoSalario
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.cklbEhCasado = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskbxDesINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDesIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxGenero.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário bruto      R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aliquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salário Família R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salário Liquido R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto INSS R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Desconto IRPF R$";
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalario.Location = new System.Drawing.Point(162, 52);
            this.mskbxSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(81, 26);
            this.mskbxSalario.TabIndex = 10;
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNumFilhos.Location = new System.Drawing.Point(162, 88);
            this.mskbxNumFilhos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxNumFilhos.Mask = "00";
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(25, 26);
            this.mskbxNumFilhos.TabIndex = 11;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(124, 133);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(161, 33);
            this.btnVerificar.TabIndex = 12;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtnMasculino);
            this.gbxGenero.Controls.Add(this.rbtnFeminino);
            this.gbxGenero.Location = new System.Drawing.Point(544, 14);
            this.gbxGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxGenero.Size = new System.Drawing.Size(160, 76);
            this.gbxGenero.TabIndex = 13;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Gênero";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(0, 42);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(0, 19);
            this.rbtnFeminino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // cklbEhCasado
            // 
            this.cklbEhCasado.AutoSize = true;
            this.cklbEhCasado.Location = new System.Drawing.Point(544, 94);
            this.cklbEhCasado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cklbEhCasado.Name = "cklbEhCasado";
            this.cklbEhCasado.Size = new System.Drawing.Size(83, 24);
            this.cklbEhCasado.TabIndex = 14;
            this.cklbEhCasado.Text = "Casado";
            this.cklbEhCasado.UseVisualStyleBackColor = true;
            this.cklbEhCasado.CheckedChanged += new System.EventHandler(this.cklbEhCasado_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(162, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 26);
            this.txtName.TabIndex = 15;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.lblMensagem);
            this.gbxDados.Controls.Add(this.label11);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.mskbxDesINSS);
            this.gbxDados.Controls.Add(this.mskbxDesIRPF);
            this.gbxDados.Controls.Add(this.mskbxAliqIRPF);
            this.gbxDados.Controls.Add(this.mskbxSalFamilia);
            this.gbxDados.Controls.Add(this.mskbxSalLiquido);
            this.gbxDados.Controls.Add(this.mskbxAliqINSS);
            this.gbxDados.Controls.Add(this.label5);
            this.gbxDados.Controls.Add(this.label6);
            this.gbxDados.Controls.Add(this.label7);
            this.gbxDados.Controls.Add(this.label8);
            this.gbxDados.Controls.Add(this.label9);
            this.gbxDados.Controls.Add(this.label10);
            this.gbxDados.Enabled = false;
            this.gbxDados.Location = new System.Drawing.Point(22, 165);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(682, 211);
            this.gbxDados.TabIndex = 22;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(26, 26);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(11, 16);
            this.lblMensagem.TabIndex = 31;
            this.lblMensagem.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "%";
            // 
            // mskbxDesINSS
            // 
            this.mskbxDesINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDesINSS.Location = new System.Drawing.Point(538, 69);
            this.mskbxDesINSS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxDesINSS.Name = "mskbxDesINSS";
            this.mskbxDesINSS.Size = new System.Drawing.Size(72, 26);
            this.mskbxDesINSS.TabIndex = 28;
            // 
            // mskbxDesIRPF
            // 
            this.mskbxDesIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDesIRPF.Location = new System.Drawing.Point(538, 102);
            this.mskbxDesIRPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxDesIRPF.Name = "mskbxDesIRPF";
            this.mskbxDesIRPF.Size = new System.Drawing.Size(72, 26);
            this.mskbxDesIRPF.TabIndex = 27;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(158, 108);
            this.mskbxAliqIRPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(50, 26);
            this.mskbxAliqIRPF.TabIndex = 26;
            // 
            // mskbxSalFamilia
            // 
            this.mskbxSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalFamilia.Location = new System.Drawing.Point(158, 140);
            this.mskbxSalFamilia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxSalFamilia.Name = "mskbxSalFamilia";
            this.mskbxSalFamilia.Size = new System.Drawing.Size(72, 26);
            this.mskbxSalFamilia.TabIndex = 25;
            // 
            // mskbxSalLiquido
            // 
            this.mskbxSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalLiquido.Location = new System.Drawing.Point(158, 174);
            this.mskbxSalLiquido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxSalLiquido.Name = "mskbxSalLiquido";
            this.mskbxSalLiquido.Size = new System.Drawing.Size(72, 26);
            this.mskbxSalLiquido.TabIndex = 24;
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqINSS.Location = new System.Drawing.Point(158, 72);
            this.mskbxAliqINSS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.Size = new System.Drawing.Size(50, 26);
            this.mskbxAliqINSS.TabIndex = 23;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(317, 133);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 33);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(455, 133);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 33);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 379);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cklbEhCasado);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculadora de Descontos INSS e IRPF";
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.CheckBox cklbEhCasado;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskbxDesINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDesIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.Label lblMensagem;
    }
}

