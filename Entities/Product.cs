using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }

        public Category category { get; set; }
        public int FK_CategoryId { get; set; }

        public ProductImage productImage { get; set; }

        public ICollection<ProductTag> productTags { get; set; }

    }
}
