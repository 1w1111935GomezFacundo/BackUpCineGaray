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
    public partial class frmConsultaClientes : Form
    {
        Datos d = new Datos();
        string procSQL;
        int[] aMes = new int[12];
        int[] aAño = new int[21];
        public frmConsultaClientes()
        {
            InitializeComponent();
            int a = 1;
            for (int i = 0; i < 12; i++)
            {
                aMes[i] = a;
                a++;
            }
            a = 2000;
            for (int i = 0; i < 21; i++)
            {
                aAño[i] = a;
                a++;
            }

        }

        private void cboAñoMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboDatoAñoMes.Items.Clear();
            if (cboAñoMes.SelectedIndex == 1)
                for (int i = 0; i < 12; i++)
                {
                    cboDatoAñoMes.Items.Add(aMes[i]);
                }
            else if (cboAñoMes.SelectedIndex == 0)
                for (int i = 0; i < 21; i++)
                {
                    cboDatoAñoMes.Items.Add(aAño[i]);
                }

        }

        public void MostrarClientes(string anyAll, string añoMes, int dato)
        {

            procSQL = "pa_clientes_que_vinieron " + "'" + anyAll + "','" + añoMes + "'," + dato;
            DataTable t = new DataTable();
            t = d.leerProc(procSQL);
            dgvClientes.DataSource = t;
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            string anyAll = "";
            string añoMes = "";
            if (cboAnyAll.SelectedIndex == 0)
                anyAll = "any";
            else
                anyAll = "all";
            if (cboAñoMes.SelectedIndex == 0)
                añoMes = "año";
            else
                añoMes = "mes";
            MostrarClientes(anyAll,añoMes, Convert.ToInt32(cboDatoAñoMes.SelectedItem));
            cboDatoAñoMes.SelectedIndex = -1;
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            cboAnyAll.SelectedIndex = 0;
            cboAñoMes.SelectedIndex = 0;
        }
    }
}
