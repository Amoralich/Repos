using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MootorBaike.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string _Mark { get; set; }
        public string _Model { get; set; }
        public int _Topspeed { get; set; }
        public decimal _FuelType { get; set; }
        public string _Color { get; set; }
    }
}
