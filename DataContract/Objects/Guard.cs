﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract.Objects
{
    public class Guard
    {
        public Int64 PersonalCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
