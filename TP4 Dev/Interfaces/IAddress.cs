using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Interfaces
{
    public interface IAddress
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string zipCode { get; set; }

    }
}
