using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clase_poo.Interfaces;

namespace Clase_poo.Misclases
{
    public class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set ;}
        public string TipoLicencia { get; set; }

        public Chofer(string name, int age, string LicenseT){
            Nombre = name;
            Edad = age;

            if ((LicenseT == "C" || LicenseT == "M" || LicenseT == "E") && age >= 18)
            {
                TipoLicencia = LicenseT;
            }else if (LicenseT == "B" && age >= 21)
            {
                TipoLicencia = LicenseT;
            }else if (LicenseT == "A" && age >= 23)
            {
                TipoLicencia = LicenseT;
            } else{
                TipoLicencia = "No valida";
                Console.WriteLine("No cumples la edad legal para este tipo de licencia");
            }
        }

        public void mostrarInformación()
        {
            Console.WriteLine("El piloto es {0}", Nombre);
            Console.WriteLine("Licencia tipo: {0}", TipoLicencia);
        }
    }
}