using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class D_Autobus
    {
        private Acceso acceso = new Acceso();

        public DataTable Listar_Disponibles()
        {
            DataTable tabla = acceso.Leer("SP_LST_AUTOBUSES_DISPONIBLES");
            return tabla;
        }

        public DataTable Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_AUTOBUSES");
            return tabla;
        }

        public int Insertar(CapaEntidad.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@MARCA", autobus.MARCA));
            parametros.Add(acceso.CrearParametro("@MODELO", autobus.MODELO));
            parametros.Add(acceso.CrearParametro("@PLACA", autobus.PLACA));
            parametros.Add(acceso.CrearParametro("@COLOR", autobus.COLOR));
            parametros.Add(acceso.CrearParametro("@ANIO", autobus.ANIO));

            return acceso.Escribir("SP_INSERTAR_AUTOBUS", parametros);
        }
        public int Editar(CapaEntidad.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", autobus.ID));
            parametros.Add(acceso.CrearParametro("@MARCA", autobus.MARCA));
            parametros.Add(acceso.CrearParametro("@MODELO", autobus.MODELO));
            parametros.Add(acceso.CrearParametro("@PLACA", autobus.PLACA));
            parametros.Add(acceso.CrearParametro("@COLOR", autobus.COLOR));
            parametros.Add(acceso.CrearParametro("@ANIO", autobus.ANIO));

            return acceso.Escribir("SP_EDITAR_AUTOBUS", parametros);
        }
        public int Eliminar(CapaEntidad.E_Autobus autobus)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", autobus.ID));

            return acceso.Escribir("SP_ELIMINAR_AUTOBUS", parametros);
        }
    }
}
