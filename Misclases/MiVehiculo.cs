using System; 
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Clase_poo.Misclases;

namespace p1bpoo.Misclases
{
    
    public class Vehiculo{

        public Vehiculo(string color, int year) 
        {
            this.Color = color;
             this.Year = year;
   
        }
                public string Color {get; set;}
        public string Modelo {get; }
        public int Year {get; }
        protected int velocidad = 0;
        protected int velocidadMaxima = 490;
        protected int CapacidadTanque;
        protected int ConsumoCombustible;

        // atributos nuveos
        protected List<string> tiposLicenciaAceptados = new List<string> {"A", "B", "C", "M", "E"};
        private Chofer piloto =null;
        protected int estadoVehiculo = 0; // 0=apagado, 1=encendido, 3= en movimiento.
        
        public string asignarPiloto(Chofer elPiloto){
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tpo de licencia adecuado para este vehiculo";
            }if (piloto != null)
            {
                return "Ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitósamente";
        }

        public Vehiculo(int anio, string elColor, string elModelo){
           this.Color =elColor;
           this.Modelo = elModelo;
           this.Year = anio; 
        } 
        public void InformacionVehiculo()
        {
            Console.WriteLine("Información del Vehículo:");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Año: {this.Year}");
            Console.WriteLine($"Velocidad actual: {this.velocidad} km/h");
            Console.WriteLine($"Velocidad máxima: {this.velocidadMaxima} km/h");

            // Estado del vehículo
            string estado;
            switch (estadoVehiculo)
            {
                case 0:
                    estado = "Apagado";
                    break;
                case 1:
                    estado = "Encendido";
                    break;
                case 3:
                    estado = "En movimiento";
                    break;
                default:
                    estado = "Desconocido";
                    break;
            }
            Console.WriteLine($"Estado del vehículo: {estado}");

            // Piloto asignado
            if (piloto != null)
            {
                Console.WriteLine($"Piloto asignado: {piloto.Nombre}");
            }
            else
            {
                Console.WriteLine("Piloto asignado: Ninguno");
            }
        }
        public string Encender(){
            if (piloto==null){
                return "No puedes encender el carro sin piloto";
            }if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "El vehículo esta encendido";         
            }
            return "Ups, ya estaba encendido";
        }
        public string Apagar(){
            if (piloto==null){
                return "No puedes apagar el carro sin piloto";
            }if (estadoVehiculo == 1 && velocidad == 0)
            {
                estadoVehiculo = 0;
                return "El vehículo se apago";         
            }else if (velocidad >0){
                return "No se puede apagar el vehículo en movimiento.";
            }
            return "Ups, ya estaba apagado";
        }
        public virtual void acelerar(int cuanto){
            if (estadoVehiculo == 1 && velocidad <= velocidadMaxima){
                velocidad += cuanto;
                Console.WriteLine("Vas a {0} km/h", velocidad);
            }else if (velocidad >= velocidadMaxima)
            {   
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {velocidadMaxima} km/h.");
            }else
            {
                Console.WriteLine("no se puede acelerar con el carro apagado");   
            }
        }
        public virtual void frenar(int cuanto){
               if (estadoVehiculo == 1){
                velocidad -= cuanto;
                Console.WriteLine("Vas a {0} km/h", velocidad);
            }if (velocidad == 0)
            {
                estadoVehiculo = 1;

            }
        }

    }

    
}