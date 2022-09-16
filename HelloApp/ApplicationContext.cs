using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {

        //public DbSet<User> Users { get; set; } = null!;
        public DbSet<User> Users => Set<User>();

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

    }
}