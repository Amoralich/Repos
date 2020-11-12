using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorcycleApi.Models
{
    public class MotorcycleContext : DbContext
    {
        public MotorcycleContext(DbContextOptions<MotorcycleContext> options)
            : base(options)
        {
        }

        public DbSet<MotorcycleItem> MotorcycleItems { get; set; }
    }
}
