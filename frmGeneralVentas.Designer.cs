namespace CinesGarayConsultas
{
    partial class frmGeneralVentas
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
            this.btnEntradasVendidas = new System.Windows.Forms.Button();
            this.btnCantidadVentas = new System.Windows.Forms.Button();
            this.picLogoFondo = new System.Windows.Forms.PictureBox();
            this.panelContenedorClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorClientes
            // 
            this.panelContenedorClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelContenedorClientes.Controls.Add(this.btnEntradasVendidas);
            this.panelContenedorClientes.Controls.Add(this.btnCantidadVentas);
            this.panelContenedorClientes.Controls.Add(this.picLogoFondo);
            this.panelContenedorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelContenedorClientes.Location = new System.Drawing.Point(1, 0);
            this.panelContenedorClientes.Name = "panelContenedorClientes";
            this.panelContenedorClientes.Size = new System.Drawing.Size(612, 386);
            this.panelContenedorClientes.TabIndex = 16;
            this.panelContenedorClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorClientes_Paint);
            // 
            // btnEntradasVendidas
            // 
            this.btnEntradasVendidas.FlatAppearance.BorderSize = 0;
            this.btnEntradasVendidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.btnEntradasVendidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntradasVendidas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradasVendidas.ForeColor = System.Drawing.Color.Black;
            this.btnEntradasVendidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradasVendidas.Location = new System.Drawing.Point(127, 313);
            this.btnEntradasVendidas.Name = "btnEntradasVendidas";
            this.btnEntradasVendidas.Size = new System.Drawing.Size(332, 30);
            this.btnEntradasVendidas.TabIndex = 14;
            this.btnEntradasVendidas.Text = "Entradas vendidas por tipo de espectador";
            this.btnEntradasVendidas.UseVisualStyleBackColor = true;
            this.btnEntradasVendidas.Click += new System.EventHandler(this.btnEntradasVendidas_Click);
            // 
            // btnCantidadVentas
            // 
            this.btnCantidadVentas.FlatAppearance.BorderSize = 0;
            this.btnCantidadVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.btnCantidadVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCantidadVentas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadVentas.ForeColor = System.Drawing.Color.Black;
            this.btnCantidadVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCantidadVentas.Location = new System.Drawing.Point(127, 267);
            this.btnCantidadVentas.Name = "btnCantidadVentas";
            this.btnCantidadVentas.Size = new System.Drawing.Size(332, 30);
            this.btnCantidadVentas.TabIndex = 13;
            this.btnCantidadVentas.Text = "Cantidad ventas a clientes por año";
            this.btnCantidadVentas.UseVisualStyleBackColor = true;
            this.btnCantidadVentas.Click += new System.EventHandler(this.btnCantidadVentas_Click);
            // 
            // picLogoFondo
            // 
            this.picLogoFondo.Image = global::CinesGarayConsultas.Properties.Resources.LogoCinesReportes;
            this.picLogoFondo.Location = new System.Drawing.Point(101, 12);
            this.picLogoFondo.Name = "picLogoFondo";
            this.picLogoFondo.Size = new System.Drawing.Size(396, 342);
            this.picLogoFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoFondo.TabIndex = 2;
            this.picLogoFondo.TabStop = false;
            // 
            // frmGeneralVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.panelContenedorClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneralVentas";
            this.Text = "frmGeneralVentas";
            this.panelContenedorClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorClientes;
        private System.Windows.Forms.Button btnEntradasVendidas;
        private System.Windows.Forms.Button btnCantidadVentas;
        private System.Windows.Forms.PictureBox picLogoFondo;
    }
}