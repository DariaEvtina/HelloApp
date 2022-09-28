using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        // навигационное свойство
        public Company? Company { get; set; }
    }
    [NotMapped]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}