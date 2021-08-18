using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public  class D_Ruta
   {
        private Acceso acceso = new Acceso();

        public DataTable Listar_Disponibles()
        {
            DataTable tabla = acceso.Leer("SP_LST_RUTAS_DISPONIBLES");
            return tabla;
        }

        public DataTable Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_RUTAS");
            return tabla;
        }

        public int Insertar (CapaEntidad.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@NOMBRE", ruta.NOMBRE));
            parametros.Add(acceso.CrearParametro("@DISTANCIA", ruta.DISTANCIA));
            parametros.Add(acceso.CrearParametro("@PARADAS", ruta.PARADAS));

            return acceso.Escribir("SP_INSERTAR_RUTA", parametros);

        }

        public int Editar(CapaEntidad.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", ruta.ID));
            parametros.Add(acceso.CrearParametro("@NOMBRE", ruta.NOMBRE));
            parametros.Add(acceso.CrearParametro("@DISTANCIA", ruta.DISTANCIA));
            parametros.Add(acceso.CrearParametro("@PARADAS", ruta.PARADAS));

            return acceso.Escribir("SP_EDITAR_RUTA", parametros);
        }

        public int Eliminar(CapaEntidad.E_Ruta ruta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", ruta.ID));

            return acceso.Escribir("SP_ELIMINAR_RUTAS", parametros);

        }
    }
}
