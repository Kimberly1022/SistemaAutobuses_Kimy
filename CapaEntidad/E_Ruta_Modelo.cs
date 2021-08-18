using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Ruta_Modelo
    {
        private int _ID;
        private string _RUTA;
        private int _PARADAS;

        public E_Ruta_Modelo(int iD, string rUTA, int pARADAS)
        {
            ID = iD;
            RUTA = rUTA;
            PARADAS = pARADAS;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string RUTA { get => _RUTA; set => _RUTA = value; }
        public int PARADAS { get => _PARADAS; set => _PARADAS = value; }
    }
}
