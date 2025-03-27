using Clase_poo.Misclases;
using p1bpoo.Misclases;
// using p1bpoo.Misclases;


// Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
// miCarrito.Color = "Gris";
// miCarrito.Year = "2023";
// miCarrito.Modelo = "Model Y";



// Console.WriteLine("Mi carro es de color: {0} y modelo {1}" , miCarrito.Color, miCarrito.Modelo); // el {0} sirve para remplazar por ejemplo aca indica que lo 
// miCarrito.acelerar();                                                               // remplace por el color, si fuera {1} y  coloco otro parametro va agarrar
//                                                                 // El otro
// Console.WriteLine("Mi carro es de año: {0} y modelo {1}" , miCarrito.Year, miCarrito.Modelo);
// // miCarrito.Year = "2000";
// Console.WriteLine("Mi carro es de año: {0} y modelo {1}" , miCarrito.Year, miCarrito.Modelo);

// miCarrito.InformacionVehiculo();
// miCarrito.Color = "Verde";
// Console.WriteLine("Nuevo color");
// miCarrito.InformacionVehiculo();

// miCarrito.acelerar(1);
// miCarrito.acelerar(1);
// // miCarrito.acelerar(1);
// for (int i = 0; i < 60; i++ ){
//     miCarrito.acelerar(1);
// }

// Vehiculo elOtro = new Vehiculo(2045, "Rojo", "Delorean");

// if (miCarrito.Year > elOtro.Year){
//     Console.WriteLine("miCarrito es el más reciente, año {0}" , miCarrito.Year);
//     Console.WriteLine("elOtro es el más viejo, año {0}" , elOtro.Year);
// }else{
//     Console.WriteLine("miCarrito es el más viejo, año {0}" , miCarrito.Year);
//     Console.WriteLine("elOtro es el más reciente, año {0}" , elOtro.Year);
// }

// CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

// miBYD.InformacionVehiculo();
// miBYD.CargarBateria();
// Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

Chofer piloto1= new Chofer("Moinca", 25, "A");
Chofer piloto2= new Chofer("Andrea", 21, "m");

piloto2.TipoLicencia = "m";
piloto1.mostrarInformación();
piloto2.mostrarInformación();

Vehiculo sedan = new Vehiculo(2025, "Azul" , "Honda");

string respuesta;

respuesta = sedan.asignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.acelerar(25);

Moto honda = new Moto(2025, "Rojo", "Honda");
Console.WriteLine(honda.asignarPiloto(piloto2));