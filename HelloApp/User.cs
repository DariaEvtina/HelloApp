using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}