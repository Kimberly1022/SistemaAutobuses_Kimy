using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
   public class N_Autobus
    {
        CapaDatos.D_Autobus _Autobus = new CapaDatos.D_Autobus();

        public int Guardar(CapaEntidad.E_Autobus autobus)
        {
            int res = 0;
            if (autobus.ID == 0)
            {
                res = _Autobus.Insertar(autobus);
            }
            {
                res = _Autobus.Editar(autobus);
            }
            return res;
        }

        public int Eliminar(CapaEntidad.E_Autobus autobus)
        {
            return _Autobus.Eliminar(autobus);
        }

        public DataTable ListarDisponibles()
        {
            return _Autobus.Listar_Disponibles();
        }

        public DataTable Listar()
        {
            return _Autobus.Listar();
        }
    }
}

