using Capa_de_negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Presentacion
{
    public partial class Frm_de_rutas : Form
    {
        SqlConnection Conexion = new SqlConnection(@"Server=MSI\SQLEXPRESS;Database=SISTEMA_AUTOBUSES;Trusted_Connection=True");
        public Frm_de_rutas()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Frm_de_rutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMA_AUTOBUSESDataSet2.RUTAS' Puede moverla o quitarla según sea necesario.
            this.rUTASTableAdapter.Fill(this.sISTEMA_AUTOBUSESDataSet2.RUTAS);

        }

        private void buttonBuscarRutas_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdRuta = textBoxIdRuta.Text;
            string NombreRuta = textBoxNombreRuta.Text;
            string ComienzoRuta = textBoxComienzoRuta.Text;
            string FinRuta = textBoxFinRuta.Text;

            string query = "SELECT NOMBRE_RUTA FROM RUTAS WHERE ID_RUTA =" + IdRuta;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha encontrado la ruta");
            textBoxNombreRuta.Text = "";
            textBoxComienzoRuta.Text = "";
            textBoxFinRuta.Text = "";

            TablaRutas.Refresh();
            Conexion.Close();
            
        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void buttonInsertarRutas_Click(object sender, EventArgs e)
        {
           
            Conexion.Open();
            string IdRuta = textBoxIdRuta.Text;
            string NombreRuta = textBoxNombreRuta.Text;
            string ComienzoRuta = textBoxComienzoRuta.Text;
            string FinRuta = textBoxFinRuta.Text;

            string query = "insert into RUTAS (NOMBRE_RUTA,COMIENZO_RUTA,FIN_RUTA) values ('"+NombreRuta+"','"+ComienzoRuta+"','"+FinRuta+"') ";
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBoxNombreRuta.Text = "";
            textBoxComienzoRuta.Text = "";
            textBoxFinRuta.Text = "";

            TablaRutas.Refresh();
            Conexion.Close();
           

        }

        private void buttonEliminarRutas_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdRuta = textBoxIdRuta.Text;
            string NombreRuta = textBoxNombreRuta.Text;
            string ComienzoRuta = textBoxComienzoRuta.Text;
            string FinRuta = textBoxFinRuta.Text;

            string query = "DELETE FROM RUTAS WHERE ID_RUTA =" + IdRuta;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se eliminaron exitosamente");
            textBoxNombreRuta.Text = "";
            textBoxComienzoRuta.Text = "";
            textBoxFinRuta.Text = "";

            TablaRutas.Refresh();
            Conexion.Close();
       
        }

      
           
    }
}
