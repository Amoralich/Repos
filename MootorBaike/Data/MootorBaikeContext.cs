using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MootorBaike.Models
{
    public class MootorBaikeContext : DbContext
    {
        public MootorBaikeContext (DbContextOptions<MootorBaikeContext> options)
            : base(options)
        {
        }

        public DbSet<MootorBaike.Models.Models> Models { get; set; }
    }
}
