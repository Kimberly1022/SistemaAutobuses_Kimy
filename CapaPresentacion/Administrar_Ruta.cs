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
    public partial class Administrar_Ruta : Form
    {

        private N_Ruta Ruta = new N_Ruta();
        public Administrar_Ruta()
        {
            InitializeComponent();
        }
        public void ListarRutas()
        {
            try
            {
                dataGridView1.DataSource = Ruta.Listar();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }
     
        private void Administrar_Ruta_Load(object sender, EventArgs e)
        {
            ListarRutas();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "0";
            txtNombre.Text = "";
            txtDistancia.Text = "";
            txtParadas.Text = "";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_ID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDistancia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtParadas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
                int ID  = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                CapaEntidad.E_Ruta e_Ruta = new CapaEntidad.E_Ruta(ID);
                Ruta.Eliminar(e_Ruta);
                MessageBox.Show("Se ha Eliminado la Ruta Corretamente");
                ListarRutas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para eliminarla");
            }

        }
        
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaEntidad.E_Ruta e_Ruta = new CapaEntidad.E_Ruta(int.Parse(txt_ID.Text), txtNombre.Text, txtDistancia.Text, int.Parse(txtParadas.Text));
                Ruta.Guardar(e_Ruta);
                MessageBox.Show("¡Se ha Guardado la Ruta Correctamente!");
                ListarRutas();
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
