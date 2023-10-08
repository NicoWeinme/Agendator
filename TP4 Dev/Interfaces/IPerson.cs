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
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string mail { get; set; }
        long phone { get; set; }
        int age { get; set; }
        string bornDate { get; set; }


    }
}
