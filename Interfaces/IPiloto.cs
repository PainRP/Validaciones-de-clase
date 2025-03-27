using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_poo.Interfaces
{
    public interface IPiloto
    {
        string Nombre {get; set;}
        int Edad {get; set;}
        string TipoLicencia {get; set;} //a,b,c

        void mostrarInformación();
    }
}