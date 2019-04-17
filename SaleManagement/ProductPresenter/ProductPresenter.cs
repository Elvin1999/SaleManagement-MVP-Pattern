using SaleManagement.ProductView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.ProductPresenter
{
   public class ProductPresenter
    {
        IProductView productView;
        public ProductPresenter(IProductView view)
        {
            productView = view;
        }
        public void ShowProducts()
        {
            productView.ShowProducts();
        }
    }
}
