using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_de_sistema : Form
    {
        public Frm_de_sistema()
        {
            InitializeComponent();
        }

        private void buttonChoferes_Click(object sender, EventArgs e)
        {

            Form Frm_de_choferes = new Frm_de_choferes();
            Frm_de_choferes.Show();

        }

        private void buttonAutobuses_Click(object sender, EventArgs e)
        {
            Form Frm_de_autobuses = new Frm_de_autobuses();
            Frm_de_autobuses.Show();
        }

        private void buttonRutas_Click(object sender, EventArgs e)
        {
            Form Frm_de_rutas = new Frm_de_rutas();
            Frm_de_rutas.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
