using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Viaje_Modelo
    {

        int iD;
        int iD_Chofer;
        int iD_Autobus;
        int iD_Ruta;
        string chofer;
        string cedula;
        string autobus_Marca;
        string modelo_Autobus;
        string placa_Aut;
        string ruta;
        string distancia;

        public E_Viaje_Modelo(int iD, int iD_Chofer, int iD_Autobus, int iD_Ruta, string chofer, string cedula, string autobus_Marca, string modelo_Autobus, string placa_Aut, string ruta, string distancia)
        {
            ID = iD;
            ID_Chofer = iD_Chofer;
            ID_Autobus = iD_Autobus;
            ID_Ruta = iD_Ruta;
            Chofer = chofer;
            Cedula = cedula;
            Autobus_Marca = autobus_Marca;
            Modelo_Autobus = modelo_Autobus;
            Placa_Aut = placa_Aut;
            Ruta = ruta;
            Distancia = distancia;
        }

        public int ID { get => iD; set => iD = value; }
        public int ID_Chofer { get => iD_Chofer; set => iD_Chofer = value; }
        public int ID_Autobus { get => iD_Autobus; set => iD_Autobus = value; }
        public int ID_Ruta { get => iD_Ruta; set => iD_Ruta = value; }
        public string Chofer { get => chofer; set => chofer = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Autobus_Marca { get => autobus_Marca; set => autobus_Marca = value; }
        public string Modelo_Autobus { get => modelo_Autobus; set => modelo_Autobus = value; }
        public string Placa_Aut { get => placa_Aut; set => placa_Aut = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Distancia { get => distancia; set => distancia = value; }

    }
}
