﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vogel.Areas.Admin.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Pwd { get; set; }
    }
}
