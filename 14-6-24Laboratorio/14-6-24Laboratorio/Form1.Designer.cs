namespace _14_6_24Laboratorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.btnCargarTiempos = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(44, 52);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(101, 56);
            this.btnAgregarCompetidor.TabIndex = 0;
            this.btnAgregarCompetidor.Text = "Agregar competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // btnCargarTiempos
            // 
            this.btnCargarTiempos.Location = new System.Drawing.Point(44, 114);
            this.btnCargarTiempos.Name = "btnCargarTiempos";
            this.btnCargarTiempos.Size = new System.Drawing.Size(101, 63);
            this.btnCargarTiempos.TabIndex = 1;
            this.btnCargarTiempos.Text = "Cargar Tiempos de Competidores";
            this.btnCargarTiempos.UseVisualStyleBackColor = true;
            this.btnCargarTiempos.Click += new System.EventHandler(this.btnCargarTiempos_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(44, 183);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(101, 61);
            this.btnVerResultados.TabIndex = 2;
            this.btnVerResultados.Text = "Ver resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 270);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnCargarTiempos);
            this.Controls.Add(this.btnAgregarCompetidor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.Button btnCargarTiempos;
        private System.Windows.Forms.Button btnVerResultados;
    }
}

