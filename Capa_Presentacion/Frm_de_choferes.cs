using Capa_de_entidad;
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
    public partial class Frm_de_choferes : Form
    {
        SqlConnection Conexion = new SqlConnection(@"Server=MSI\SQLEXPRESS;Database=SISTEMA_AUTOBUSES;Trusted_Connection=True");
        public Frm_de_choferes()
        {
            InitializeComponent();
        }

        private void Frm_de_choferes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMA_AUTOBUSESDataSet.CHOFERES' Puede moverla o quitarla según sea necesario.
            this.cHOFERESTableAdapter.Fill(this.sISTEMA_AUTOBUSESDataSet.CHOFERES);

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void buttonInsertarChoferes_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdChofer = textBoxIdChofer.Text;
            string NombreChofer = textBoxNombreChofer.Text;
            string ApellidoChofer = textBoxApellidoChofer.Text;
            string FechaNacimientoChofer = textBox3.Text;
            string CedulaChofer = textBoxCedula.Text;

            string query = "insert into CHOFERES (NOMBRE_CHOFER,APELLIDO_CHOFER,FECHA_NACIMIENTO_CHOFER,CEDULA_CHOFER) values ('" + NombreChofer + "','" + ApellidoChofer + "','" + FechaNacimientoChofer + "','" + CedulaChofer + "') ";
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBoxIdChofer.Text = "";
            textBoxNombreChofer.Text = "";
            textBoxApellidoChofer.Text = "";
            textBox3.Text = "";
            textBoxCedula.Text = "";

          
            Conexion.Close();

        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonBuscarChoferes_Click(object sender, EventArgs e)
        {

            Conexion.Open();
            string IdChofer = textBoxIdChofer.Text;
            string NombreChofer = textBoxNombreChofer.Text;
            string ApellidoChofer = textBoxApellidoChofer.Text;
            string FechaNacimientoChofer = textBox3.Text;
            string CedulaChofer = textBoxCedula.Text;

            string query = "select NOMBRE_CHOFER FROM  CHOFERES WHERE ID_CHOFER =" + IdChofer;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha encontrado al chofer");
            textBoxIdChofer.Text = "";
            textBoxNombreChofer.Text = "";
            textBoxApellidoChofer.Text = "";
            textBox3.Text = "";
            textBoxCedula.Text = "";
        }

       

        private void buttonEliminarChofer_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string IdChofer = textBoxIdChofer.Text;
            string NombreChofer = textBoxNombreChofer.Text;
            string ApellidoChofer = textBoxApellidoChofer.Text;
            string FechaNacimientoChofer = textBox3.Text;
            string CedulaChofer = textBoxCedula.Text;

            string query = "DELETE FROM CHOFERES WHERE ID_CHOFER =" + IdChofer;
            SqlCommand cmd = new SqlCommand(query, Conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos se eliminaron exitosamente");
            textBoxIdChofer.Text = "";
            textBoxNombreChofer.Text = "";
            textBoxApellidoChofer.Text = "";
            textBox3.Text = "";
            textBoxCedula.Text = "";

           
            Conexion.Close();

        }


    }
}
