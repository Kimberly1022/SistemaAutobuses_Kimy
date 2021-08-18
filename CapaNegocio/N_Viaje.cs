using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class N_Viaje
    {
        CapaDatos.D_Viaje _Viaje = new CapaDatos.D_Viaje();

        public int Guardar(CapaEntidad.E_Viaje viaje)
        {
            int res = 0;
            if (viaje.ID == 0)
            {
                res = _Viaje.Insertar(viaje);
            }
            {
                res = _Viaje.Editar(viaje);
            }
            return res;
        }

        public int Eliminar(CapaEntidad.E_Viaje viaje)
        {
            return _Viaje.Eliminar(viaje);
        }

        public List<CapaEntidad.E_Viaje_Modelo> Listar()
        {
            return _Viaje.Listar();
        }
    }
}

