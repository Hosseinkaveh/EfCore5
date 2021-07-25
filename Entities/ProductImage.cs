﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductImage
    {

        public int Id { get; set; }
        public byte[] Image { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}