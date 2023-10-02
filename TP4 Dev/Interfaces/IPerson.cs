using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Interfaces
{
    /*
    Creamos la interface Persona con sus correspondientes propiedades
    */
    public interface IPerson : IAddress
    {
        string id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string mail { get; set; }
        int phone { get; set; }
        int age { get; set; }
        DateTime bornDate { get; set; }


    }
}
