namespace _14_6_24Laboratorio
{
    partial class VerResultados
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
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.gbxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResultados
            // 
            this.gbxResultados.Controls.Add(this.btnCerrar);
            this.gbxResultados.Controls.Add(this.lbxResultados);
            this.gbxResultados.Location = new System.Drawing.Point(25, 13);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(215, 327);
            this.gbxResultados.TabIndex = 0;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.Location = new System.Drawing.Point(69, 272);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lbxResultados
            // 
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.Location = new System.Drawing.Point(6, 15);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(192, 251);
            this.lbxResultados.TabIndex = 0;
            // 
            // VerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 362);
            this.Controls.Add(this.gbxResultados);
            this.Name = "VerResultados";
            this.Text = "VerResultados";
            this.Load += new System.EventHandler(this.VerResultados_Load);
            this.gbxResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.ListBox lbxResultados;
    }
}