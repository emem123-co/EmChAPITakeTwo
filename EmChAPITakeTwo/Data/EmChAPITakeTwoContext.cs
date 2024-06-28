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
        public DbSet<EmChAPITakeTwo.Models.Employee> Employee { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.Item> Item { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.OrderLine> OrderLine { get; set; } = default!;
        public DbSet<EmChAPITakeTwo.Models.Order> Order { get; set; } = default!;
    }
}
