using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAuto.Models;

namespace MVCAuto.Data
{
    public class MvcCarContext : DbContext
    {
        public MvcCarContext (DbContextOptions<MvcCarContext> options)
            :base(options)
        {

        }
        
        public DbSet<Car> cars { get; set; }
    }
}
