using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Model;

namespace WebStore.Data
{
    public class ApplicationDbContext : DbContext  {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; } 
        public DbSet<WebStoreCarItem> WebStoreCarItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }

}
