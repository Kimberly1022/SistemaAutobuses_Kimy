using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    internal class Acceso
    {
        private SqlConnection conexion;
        private void Abrir()
        {
            conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=SISTEMA_AUTOBUSES; Integrated Security= True ");
            conexion.Open();
        }

        private void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string nombre, List<SqlParameter> parametros)
        {
            parametros = new List<SqlParameter>(parametros);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;
            if (parametros.Count > 0)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            return comando;
        }

        private SqlCommand CrearComando(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;
            
            return comando;
        }

        public DataTable Leer(string nombre)
        {
            Abrir();

            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = CrearComando(nombre);

            adaptador.Fill(tabla);

            adaptador = null;
            Cerrar();

            return tabla;
        }

        public int Escribir(string nombre, List<SqlParameter> parametros)
        {
            int filasAfectadas = 0;
            Abrir();
            SqlCommand comando = CrearComando(nombre, parametros);

            try
            {
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                filasAfectadas = -1;
                MessageBox.Show(ex.ToString());
            }

            Cerrar();
            return filasAfectadas;

        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.DateTime;
            return parametro;
        }
    }
}
