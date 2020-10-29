namespace CinesGarayConsultas
{
    partial class frmDirectoresQueSonActores
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.dgvActDirect = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTopClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDirect)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopClientes
            // 
            this.panelTopClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopClientes.Controls.Add(this.cmbNacionalidad);
            this.panelTopClientes.Controls.Add(this.label2);
            this.panelTopClientes.Controls.Add(this.label1);
            this.panelTopClientes.Location = new System.Drawing.Point(0, 0);
            this.panelTopClientes.Name = "panelTopClientes";
            this.panelTopClientes.Size = new System.Drawing.Size(655, 82);
            this.panelTopClientes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste los nombres de artistas que sean directores y actores a la vez y que hayan " +
    "nacido en America";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "hayan nacido en";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(160, 35);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbNacionalidad.TabIndex = 1;
            // 
            // dgvActDirect
            // 
            this.dgvActDirect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActDirect.Location = new System.Drawing.Point(160, 99);
            this.dgvActDirect.Name = "dgvActDirect";
            this.dgvActDirect.Size = new System.Drawing.Size(286, 244);
            this.dgvActDirect.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(477, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDirectoresQueSonActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvActDirect);
            this.Controls.Add(this.panelTopClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDirectoresQueSonActores";
            this.Text = "frmDirectoresQueSonActores";
            this.Load += new System.EventHandler(this.frmDirectoresQueSonActores_Load);
            this.panelTopClientes.ResumeLayout(false);
            this.panelTopClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDirect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvActDirect;
        private System.Windows.Forms.Button button1;
    }
}