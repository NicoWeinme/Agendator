using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Interfaces
{
    /*
    Creamos la interface para redes sociales con sus correspondientes propiedades
    */
    internal interface ISocial
    {
        string facebookID { get; set; }
        string twitterID { get; set; }
        string instagramID { get; set; }

    }
}
