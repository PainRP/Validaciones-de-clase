using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p1bpoo.Misclases;

namespace Clase_poo.Misclases
{
    public class Moto : Vehiculo
    {
        protected new double CapacidadTanque = 3.5; 
        protected new double ConsumoCombustible = 0.03; 
        protected new int velocidadMaxima = 120; 
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> {"M"};
        }

        public void HacerCaballito() 
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("No puedes hacer un caballito con la moto apagada.");
                return;
            }
            if (velocidad == 0)
            {
                Console.WriteLine("No puedes hacer un caballito si la moto no está en movimiento.");
                return;
            }
            Console.WriteLine("¡Estás haciendo un caballito!");
        }
    }
}