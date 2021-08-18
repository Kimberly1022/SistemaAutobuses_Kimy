using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
   public class N_Chofer
    {
        CapaDatos.D_Chofer _Chofer = new CapaDatos.D_Chofer();

        public int Guardar(CapaEntidad.E_Chofer chofer)
        {
            int res = 0;
            if (chofer.ID == 0)
            {
                res = _Chofer.Insertar(chofer);
            }
            {
                res = _Chofer.Editar(chofer);
            }
            return res;
        }

        public int Eliminar(CapaEntidad.E_Chofer chofer)
        {
            return _Chofer.Eliminar(chofer);
        }

        public DataTable ListarDisponibles()
        {
            return _Chofer.Listar_Disponibles();
        }

        public DataTable Listar()
        {
            return _Chofer.Listar();
        }
    }
}
