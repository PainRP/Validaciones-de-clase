using System; 
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    

namespace p1bpoo.Misclases
{
    internal class CarroCombustionInterna : Vehiculo{
        private int NivelGasolina = 10;
        protected new double CapacidadTanque = 13.2; 
        protected new double ConsumoCombustible = 0.05; 
        protected new int velocidadMaxima = 180; 
        public CarroCombustionInterna(int anio, string elColor, string elModelo) : base (anio, elColor,  elModelo){
            
        }
        public string AlmaGasolina () {

            string nivel = "Bajo";
            if (NivelGasolina <= 25){
                nivel = "Bajo";
            }if(NivelGasolina >= 50){
                nivel = "Medio";
            }if(NivelGasolina >= 75){
                nivel = "Alto";
            }else{
                nivel = "Desconocido";
            }

            return nivel;

        }

        public void CargarGasolina(){
        NivelGasolina++;
    }

    }
}