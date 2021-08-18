using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Chofer
    {
        private int _ID;
        private string _NOMBRE;
        private string _APELLIDO;
        private DateTime _FECHA_NACIMIENTO;
        private string _CEDULA;

        public E_Chofer(int iD, string nOMBRE, string aPELLIDO, DateTime fECHA_NACIMIENTO, string cEDULA)
        {
            ID = iD;
            NOMBRE = nOMBRE;
            APELLIDO = aPELLIDO;
            FECHA_NACIMIENTO = fECHA_NACIMIENTO;
            CEDULA = cEDULA;
        }

        public E_Chofer(int iD)
        {
            ID = iD;
        }

        public E_Chofer(int iD, string text1, string text2, (int, string Text) p) : this(iD)
        {
        }

        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public DateTime FECHA_NACIMIENTO { get => _FECHA_NACIMIENTO; set => _FECHA_NACIMIENTO = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }
    }
}
