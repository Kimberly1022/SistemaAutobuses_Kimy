using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class E_Autobus_Modelo
   {
        private int _ID;
        private string _AUTOBUS;
        private string _PLACA;
        private string _COLOR;
        private string _ANIO;

        public E_Autobus_Modelo(int iD, string aUTOBUS, string pLACA, string cOLOR, string aNIO)
        {
            ID = iD;
            AUTOBUS = aUTOBUS;
            PLACA = pLACA;
            COLOR = cOLOR;
            ANIO = aNIO;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string AUTOBUS { get => _AUTOBUS; set => _AUTOBUS = value; }
        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string ANIO { get => _ANIO; set => _ANIO = value; }
    }
}

