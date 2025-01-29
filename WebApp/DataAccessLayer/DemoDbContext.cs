using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DemoDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionstring = "Data Source=DESKTOP-6F2FJ3R; Initial Catalog=DotNetCore;Integrated Security=true;TrustServerCertificate=true;";

                optionsBuilder.UseSqlServer(connectionstring);
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
