using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesGarayConsultas
{
    public partial class frmGeneralPelis : Form
    {
        public frmGeneralPelis()
        {
            InitializeComponent();
        }

        private void frmGeneralPelis_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedorClientes.Controls.Count > 0)
                this.panelContenedorClientes.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorClientes.Controls.Add(fh);
            this.panelContenedorClientes.Tag = fh;
            fh.Show();
            btnDuracion.Visible = false;
            btnDirectoresQueSonActores.Visible = false;
            btnCantidadActuaciones.Visible = false;
            btnActoresPelisxGenero.Visible = false;
            picturePuru.Visible = false;
            picturePuru2.Visible = false;
            btnCantidadPelisAñoGenero.Visible = false;
            btnActoresPelisATP.Visible = false;
        }

        private void btnDuracion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmDuracion());
        }

        private void btnCantidadActuaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmCantidadActuaciones());
        }

        private void btnActoresPelisxGenero_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmListadoActoresYPelisxGenero());
        }

        private void btnDirectoresQueSonActores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmDirectoresQueSonActores());
        }

        private void panelContenedorClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCantidadPelisAñoGenero_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmPelisxAñoxGenero());
        }

        private void btnActoresPelisATP_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmActoresPelisATP());
        }
    }
}
