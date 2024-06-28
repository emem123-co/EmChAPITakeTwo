using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmChAPITakeTwo.Models;

namespace EmChAPITakeTwo.Data
{
    public class EmChAPITakeTwoContext : DbContext
    {
        public EmChAPITakeTwoContext (DbContextOptions<EmChAPITakeTwoContext> options)
            : base(options)
        {
        }

        public DbSet<EmChAPITakeTwo.Models.Customer> Customers { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.Employee> Employees { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.Item> Items { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.OrderLine> OrderLines { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.Order> Orders { get; set; } = default!;
    }
}
