﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public partial class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long Age { get; set; }
        public bool IsMarried { get; set; }
    }
}