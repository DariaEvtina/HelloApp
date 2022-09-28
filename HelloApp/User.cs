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
        string name;

        public int Id { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
    }

}