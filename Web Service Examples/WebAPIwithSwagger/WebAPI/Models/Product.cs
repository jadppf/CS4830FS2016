﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        //[JsonIgnore]
        public decimal Price { get; set; }
    }
}