using SaleManagement.ProductView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class Form1 : Form,IProductView
    {
        public ProductModel.Products ProductModel { get; set; }
        public Form1(ProductModel.Products productModel)
        {
            InitializeComponent();
            ProductModel = productModel;
        }

        public void ShowProducts()
        {
            ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
            DataGridView productsDGV = new DataGridView();
            productsDGV.Size = new Size(450, 150);
            productsDGV.Font = new Font("Comic Sans MS", 9, FontStyle.Italic);
            productsDGV.Location = new Point(50,50);
            productsDGV.DataSource = ProductModel.AllProduct;
            this.Controls.Add(productsDGV);
            var SalesBtn = new Button();
            SalesBtn.Size = new Size(150, 50);
            SalesBtn.Location = new Point(120,300);
            SalesBtn.Text = "Show All Sales";
            SalesBtn.Font=new Font("Comic Sans MS", 12, FontStyle.Italic);
            SalesBtn.BackColor = Color.Azure;
            SalesBtn.Click += SalesBtn_Click;
            this.Controls.Add(SalesBtn);


        }
        private void SalesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var saleModel = new SaleModel.AllSale() {
                AllSales = new List<Entities.Sale>()
                {
                    new Entities.Sale(){
                        Product=new Entities.Product()
                        {
                            Name="Ps4",Barcode=Guid.NewGuid(),
                        Count=100,Price=400.5
                        },
                        AdditionalPercent=10.5,
                        Discount=0.3,
                        CheckNumber=Guid.NewGuid()
                    },
                    new Entities.Sale(){
                        Product=new Entities.Product()
                        {
                            Name="Ps4",Barcode=Guid.NewGuid(),
                        Count=100,Price=400.5
                        },
                        AdditionalPercent=10.5,
                        Discount=0.3,
                        CheckNumber=Guid.NewGuid()
                    },
                    new Entities.Sale(){
                        Product=new Entities.Product()
                        {
                            Name="Ps4",Barcode=Guid.NewGuid(),
                        Count=100,Price=400.5
                        },
                        AdditionalPercent=10.5,
                        Discount=0.3,
                        CheckNumber=Guid.NewGuid()
                    }
                }
            };
           var salePresenter = new SalePresenter.SalePresenter(new Form2(saleModel)) { };
            salePresenter.ShowSales();
            

        }
    }
}
