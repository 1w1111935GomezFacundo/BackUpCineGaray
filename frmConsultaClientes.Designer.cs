namespace CinesGarayConsultas
{
    partial class frmConsultaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panelTopClientes = new System.Windows.Forms.Panel();
            this.cboDatoAñoMes = new System.Windows.Forms.ComboBox();
            this.cboAñoMes = new System.Windows.Forms.ComboBox();
            this.cboAnyAll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelTopClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(127, 87);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(324, 277);
            this.dgvClientes.TabIndex = 5;
            // 
            // panelTopClientes
            // 
            this.panelTopClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopClientes.Controls.Add(this.cboDatoAñoMes);
            this.panelTopClientes.Controls.Add(this.cboAñoMes);
            this.panelTopClientes.Controls.Add(this.cboAnyAll);
            this.panelTopClientes.Controls.Add(this.label2);
            this.panelTopClientes.Controls.Add(this.label1);
            this.panelTopClientes.Location = new System.Drawing.Point(0, -3);
            this.panelTopClientes.Name = "panelTopClientes";
            this.panelTopClientes.Size = new System.Drawing.Size(655, 57);
            this.panelTopClientes.TabIndex = 13;
            // 
            // cboDatoAñoMes
            // 
            this.cboDatoAñoMes.FormattingEnabled = true;
            this.cboDatoAñoMes.Location = new System.Drawing.Point(512, 12);
            this.cboDatoAñoMes.Name = "cboDatoAñoMes";
            this.cboDatoAñoMes.Size = new System.Drawing.Size(84, 21);
            this.cboDatoAñoMes.TabIndex = 17;
            // 
            // cboAñoMes
            // 
            this.cboAñoMes.FormattingEnabled = true;
            this.cboAñoMes.Items.AddRange(new object[] {
            "AÑO",
            "MES"});
            this.cboAñoMes.Location = new System.Drawing.Point(435, 12);
            this.cboAñoMes.Name = "cboAñoMes";
            this.cboAñoMes.Size = new System.Drawing.Size(71, 21);
            this.cboAñoMes.TabIndex = 16;
            this.cboAñoMes.SelectedIndexChanged += new System.EventHandler(this.cboAñoMes_SelectedIndexChanged);
            // 
            // cboAnyAll
            // 
            this.cboAnyAll.FormattingEnabled = true;
            this.cboAnyAll.Items.AddRange(new object[] {
            "ALGUNA VEZ",
            "SOLAMENTE"});
            this.cboAnyAll.Location = new System.Drawing.Point(228, 12);
            this.cboAnyAll.Name = "cboAnyAll";
            this.cboAnyAll.Size = new System.Drawing.Size(98, 21);
            this.cboAnyAll.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(332, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "vinieron el";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar los clientes que";
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Location = new System.Drawing.Point(493, 225);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarClientes.TabIndex = 18;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 403);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.panelTopClientes);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaClientes";
            this.Text = "frmConsultaClientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelTopClientes.ResumeLayout(false);
            this.panelTopClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panelTopClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnyAll;
        private System.Windows.Forms.ComboBox cboAñoMes;
        private System.Windows.Forms.ComboBox cboDatoAñoMes;
        private System.Windows.Forms.Button btnConsultarClientes;
    }
}