using System; 
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    

namespace p1bpoo.Misclases
{
    internal class CarroElectrico : Vehiculo{
        private float CargaBateria; // Nivel actual de la batería en kWh
        protected float CapacidadBateria = (float)75.0; // Capacidad máxima de la batería en kWh
        protected float ConsumoEnergia = (float)0.2; // Consumo en kWh/km
        protected new int velocidadMaxima = 160; // Velocidad máxima en km/h
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor,  elModelo){
            CargaBateria = 50;
        }

    public float NivelBateria() {return CargaBateria;}

    public void CargarBateria(){
        CargaBateria++;
    }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            CargaBateria--;
        }

    }
}


    
