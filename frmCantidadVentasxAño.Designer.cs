namespace CinesGarayConsultas
{
    partial class frmCantidadVentasxAño
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
            this.panelTopClientes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopClientes
            // 
            this.panelTopClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopClientes.Controls.Add(this.label1);
            this.panelTopClientes.Location = new System.Drawing.Point(0, 0);
            this.panelTopClientes.Name = "panelTopClientes";
            this.panelTopClientes.Size = new System.Drawing.Size(613, 57);
            this.panelTopClientes.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA";
            // 
            // frmCantidadVentasxAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.panelTopClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCantidadVentasxAño";
            this.Text = "frmCantidadVentasxAño";
            this.panelTopClientes.ResumeLayout(false);
            this.panelTopClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopClientes;
        private System.Windows.Forms.Label label1;
    }
}