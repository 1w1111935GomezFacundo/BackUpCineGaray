namespace CinesGarayConsultas
{
    partial class frmGeneralOtros
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
            this.panelContenedorClientes = new System.Windows.Forms.Panel();
            this.picLogoFondo = new System.Windows.Forms.PictureBox();
            this.panelContenedorClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorClientes
            // 
            this.panelContenedorClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelContenedorClientes.Controls.Add(this.picLogoFondo);
            this.panelContenedorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelContenedorClientes.Location = new System.Drawing.Point(0, 1);
            this.panelContenedorClientes.Name = "panelContenedorClientes";
            this.panelContenedorClientes.Size = new System.Drawing.Size(612, 386);
            this.panelContenedorClientes.TabIndex = 16;
            // 
            // picLogoFondo
            // 
            this.picLogoFondo.Image = global::CinesGarayConsultas.Properties.Resources.LogoCinesReportes;
            this.picLogoFondo.Location = new System.Drawing.Point(102, 21);
            this.picLogoFondo.Name = "picLogoFondo";
            this.picLogoFondo.Size = new System.Drawing.Size(396, 342);
            this.picLogoFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoFondo.TabIndex = 2;
            this.picLogoFondo.TabStop = false;
            // 
            // frmGeneralOtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.panelContenedorClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneralOtros";
            this.Text = "frmGeneralOtros";
            this.panelContenedorClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorClientes;
        private System.Windows.Forms.PictureBox picLogoFondo;
    }
}