﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentARabla.Models
{
    public class Client
    {
        public int Age { get; set; }
        public string NationalId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Adress Address { get; set; }
    }
}