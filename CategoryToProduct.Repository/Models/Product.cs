﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryToProduct.Repository.Models
{
    public class Product : IDeletable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Category Categor { get; set; }

        public bool IsDelete { get; set; }
    }
}
