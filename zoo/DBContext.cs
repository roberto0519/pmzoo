using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace zoo
{
    class DBContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_11");
        }
    }
}

