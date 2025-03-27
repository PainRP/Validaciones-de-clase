using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p1bpoo.Misclases;

namespace Clase_poo.Misclases
{
    public class Trailer : Vehiculo
    {
        public int capacidadCarga { get; private set; } // Capacidad máxima de carga en kg
        public int CargaActual { get; private set; } // Carga actual en kg
        public bool TieneDobleCabina { get; private set; } // Indica si el trailer tiene doble cabina

        public Trailer(int anio, string elColor, string elModelo, int capacidadCarga, bool tieneDobleCabina): base(anio, elColor, elModelo)
        {
            if (capacidadCarga <= 0)
            {
                throw new ArgumentException("La capacidad de carga debe ser mayor a 0.");
            }

            this.capacidadCarga = capacidadCarga;
            this.CargaActual = 0; // Inicializa la carga actual en 0
            this.TieneDobleCabina = tieneDobleCabina;
            tiposLicenciaAceptados = new List<string> { "A" }; // Solo licencias tipo A
        }

        public void Cargar(int peso)
        {
            if (peso <= 0)
            {
                Console.WriteLine("El peso a cargar debe ser mayor a 0.");
                return;
            }

            if (CargaActual + peso > capacidadCarga)
            {
                Console.WriteLine($"No se puede cargar {peso} kg. El peso excede la capacidad máxima de {capacidadCarga} kg.");
            }
            else
            {
                CargaActual += peso;
                Console.WriteLine($"Se han cargado {peso} kg en el trailer. Carga actual: {CargaActual} kg.");
            }
        }

        public void Descargar(int peso)
        {
            if (peso <= 0)
            {
                Console.WriteLine("El peso a descargar debe ser mayor a 0.");
                return;
            }

            if (peso > CargaActual)
            {
                Console.WriteLine($"No puedes descargar {peso} kg. La carga actual es de {CargaActual} kg.");
            }
            else
            {
                CargaActual -= peso;
                Console.WriteLine($"Se han descargado {peso} kg del trailer. Carga actual: {CargaActual} kg.");
            }
        }

        public void InformacionCarga()
        {
            Console.WriteLine($"Capacidad máxima de carga: {capacidadCarga} kg.");
            Console.WriteLine($"Carga actual: {CargaActual} kg.");
            Console.WriteLine($"Doble cabina: {(TieneDobleCabina ? "Sí" : "No")}");
        }
    }
}