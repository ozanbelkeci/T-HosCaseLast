namespace CustomerPanel.Models
{
    public class ProductPropertyModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int PropertyId { get; set; }
        public PropertyModel Property { get; set; }
    }
}
