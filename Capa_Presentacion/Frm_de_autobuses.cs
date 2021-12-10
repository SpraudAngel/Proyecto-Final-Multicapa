using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Capa_Presentacion
{
    public partial class Frm_de_autobuses : Form
    {
        SqlConnection Conexion = new SqlConnection(@"Server=MSI\SQLEXPRESS;Database=SISTEMA_AUTOBUSES;Trusted_Connection=True");
        public Frm_de_autobuses()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Frm_de_autobuses_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMA_AUTOBUSESDataSet1.AUTOBUSES' Puede moverla o quitarla según sea necesario.
            this.aUTOBUSESTableAdapter.Fill(this.sISTEMA_AUTOBUSESDataSet1.AUTOBUSES);

        }

        private void buttonBuscarAutobuses_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdAutobus = textBoxIdAutobus.Text;
            string MarcaAutobus = textBoxMarcaAutobus.Text;
            string ModeloAutobus = textBoxModeloAutobus.Text;
            string MatriculaAutobus = textBoxMatriculaAutobus.Text;
            string ColorAutobus = textBoxColorAutobus.Text;
            string AnoAutobus = textBoxAnoAutobus.Text;

            string query = "select NOMBRE_CHOFER FROM  CHOFERES WHERE ID_CHOFER =" + IdAutobus;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha encontrado el Autobus");
            textBoxIdAutobus.Text = "";
            textBoxMarcaAutobus.Text = "";
            textBoxModeloAutobus.Text = "";
            textBoxMatriculaAutobus.Text = "";
            textBoxColorAutobus.Text = "";
            textBoxAnoAutobus.Text = "";
        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }

        private void buttonEliminarAutobuses_Click(object sender, EventArgs e)
        {

            Conexion.Open();
            string IdAutobus = textBoxIdAutobus.Text;
            string MarcaAutobus = textBoxMarcaAutobus.Text;
            string ModeloAutobus = textBoxModeloAutobus.Text;
            string MatriculaAutobus = textBoxMatriculaAutobus.Text;
            string ColorAutobus = textBoxColorAutobus.Text;
            string AnoAutobus = textBoxAnoAutobus.Text;

            string query = "DELETE FROM AUTOBUSES WHERE ID_AUTOBUS =" + IdAutobus;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado el Autobus");
            textBoxIdAutobus.Text = "";
            textBoxMarcaAutobus.Text = "";
            textBoxModeloAutobus.Text = "";
            textBoxMatriculaAutobus.Text = "";
            textBoxColorAutobus.Text = "";
            textBoxAnoAutobus.Text = "";
        }

     

        private void buttonInsertarAutobuses_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdAutobus = textBoxIdAutobus.Text;
            string MarcaAutobus = textBoxMarcaAutobus.Text;
            string ModeloAutobus = textBoxModeloAutobus.Text;
            string MatriculaAutobus = textBoxMatriculaAutobus.Text;
            string ColorAutobus = textBoxColorAutobus.Text;
            string AnoAutobus = textBoxAnoAutobus.Text;

            string query = "insert into AUTOBUSES (MARCA_AUTOBUS,MODELO_AUTOBUS,MATRICULA_AUTOBUS,COLOR_AUTOBUS,ANO_AUTOBUS) values ('" + MarcaAutobus + "','" + ModeloAutobus + "','" + MatriculaAutobus + "','" + ColorAutobus + "','" + AnoAutobus + "') ";
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBoxIdAutobus.Text= "";
            textBoxMarcaAutobus.Text= "";
            textBoxModeloAutobus.Text= "";
            textBoxMatriculaAutobus.Text = "";
            textBoxColorAutobus.Text = "";
            textBoxAnoAutobus.Text = "";
        }
    }
}
