using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class N_Ruta
    {
        CapaDatos.D_Ruta _Ruta = new CapaDatos.D_Ruta();

        public int Guardar(CapaEntidad.E_Ruta ruta)
        {
            int res = 0;
            if (ruta.ID == 0)
            {
                res = _Ruta.Insertar(ruta);
            }
            {
                res = _Ruta.Editar(ruta);
            }
            return res;  
        }

        public int Eliminar(CapaEntidad.E_Ruta ruta)
        {
            return _Ruta.Eliminar(ruta);
        }
        public DataTable ListarDisponibles()
        {
            return _Ruta.Listar_Disponibles();
        }

        public DataTable Listar()
        {
            return _Ruta.Listar();
        }
    }

}
