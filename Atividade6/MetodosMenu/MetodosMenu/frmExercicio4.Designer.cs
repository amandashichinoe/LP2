namespace MetodosMenu
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnContLetra = new System.Windows.Forms.Button();
            this.btnPosBranco = new System.Windows.Forms.Button();
            this.btnContNumeros = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Location = new System.Drawing.Point(12, 12);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(390, 100);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnContLetra
            // 
            this.btnContLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContLetra.Location = new System.Drawing.Point(12, 233);
            this.btnContLetra.Name = "btnContLetra";
            this.btnContLetra.Size = new System.Drawing.Size(390, 45);
            this.btnContLetra.TabIndex = 16;
            this.btnContLetra.Text = "Quantidade de letras";
            this.btnContLetra.UseVisualStyleBackColor = true;
            this.btnContLetra.Click += new System.EventHandler(this.btnContLetra_Click);
            // 
            // btnPosBranco
            // 
            this.btnPosBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosBranco.Location = new System.Drawing.Point(12, 172);
            this.btnPosBranco.Name = "btnPosBranco";
            this.btnPosBranco.Size = new System.Drawing.Size(390, 55);
            this.btnPosBranco.TabIndex = 15;
            this.btnPosBranco.Text = "Posição do primeiro espaço em branco";
            this.btnPosBranco.UseVisualStyleBackColor = true;
            this.btnPosBranco.Click += new System.EventHandler(this.btnPosBranco_Click);
            // 
            // btnContNumeros
            // 
            this.btnContNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContNumeros.Location = new System.Drawing.Point(12, 118);
            this.btnContNumeros.Name = "btnContNumeros";
            this.btnContNumeros.Size = new System.Drawing.Size(390, 48);
            this.btnContNumeros.TabIndex = 14;
            this.btnContNumeros.Text = "Quantidade de números";
            this.btnContNumeros.UseVisualStyleBackColor = true;
            this.btnContNumeros.Click += new System.EventHandler(this.btnContNumeros_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(390, 41);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnContLetra);
            this.Controls.Add(this.btnPosBranco);
            this.Controls.Add(this.btnContNumeros);
            this.Controls.Add(this.rchTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnContLetra;
        private System.Windows.Forms.Button btnPosBranco;
        private System.Windows.Forms.Button btnContNumeros;
        private System.Windows.Forms.Button btnLimpar;
    }
}