using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("productts",Schema ="prod")]
   public class Product
    {
        //[Key] //set primary key
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] not Automatic Generate
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }
        [Column("pricee")]
        [Required]
        public int Price { get; set; }

        [NotMapped]
        public int TotalPrice { get; set; }
    }
}
