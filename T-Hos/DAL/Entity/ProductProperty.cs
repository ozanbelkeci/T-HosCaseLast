using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class ProductProperty : BaseEntity
    {
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public int PropertyId { get; set; }
    }
}
