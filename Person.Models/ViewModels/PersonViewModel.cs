﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Models.ViewModels
{
    public class PersonViewModel
    {
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
