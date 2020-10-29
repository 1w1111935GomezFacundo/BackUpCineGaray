namespace CinesGarayConsultas
{
    partial class frmGeneralClientes
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
            this.btnReservas = new System.Windows.Forms.Button();
            this.panelContenedorClientes = new System.Windows.Forms.Panel();
            this.btnConsultarVisitas = new System.Windows.Forms.Button();
            this.picLogoFondo = new System.Windows.Forms.PictureBox();
            this.panelContenedorClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.Black;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(342, 286);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(192, 30);
            this.btnReservas.TabIndex = 14;
            this.btnReservas.Text = "Consultar Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // panelContenedorClientes
            // 
            this.panelContenedorClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelContenedorClientes.Controls.Add(this.btnReservas);
            this.panelContenedorClientes.Controls.Add(this.btnConsultarVisitas);
            this.panelContenedorClientes.Controls.Add(this.picLogoFondo);
            this.panelContenedorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelContenedorClientes.Location = new System.Drawing.Point(1, 0);
            this.panelContenedorClientes.Name = "panelContenedorClientes";
            this.panelContenedorClientes.Size = new System.Drawing.Size(612, 386);
            this.panelContenedorClientes.TabIndex = 15;
            this.panelContenedorClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorClientes_Paint);
            // 
            // btnConsultarVisitas
            // 
            this.btnConsultarVisitas.FlatAppearance.BorderSize = 0;
            this.btnConsultarVisitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.btnConsultarVisitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarVisitas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVisitas.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVisitas.Location = new System.Drawing.Point(48, 286);
            this.btnConsultarVisitas.Name = "btnConsultarVisitas";
            this.btnConsultarVisitas.Size = new System.Drawing.Size(192, 30);
            this.btnConsultarVisitas.TabIndex = 13;
            this.btnConsultarVisitas.Text = "Consultar Visitas";
            this.btnConsultarVisitas.UseVisualStyleBackColor = true;
            this.btnConsultarVisitas.Click += new System.EventHandler(this.btnConsultarVisitas_Click);
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
            // frmGeneralClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.panelContenedorClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneralClientes";
            this.Text = "frmGeneralClientes";
            this.panelContenedorClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Panel panelContenedorClientes;
        private System.Windows.Forms.PictureBox picLogoFondo;
        private System.Windows.Forms.Button btnConsultarVisitas;
    }
}