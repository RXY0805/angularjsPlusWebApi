﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIFA14.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}