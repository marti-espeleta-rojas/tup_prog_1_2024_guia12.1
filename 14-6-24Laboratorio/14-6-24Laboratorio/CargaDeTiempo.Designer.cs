namespace _14_6_24Laboratorio
{
    partial class CargaDeTiempo
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
            this.lbNumeroCompetidor = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbMins = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumeroCompetidor
            // 
            this.lbNumeroCompetidor.AutoSize = true;
            this.lbNumeroCompetidor.Location = new System.Drawing.Point(50, 41);
            this.lbNumeroCompetidor.Name = "lbNumeroCompetidor";
            this.lbNumeroCompetidor.Size = new System.Drawing.Size(100, 13);
            this.lbNumeroCompetidor.TabIndex = 0;
            this.lbNumeroCompetidor.Text = "Número Competidor";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(216, 40);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(0, 13);
            this.lbNumero.TabIndex = 1;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(53, 84);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(42, 13);
            this.lbTiempo.TabIndex = 2;
            this.lbTiempo.Text = "Tiempo";
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(128, 84);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 20);
            this.tbHoras.TabIndex = 3;
            // 
            // tbMins
            // 
            this.tbMins.Location = new System.Drawing.Point(249, 84);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(100, 20);
            this.tbMins.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(75, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CargaDeTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 171);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbNumeroCompetidor);
            this.Name = "CargaDeTiempo";
            this.Text = "CargaDeTiempo";
            this.Load += new System.EventHandler(this.CargaDeTiempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumeroCompetidor;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbTiempo;
        public System.Windows.Forms.TextBox tbHoras;
        public System.Windows.Forms.TextBox tbMins;
        public System.Windows.Forms.Button btnAgregar;
    }
}