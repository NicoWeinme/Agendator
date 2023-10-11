using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Dev.Interfaces;

namespace TP4_Dev.Classes
{
    /// <summary>
    /// EN LA PRESENTE CLASE "Student" ESTÁN LAS PROPIEDADES DEL OBJETO "Student".
    /// </summary>
    /*
    Creamos la clase Alumno con sus correspondientes propiedades
    */
    internal class Student : IPerson, ISocial
    {
        public int      id            { get; set; }
        public string   firstName     { get; set; }
        public string   lastName      { get; set; }
        public string   mail          { get; set; }
        public long      phone            { get; set; }
        public int      age              { get; set; }
        public string   bornDate    { get; set; }
        public string   facebookID    { get; set; }
        public string   twitterID     { get; set; }
        public string   instagramID   { get; set; }
        public string   country       { get; set; }
        public string   city          { get; set; }
        public string   street        { get; set; }
    }
}
