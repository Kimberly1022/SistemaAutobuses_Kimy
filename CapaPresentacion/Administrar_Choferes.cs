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
    public partial class Administrar_Choferes : Form
    {
        private N_Chofer Chofer = new N_Chofer();
    
        public Administrar_Choferes()
        {
            InitializeComponent();
        }
   
        public void ListarChoferes()
        {
            try
            {
                dataGridView1.DataSource = Chofer.Listar();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void Administrar_Choferes_Load(object sender, EventArgs e)
        {
            ListarChoferes();
        }

       private void btn_Reset_Click(object sender, EventArgs e)
       {
            txt_ID.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
       }
       private void btn_Editar_Click(object sender, EventArgs e)
       {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_ID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateFecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                txtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();            

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para poder editarla ");
            }
       }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                CapaEntidad.E_Chofer e_Chofer = new CapaEntidad.E_Chofer(ID);
                Chofer.Eliminar(e_Chofer);
                MessageBox.Show("Se ha Eliminado el Chofer Correctamente");
                ListarChoferes();
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
                CapaEntidad.E_Chofer e_Chofer = new CapaEntidad.E_Chofer(int.Parse(txt_ID.Text), txtNombre.Text, txtApellido.Text, dateFecha.Value.Date, txtCedula.Text);
                Chofer.Guardar(e_Chofer);
                MessageBox.Show("¡Se ha guardado el Chofer Correctamente!");
                ListarChoferes();
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
