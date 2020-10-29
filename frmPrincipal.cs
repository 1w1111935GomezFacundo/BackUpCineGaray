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
    public partial class frmPrincipal : Form
    {
        Button btnActuar;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            picLogoFondo.Visible = false;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmGeneralClientes());
            ActivarBoton(sender, RGBColors.Colorcito);
        }


        private void btnFunciones_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Colorcito);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmGeneralVentas());
            ActivarBoton(sender, RGBColors.Colorcito);
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmGeneralPelis());
            ActivarBoton(sender, RGBColors.Colorcito);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmGeneralOtros());
            ActivarBoton(sender, RGBColors.Colorcito);
        }

        private Point Posicion = Point.Empty;
        private bool move = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Posicion = new Point(e.X, e.Y);
            move = true;
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
                this.Location = new Point((this.Left + e.X - Posicion.X),(this.Top + e.Y - Posicion.Y));
        }

        //Metodos para cambiar el color de los botones de mis forms 
        private void ActivarBoton(object Botoncito,Color Colorcito)
        {
            if (Botoncito != null)
            {
                DeshabilitarBoton();
                btnActuar = (Button)Botoncito;
                btnActuar.BackColor = Color.FromArgb(255, 193, 76);
                btnActuar.ForeColor = Colorcito;
                btnActuar.TextAlign = ContentAlignment.MiddleCenter;
                btnActuar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255,193,76);
                btnActuar.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActuar.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void DeshabilitarBoton()
        {
            if (btnActuar != null)
            {
                btnActuar.BackColor = Color.FromArgb(200, 6, 27);
                btnActuar.ForeColor = Color.Black;
                btnActuar.TextAlign = ContentAlignment.MiddleLeft;
                btnActuar.FlatAppearance.MouseOverBackColor = Color.Black;
                btnActuar.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActuar.ImageAlign = ContentAlignment.MiddleLeft;
               
            }
        }

        private struct RGBColors
        {
            public static Color Colorcito = Color.FromArgb(0, 0, 0);
        }

    }
}
