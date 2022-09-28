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
        [Key]
        public int Ident { get; set; }
        public string? Name { get; set; }
    }
}