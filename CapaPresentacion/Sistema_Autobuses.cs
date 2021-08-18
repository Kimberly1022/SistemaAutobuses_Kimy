using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Sistema_Autobuses : Form
    {
        public Sistema_Autobuses()
        {
            InitializeComponent();
        }

        private void Sistema_Autobuses_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Conexión Exitosa!");
        }

        private void btnAdministrarChoferes_Click(object sender, EventArgs e)
        {
            Administrar_Choferes administrar_Choferes = new Administrar_Choferes();
            administrar_Choferes.ShowDialog();
        }

        private void btnAdministrarAutobuses_Click(object sender, EventArgs e)
        {
            Administrar_Autobus Autobuses = new Administrar_Autobus();

            Autobuses.ShowDialog();

        }

        private void btnAdministrarRutas_Click(object sender, EventArgs e)
        {
            Administrar_Ruta administrar_Ruta = new Administrar_Ruta();
            administrar_Ruta.ShowDialog();
        }

        private void btnAdministrarViajes_Click(object sender, EventArgs e)
        {
            Administrar_Viajes administrar_Viajes = new Administrar_Viajes();
            administrar_Viajes.ShowDialog();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"¿Esta seguro que desea salir del sistema?", @"¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
