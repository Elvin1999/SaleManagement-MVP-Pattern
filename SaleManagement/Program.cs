using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            ProductModel.Products productModel = new ProductModel.Products() {
                AllProduct=new List<Entities.Product>() {
                    new Entities.Product(){
                        Name="Ps4",Barcode=Guid.NewGuid(),
                        Count=100,Price=400.5
                    },
                     new Entities.Product(){
                        Name="Ps3",Barcode=Guid.NewGuid(),
                        Count=70,Price=200.5
                    },
                      new Entities.Product(){
                        Name="Xbox",Barcode=Guid.NewGuid(),
                        Count=150,Price=850.8
                    },
                       new Entities.Product(){
                        Name="AsusRog",Barcode=Guid.NewGuid(),
                        Count=100,Price=2500
                    },
                        new Entities.Product(){
                        Name="AcerPredator",Barcode=Guid.NewGuid(),
                        Count=100,Price=3000
                    },
                }
            };

            new ProductPresenter.ProductPresenter(new Form1(productModel)).ShowProducts();
        }
    }
}
