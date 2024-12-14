using System.Collections.Generic;

namespace CustomerPanel.Models
{
    public class ProductPropertyViewModel
    {
        public List<ProductPropertyModel> ProductProperties { get; set; }
        public List<ProductModel> Products { get; set; }
        public List<PropertyModel> Properties { get; set; }
    }
}
