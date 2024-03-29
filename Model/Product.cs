﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebForm
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string DetailHtml { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
    }
}
