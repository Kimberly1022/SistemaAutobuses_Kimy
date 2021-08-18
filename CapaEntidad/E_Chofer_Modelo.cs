using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Chofer_Modelo
    {
        private int _ID;
        private string _NOMBRE_COMPLETO;
        private DateTime _FECHA_NACIMIENTO;
        private string _CEDULA;

        public E_Chofer_Modelo(int iD, string nOMBRE_COMPLETO, DateTime fECHA_NACIMIENTO, string cEDULA)
        {
            ID = iD;
            NOMBRE_COMPLETO = nOMBRE_COMPLETO;
            FECHA_NACIMIENTO = fECHA_NACIMIENTO;
            CEDULA = cEDULA;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE_COMPLETO { get => _NOMBRE_COMPLETO; set => _NOMBRE_COMPLETO = value; }
        public DateTime FECHA_NACIMIENTO { get => _FECHA_NACIMIENTO; set => _FECHA_NACIMIENTO = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }
    }
}

