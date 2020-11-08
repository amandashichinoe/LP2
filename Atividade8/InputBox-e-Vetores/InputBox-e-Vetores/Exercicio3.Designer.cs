namespace InputBox_e_Vetores
{
    partial class frmExercicio7
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lbxSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(12, 12);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(600, 62);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lbxSaida
            // 
            this.lbxSaida.FormattingEnabled = true;
            this.lbxSaida.Location = new System.Drawing.Point(12, 80);
            this.lbxSaida.Name = "lbxSaida";
            this.lbxSaida.Size = new System.Drawing.Size(600, 82);
            this.lbxSaida.TabIndex = 1;
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.lbxSaida);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExercicio7";
            this.Text = "Exercicio 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox lbxSaida;
    }
}