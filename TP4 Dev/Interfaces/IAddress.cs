using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Interfaces
{
    internal interface IAddress
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }

    }
}
