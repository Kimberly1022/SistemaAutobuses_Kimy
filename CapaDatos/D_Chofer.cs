using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Chofer
    {
        private Acceso acceso = new Acceso();  
        public DataTable Listar_Disponibles()
        {
            DataTable tabla = acceso.Leer("SP_LST_CHOFERES_DISPONIBLES");
            return tabla;
        }

        public DataTable Listar()
        {
            DataTable tabla = acceso.Leer("SP_LISTAR_CHOFER");
            return tabla;
        }

        public int Insertar(CapaEntidad.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();   
            parametros.Add(acceso.CrearParametro("@NOMBRE", chofer.NOMBRE));
            parametros.Add(acceso.CrearParametro("@APELLIDO", chofer.APELLIDO));
            parametros.Add(acceso.CrearParametro("@FECHA_NACIMIENTO", chofer.FECHA_NACIMIENTO));
            parametros.Add(acceso.CrearParametro("@CEDULA", chofer.CEDULA));

            return acceso.Escribir("SP_INSERTAR_CHOFER", parametros);
        }

        public int Editar(CapaEntidad.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", chofer.ID));
            parametros.Add(acceso.CrearParametro("@NOMBRE", chofer.NOMBRE));
            parametros.Add(acceso.CrearParametro("@APELLIDO", chofer.APELLIDO));
            parametros.Add(acceso.CrearParametro("@FECHA_NACIMIENTO", chofer.FECHA_NACIMIENTO));
            parametros.Add(acceso.CrearParametro("@CEDULA", chofer.CEDULA));

            return acceso.Escribir("SP_EDITAR_CHOFER", parametros);

        }

        public int Eliminar(CapaEntidad.E_Chofer chofer)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", chofer.ID));

            return acceso.Escribir("SP_ELIMINAR_CHOFER", parametros);
        }
       

    }
}
