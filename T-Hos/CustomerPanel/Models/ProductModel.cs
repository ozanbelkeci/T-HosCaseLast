
using System;

namespace CustomerPanel.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
