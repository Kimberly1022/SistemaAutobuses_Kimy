using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Administrar_Viajes : Form
    {
        private CapaNegocio.N_Viaje _Viaje = new CapaNegocio.N_Viaje();
        private CapaNegocio.N_Autobus _Autobus = new CapaNegocio.N_Autobus();
        private CapaNegocio.N_Chofer _Chofer = new CapaNegocio.N_Chofer();
        private CapaNegocio.N_Ruta _Ruta = new CapaNegocio.N_Ruta();
      
        public Administrar_Viajes()
        {
            InitializeComponent();
        }
        private void Administrar_Viajes_Load(object sender, EventArgs e)
        {
            ListarViajes();
            LlenarComboBox();
        }

        public void ListarViajes()
        {
            try
            {
                dataGridView1.DataSource = _Viaje.Listar();

                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
            }
            catch (Exception E)
            {

                MessageBox.Show(E.ToString());

            }
        }

        public void LlenarComboBox()
        {
            try
            {
                DataTable Choferes = _Chofer.ListarDisponibles();
                cbxChofer.DataSource = Choferes;
                cbxChofer.DisplayMember = "NOMBRE COMPLETO";
                cbxChofer.ValueMember = "ID";

                DataTable Autobus = _Autobus.ListarDisponibles();
                cbxAutobus.DataSource = Autobus;
                cbxAutobus.DisplayMember = "AUTOBUS";
                cbxAutobus.ValueMember = "ID";

                DataTable Rutas = _Ruta.ListarDisponibles();
                cbxRuta.DataSource = Rutas;
                cbxRuta.DisplayMember = "RUTA";
                cbxRuta.ValueMember = "ID";
            }
            catch (Exception E)
            {

                MessageBox.Show(E.ToString());

            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "0";
            cbxChofer.Text = "";
            cbxAutobus.Text = "";
            cbxRuta.Text = "";

            LlenarComboBox();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cbxChofer.DataSource = _Chofer.Listar();
                cbxChofer.DisplayMember = "NOMBRE";
                cbxChofer.ValueMember = "ID";

                cbxAutobus.DataSource = _Autobus.Listar();
                cbxAutobus.DisplayMember = "MARCA";
                cbxAutobus.ValueMember = "ID";

                cbxRuta.DataSource = _Ruta.Listar();
                cbxRuta.DisplayMember = "NOMBRE";
                cbxRuta.ValueMember = "ID";

                txt_ID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                cbxChofer.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                cbxAutobus.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                cbxRuta.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editarla");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                CapaEntidad.E_Viaje e_Viaje = new CapaEntidad.E_Viaje(ID);
                _Viaje.Eliminar(e_Viaje);
                MessageBox.Show("Se ha Eliminado el Viaje");
                ListarViajes();
                LlenarComboBox();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para eliminarla");

            }
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidad.E_Viaje e_Viaje = new CapaEntidad.E_Viaje(int.Parse(txt_ID.Text), Convert.ToInt32(cbxChofer.SelectedValue),
                    Convert.ToInt32(cbxAutobus.SelectedValue),Convert.ToInt32(cbxRuta.SelectedValue));
                _Viaje.Guardar(e_Viaje);
                MessageBox.Show("¡Se ha Guardado el Viaje Exitosamente!");
                ListarViajes();
                LlenarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
