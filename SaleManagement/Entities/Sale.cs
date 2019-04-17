using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.Entities
{
   public class Sale
    {
        public Product Product { get; set; }
        public double AdditionalPercent { get; set; }
        public double Discount { get; set; }
        public double LastPrice { get {
                if(Discount>=0 && Discount <= 1)
                {

                return Product.Price - Product.Price*Discount;
                }
                else
                {
                    return Product.Price;
                }
            } }
        public Guid CheckNumber { get; set;}
    }
}
