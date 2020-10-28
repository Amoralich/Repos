using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuto.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Module { get; set; }
        [Column(TypeName ="decimal(9,2)")]
        public decimal Price { get; set; } 
        public ICollection<Tire> Tires { get; set; }
    }
}
