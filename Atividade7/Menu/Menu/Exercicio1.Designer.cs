namespace Menu
{
    partial class frmExercicio1
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
            this.rchFrase = new System.Windows.Forms.RichTextBox();
            this.btnWhiteSpace = new System.Windows.Forms.Button();
            this.btnQtdeR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchFrase
            // 
            this.rchFrase.Location = new System.Drawing.Point(3, 32);
            this.rchFrase.Name = "rchFrase";
            this.rchFrase.Size = new System.Drawing.Size(387, 86);
            this.rchFrase.TabIndex = 0;
            this.rchFrase.Text = "";
            // 
            // btnWhiteSpace
            // 
            this.btnWhiteSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhiteSpace.Location = new System.Drawing.Point(3, 124);
            this.btnWhiteSpace.Name = "btnWhiteSpace";
            this.btnWhiteSpace.Size = new System.Drawing.Size(387, 34);
            this.btnWhiteSpace.TabIndex = 1;
            this.btnWhiteSpace.Text = "Contar espaços em branco";
            this.btnWhiteSpace.UseVisualStyleBackColor = true;
            this.btnWhiteSpace.Click += new System.EventHandler(this.btnWhiteSpace_Click);
            // 
            // btnQtdeR
            // 
            this.btnQtdeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdeR.Location = new System.Drawing.Point(3, 164);
            this.btnQtdeR.Name = "btnQtdeR";
            this.btnQtdeR.Size = new System.Drawing.Size(387, 34);
            this.btnQtdeR.TabIndex = 2;
            this.btnQtdeR.Text = "Contar letras \'R\'";
            this.btnQtdeR.UseVisualStyleBackColor = true;
            this.btnQtdeR.Click += new System.EventHandler(this.btnQtdeR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParLetras.Location = new System.Drawing.Point(3, 204);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(387, 35);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "Contar pares de letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(3, 245);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(387, 33);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(-1, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(127, 20);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Insira uma frase:";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 281);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnQtdeR);
            this.Controls.Add(this.btnWhiteSpace);
            this.Controls.Add(this.rchFrase);
            this.Name = "frmExercicio1";
            this.Text = "Exercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchFrase;
        private System.Windows.Forms.Button btnWhiteSpace;
        private System.Windows.Forms.Button btnQtdeR;
        private System.Windows.Forms.Button btnParLetras;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblInfo;
    }
}