using SaleManagement.SaleView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.SalePresenter
{
    class SalePresenter
    {
        ISaleView saleView;
        public SalePresenter(ISaleView view)
        {
            saleView = view;
        }
        public void ShowSales()
        {
            saleView.ShowSales();
        }
    }
}
