using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Entities
{
   public class Product
    {
        public string Name { get; set; }
        public Guid Barcode { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
