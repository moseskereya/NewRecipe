using System.Collections.Generic;

namespace Stores.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> products { get; set; }
    }
}