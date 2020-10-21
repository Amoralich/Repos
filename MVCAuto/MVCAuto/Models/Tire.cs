using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuto.Models
{
    public class Tire
    {
        public int Id { get; set; }
        public string TireType { get; set; }
        public string TireName { get; set; }
        public int CarId { get; set; }
    }
}
