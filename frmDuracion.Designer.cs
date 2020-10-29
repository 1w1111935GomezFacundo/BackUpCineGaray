namespace CinesGarayConsultas
{
    partial class frmDuracion
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
            this.cmbDuracionPeli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDuracionPelis = new System.Windows.Forms.DataGridView();
            this.btnConsultarPeli = new System.Windows.Forms.Button();
            this.panelTopClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuracionPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopClientes
            // 
            this.panelTopClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopClientes.Controls.Add(this.cmbDuracionPeli);
            this.panelTopClientes.Controls.Add(this.label3);
            this.panelTopClientes.Controls.Add(this.label2);
            this.panelTopClientes.Controls.Add(this.label1);
            this.panelTopClientes.Location = new System.Drawing.Point(-5, 0);
            this.panelTopClientes.Name = "panelTopClientes";
            this.panelTopClientes.Size = new System.Drawing.Size(627, 81);
            this.panelTopClientes.TabIndex = 21;
            // 
            // cmbDuracionPeli
            // 
            this.cmbDuracionPeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuracionPeli.FormattingEnabled = true;
            this.cmbDuracionPeli.Items.AddRange(new object[] {
            "MAYOR",
            "MENOR"});
            this.cmbDuracionPeli.Location = new System.Drawing.Point(227, 39);
            this.cmbDuracionPeli.Name = "cmbDuracionPeli";
            this.cmbDuracionPeli.Size = new System.Drawing.Size(113, 21);
            this.cmbDuracionPeli.TabIndex = 1;
            this.cmbDuracionPeli.SelectedIndexChanged += new System.EventHandler(this.cmbDuracionPeli_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(346, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "al promedio de duracion gen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "cuando la misma sea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar la duración promedio de las películas por director";
            // 
            // dgvDuracionPelis
            // 
            this.dgvDuracionPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuracionPelis.Location = new System.Drawing.Point(121, 114);
            this.dgvDuracionPelis.Name = "dgvDuracionPelis";
            this.dgvDuracionPelis.Size = new System.Drawing.Size(349, 260);
            this.dgvDuracionPelis.TabIndex = 22;
            // 
            // btnConsultarPeli
            // 
            this.btnConsultarPeli.Location = new System.Drawing.Point(497, 239);
            this.btnConsultarPeli.Name = "btnConsultarPeli";
            this.btnConsultarPeli.Size = new System.Drawing.Size(90, 33);
            this.btnConsultarPeli.TabIndex = 23;
            this.btnConsultarPeli.Text = "Ver";
            this.btnConsultarPeli.UseVisualStyleBackColor = true;
            this.btnConsultarPeli.Click += new System.EventHandler(this.btnConsultarPeli_Click);
            // 
            // frmDuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.btnConsultarPeli);
            this.Controls.Add(this.dgvDuracionPelis);
            this.Controls.Add(this.panelTopClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDuracion";
            this.Text = "frmDuracion";
            this.Load += new System.EventHandler(this.frmDuracion_Load);
            this.panelTopClientes.ResumeLayout(false);
            this.panelTopClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuracionPelis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDuracionPeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDuracionPelis;
        private System.Windows.Forms.Button btnConsultarPeli;
    }
}