using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class SampleContextFactory 
    {
        /* public ApplicationContext CreateDbContext(string[] args) : IDesignTimeDbContextFactory<ApplicationContext>
         {
             var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

             // получаем конфигурацию из файла appsettings.json
             ConfigurationBuilder builder = new ConfigurationBuilder();
             builder.SetBasePath(Directory.GetCurrentDirectory());
             builder.AddJsonFile("appsetings.json");
             IConfigurationRoot config = builder.Build();

             // получаем строку подключения из файла appsettings.json
             string connectionString = config.GetConnectionString("DefaultConnection");
             optionsBuilder.UseSqlite(connectionString);
             return new ApplicationContext(optionsBuilder.Options);
         }*/
    }
}
