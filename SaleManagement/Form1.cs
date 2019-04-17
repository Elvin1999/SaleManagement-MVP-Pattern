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
            productsDGV.Size = new Size(500, 150);
            productsDGV.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
            productsDGV.Location = new Point(100, 200);
            productsDGV.DataSource = ProductModel.AllProduct;
            this.Controls.Add(productsDGV);
        }
    }
}
