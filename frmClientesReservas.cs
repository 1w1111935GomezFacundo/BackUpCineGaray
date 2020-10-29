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
    public partial class frmClientesReservas : Form
    {
        Datos d = new Datos();
        int cc;
        int ff;
        Button[,] aButacas = new Button[8,8];
        String[] aFilas = new string[8];
        int[] aNroButacas = new int[8];
        string procSQL;
        public frmClientesReservas()
        {
            InitializeComponent();
            cc = ff = 0;
            for (int i = 0; i < 8; i++)
            {
                aFilas[i] = "";
            }
            for (int i = 0; i < 8; i++)
            {
                aNroButacas[i] = 0;
            }

            //FILA A
            aButacas[0, 0] = butaca1;
            aButacas[0, 1] = butaca2;
            aButacas[0, 2] = butaca3;
            aButacas[0, 3] = butaca4;
            aButacas[0, 4] = butaca5;
            aButacas[0, 5] = butaca6;
            aButacas[0, 6] = butaca5;
            aButacas[0, 7] = butaca6;

            //FILA B
            aButacas[1, 0] = butaca9;
            aButacas[1, 1] = butaca10;
            aButacas[1, 2] = butaca11;
            aButacas[1, 3] = butaca12;
            aButacas[1, 4] = butaca7;
            aButacas[1, 5] = butaca8;
            aButacas[1, 6] = butaca15;
            aButacas[1, 7] = butaca16;
        }

        private void frmConsultaReservasClientes_Load(object sender, EventArgs e)
        {
            dtpAño.CustomFormat = "yyyy";
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            MostrarReservasClientes();

        }

        private void MostrarReservasClientes()
        {
            procSQL = "pa_clientes_reservas @año = 2019, @filaA = 'A', @filaB = 'B', @nro5 = 5, @nro6 = 6, @nro7 = 7, @nro1 = 1";
            DataTable t = new DataTable();
            t = d.leerProc(procSQL);
            dgvReservasClientes.DataSource = t;
        }
        private void ButacaSeleccionada(int fila, int columna)
        {
            aButacas[fila,columna].Image = Image.FromFile(@"imagenes/seleccionado16x16.png");
        }

        private void butaca1_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 0);
            aFilas[0] = "A";
            aNroButacas[0] = 1;
        }

        private void butaca2_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 1);
            aFilas[0] = "A";
            aNroButacas[1] = 2;
        }

        private void butaca3_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 2);
            aFilas[0] = "A";
            aNroButacas[2] = 3;
        }

        private void butaca4_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 3);
            aFilas[0] = "A";
            aNroButacas[3] = 4;
        }

        private void butaca5_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 4);
            aFilas[0] = "A";
            aNroButacas[4] = 5;
        }

        private void butaca6_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 5);
            aFilas[0] = "A";
            aNroButacas[5] = 6;
        }

        private void butaca7_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 6);
            aFilas[0] = "A";
            aNroButacas[6] = 7;
        }

        private void butaca8_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(0, 7);
            aFilas[0] = "A";
            aNroButacas[7] = 8;
        }

        private void butaca9_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 0);
            aFilas[1] = "B";
            aNroButacas[0] = 1;
        }

        private void butaca10_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 1);
            aFilas[1] = "B";
            aNroButacas[1] = 2;
        }

        private void butaca11_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 2);
            aFilas[1] = "B";
            aNroButacas[2] = 3;
        }

        private void butaca12_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 3);
            aFilas[1] = "B";
            aNroButacas[3] = 4;
        }

        private void butaca13_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 4);
            aFilas[1] = "B";
            aNroButacas[4] = 5;
        }

        private void butaca14_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 5);
            aFilas[1] = "B";
            aNroButacas[5] = 6;
        }

        private void butaca15_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 6);
            aFilas[1] = "B";
            aNroButacas[6] = 7;
        }

        private void butaca16_Click(object sender, EventArgs e)
        {
            ButacaSeleccionada(1, 7);
            aFilas[1] = "B";
            aNroButacas[7] = 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
