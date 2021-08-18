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

    public partial class Administrar_Autobus : Form

    {
        private N_Autobus Autobus = new N_Autobus();

        public Administrar_Autobus()
        {
            InitializeComponent();
        }

        public void ListarAutobuses()
        {
            try
            {
                dataGridView1.DataSource = Autobus.Listar();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.ToString());
             
            }
        }

        private void Administrar_Autobus_Load(object sender, EventArgs e)
        {
            ListarAutobuses();
        }
        
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "0";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Placa.Text = "";
            txt_Color.Text = "";
            txt_Anio.Text = "";
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_ID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txt_Marca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_Modelo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Placa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_Color.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_Anio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
                CapaEntidad.E_Autobus e_Autobus = new CapaEntidad.E_Autobus(ID);               
                Autobus.Eliminar(e_Autobus);
                MessageBox.Show("Se ha Eliminado el Autobus Correctamente");
                ListarAutobuses();
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
                CapaEntidad.E_Autobus e_Autobus = new CapaEntidad.E_Autobus(int.Parse(txt_ID.Text), txt_Marca.Text, txt_Modelo.Text, txt_Placa.Text, txt_Color.Text, txt_Anio.Text);
                Autobus.Guardar(e_Autobus);
                MessageBox.Show("¡Se ha Guardado el Autobus Correctamente!");
                ListarAutobuses();
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

