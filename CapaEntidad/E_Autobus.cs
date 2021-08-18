using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class E_Autobus
    {
        private int _ID;
        private string _MARCA;
        private string _MODELO;
        private string _PLACA;
        private string _COLOR;
        private string _ANIO;

        public E_Autobus(int iD, string mARCA, string mODELO, string pLACA, string cOLOR, string aNIO)
        {
            ID = iD;
            MARCA = mARCA;
            MODELO = mODELO;
            PLACA = pLACA;
            COLOR = cOLOR;
            ANIO = aNIO;
        }

        public E_Autobus(int iD)
        {
            ID = iD;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string ANIO { get => _ANIO; set => _ANIO = value; }
        
    }
}
