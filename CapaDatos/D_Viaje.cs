using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class D_Viaje
    {
        private Acceso acceso = new Acceso();

        public List<CapaEntidad.E_Viaje_Modelo> Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_VIAJES");
            List<CapaEntidad.E_Viaje_Modelo> viajes = new List<CapaEntidad.E_Viaje_Modelo>();

            foreach (DataRow registro in tabla.Rows)
            {
                int ID = int.Parse(registro["ID"].ToString());
                int ID_Chofer = int.Parse(registro["ID_C"].ToString());
                int ID_Autobus = int.Parse(registro["ID_A"].ToString());
                int ID_Ruta = int.Parse(registro["ID_R"].ToString());
                string Chofer = registro["CHOFER"].ToString();
                string Cedula = registro["CEDULA"].ToString();
                string Autobus_marca = registro["MARCA AUTOBUS"].ToString();
                string modelo_Autobus = registro["MODELO AUTOBUS"].ToString();
                string placa_Aut = registro["PLACA AUTOBUS"].ToString();
                string Ruta = registro["RUTA"].ToString();
                string Distancia = registro["DISTACIA"].ToString();
                CapaEntidad.E_Viaje_Modelo viaje = new CapaEntidad.E_Viaje_Modelo(ID, ID_Chofer, ID_Autobus, ID_Ruta, Chofer, Cedula, Autobus_marca, modelo_Autobus, placa_Aut, Ruta, Distancia);
                viajes.Add(viaje);
            }

            return viajes;
        }
        public int Insertar(CapaEntidad.E_Viaje viaje)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID_CHOFER", viaje.ID_CHOFER));
            parametros.Add(acceso.CrearParametro("@ID_AUTOBUS", viaje.ID_AUTOBUS));
            parametros.Add(acceso.CrearParametro("@ID_RUTA", viaje.ID_RUTA));

            return acceso.Escribir("SP_INSERTAR_VIAJE", parametros);
        }
        public int Editar(CapaEntidad.E_Viaje viaje)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", viaje.ID));
            parametros.Add(acceso.CrearParametro("@ID_CHOFER", viaje.ID_CHOFER));
            parametros.Add(acceso.CrearParametro("@ID_AUTOBUS", viaje.ID_AUTOBUS));
            parametros.Add(acceso.CrearParametro("@ID_RUTA", viaje.ID_RUTA));

            return acceso.Escribir("SP_EDITAR_VIAJE", parametros);
        }
        public int Eliminar(CapaEntidad.E_Viaje viaje)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", viaje.ID));

            return acceso.Escribir("SP_ELIMINAR_VIAJE", parametros);
        }

    }
}
