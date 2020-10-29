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
    public partial class frmDirectoresQueSonActores : Form
    {
        Datos DatosDirAct = new Datos();
        string prosSQL;

        public frmDirectoresQueSonActores()
        {
            InitializeComponent();
        }

        private void CargarComboNacionalidades(ComboBox Combo, string nombreTablita)
        {
            
            DataTable datatable = new DataTable();
            datatable = DatosDirAct.cargarTabla(nombreTablita);
            Combo.DataSource = datatable;
            Combo.ValueMember = datatable.Columns[0].ColumnName;
            Combo.DisplayMember = datatable.Columns[1].ColumnName;
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void MostrarNacionalidades(int Nacionalidad)
        {

            prosSQL = "pa_directoresActores " + Nacionalidad;
            DataTable table = new DataTable();
            table = DatosDirAct.leerProc(prosSQL);
            dgvActDirect.DataSource = table;
        }

        private void frmDirectoresQueSonActores_Load(object sender, EventArgs e)
        {
            CargarComboNacionalidades(cmbNacionalidad, "NACIONALIDADES");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MostrarNacionalidades((int)cmbNacionalidad.SelectedValue);

        }
    }
}
