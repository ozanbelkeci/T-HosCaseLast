using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductPropertyModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PropertyId { get; set; }
    }
}
