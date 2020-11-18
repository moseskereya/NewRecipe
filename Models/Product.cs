using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ThumbNail { get; set; }
        public string Imgurl { get; set; }
        [NotMapped]
        public int[] Ratings { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
