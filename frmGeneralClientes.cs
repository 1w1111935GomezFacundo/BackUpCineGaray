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
    public partial class frmGeneralClientes : Form
    {
        public frmGeneralClientes()
        {
            InitializeComponent();
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
            picLogoFondo.Visible = false;
            btnConsultarVisitas.Visible = false;
            btnReservas.Visible = false;
        }


        private void btnReservas_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new frmClientesReservas());
        }

        private void btnConsultarVisitas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmClientesVisitas());

        }

        private void panelContenedorClientes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
