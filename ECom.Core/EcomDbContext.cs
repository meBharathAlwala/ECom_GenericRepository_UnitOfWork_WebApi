using ECom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Core
{
    public class EcomDbContext:DbContext
    {
        public EcomDbContext(DbContextOptions<EcomDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
