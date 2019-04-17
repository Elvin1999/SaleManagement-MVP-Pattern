using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Entities
{
    class Sale
    {
        public Product Product { get; set; }
        public double AdditionalPercent { get; set; }
        public double Discount { get; set; }
        public double LastPrice { get { return Product.Price - Discount; } }
        public Guid CheckNumber { get; set;}
    }
}
