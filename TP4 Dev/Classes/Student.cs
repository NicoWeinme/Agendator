using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Dev.Interfaces;

namespace TP4_Dev.Classes
{
    /*
    Creamos la clase Alumno con sus correspondientes propiedades
    */
    public class Student : IPerson, ISocial
    {
        public string   id            { get; set; }
        public string   firstName     { get; set; }
        public string   lastName      { get; set; }
        public string   mail          { get; set; }
        public int      phone            { get; set; }
        public int      age              { get; set; }
        public DateTime bornDate    { get; set; }
        public string   facebookID    { get; set; }
        public string   twitterID     { get; set; }
        public string   instagramID   { get; set; }
        public string   country       { get; set; }
        public string   city          { get; set; }
        public string   street        { get; set; }
    }
}
