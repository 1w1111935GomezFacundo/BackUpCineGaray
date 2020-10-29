using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CinesGarayConsultas
{
    class Datos
    {
        OleDbConnection miConexion;
        OleDbCommand miComando;
        OleDbDataReader lector;
        string miCadena;
        OleDbCommand miProc;

        public Datos()
        {
            miConexion = new OleDbConnection();
            miComando = new OleDbCommand();
            miProc = new OleDbCommand();
            miCadena = null;
            lector = null;
        }

        public Datos(string miCadena)
        {

            miConexion = new OleDbConnection(miCadena);
            miComando = new OleDbCommand();
            miProc = new OleDbCommand();
            lector = null;
        }

        public OleDbDataReader pLector { get => lector; set => lector = value; }
        public string pMiCadena { get => miCadena; set => miCadena = value; }

        public void conectar()
        {
            miConexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BorradorCineGARAY";
            miConexion.Open();
            miComando.Connection = miConexion;
            miProc.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miProc.CommandType = CommandType.StoredProcedure;
        }

        public void desconectar()
        {
            miConexion.Close();
            miConexion.Dispose();
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            miComando.CommandText = "select * from " + nombreTabla;
            lector = miComando.ExecuteReader();
        }
        public DataTable leerProc(string procSQL)
        {
            conectar();
            DataTable tabla = new DataTable();
            miComando.CommandText = "exec " + procSQL;
            tabla.Load(miComando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable cargarTabla(string nombreTabla)
        {
            conectar();
            DataTable tabla = new DataTable();
            miComando.CommandText = "select * from " + nombreTabla;
            tabla.Load(miComando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void actualizar(string consultaSQL)
        {
            conectar();
            miComando.CommandText = consultaSQL;
            miComando.ExecuteNonQuery();
            desconectar();
        }
    }
}
