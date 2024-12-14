using System.Collections.Generic;

namespace CafeMenu.Models
{
    public class ProductViewModel
    {
        public List<ProductPropertyModel> ProductProperties { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<PropertyModel> Properties { get; set; }

    }
}
