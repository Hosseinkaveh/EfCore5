﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class ProductTag
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
