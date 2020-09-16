using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MootorBaike.Models
{
    public class Models
    {
        public int ID { get; set; }
        protected string _Mark { get; set; }
        protected string _Model { get; set; }
        private int _Topspeed { get; set; }
        private decimal _FuelType { get; set; }
        protected string _Color { get; set; }
    }
}
