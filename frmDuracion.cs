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
    public partial class frmDuracion : Form
    {
        Datos DatosDura = new Datos();
        string procSQL;
        string DuraMax_Min;
        public frmDuracion()
        {
            InitializeComponent();
       
    
        }

        private void frmDuracion_Load(object sender, EventArgs e)
        {
            cmbDuracionPeli.SelectedIndex = 0;
        }

        private void cmbDuracionPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDuracionPeli.SelectedIndex == 0)
                DuraMax_Min = "Mayor";
            if (cmbDuracionPeli.SelectedIndex == 1)
                DuraMax_Min = "Menor";
        }

        public void MostrarPelis(string DuraMax_Min)
        {

            procSQL = "pa_duracionPelis " + "'" + DuraMax_Min + "'"; 
            DataTable table = new DataTable();
            table = DatosDura.leerProc(procSQL);
            dgvDuracionPelis.DataSource = table;
        }

        private void btnConsultarPeli_Click(object sender, EventArgs e)
        {
            if (cmbDuracionPeli.SelectedIndex == 0)
                DuraMax_Min = "Mayor";
            if (cmbDuracionPeli.SelectedIndex == 0)
                DuraMax_Min = "Menor";
            MostrarPelis(cmbDuracionPeli.SelectedItem.ToString());
        }
    }
}
