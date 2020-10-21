using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAuto.Models;

namespace MVCAuto.Data
{
    public class MVCAutoContext : DbContext
    {
        public MVCAutoContext (DbContextOptions<MVCAutoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAuto.Models.Car> Car { get; set; }
    }
}
