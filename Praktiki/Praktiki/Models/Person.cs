﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
