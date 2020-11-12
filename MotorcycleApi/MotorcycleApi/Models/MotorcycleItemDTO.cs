using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorcycleApi.Models
{
    public class MotorcycleItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string price { get; set; }
        public string firm { get; set; }
        public bool IsUsed { get; set; }
    }
}
