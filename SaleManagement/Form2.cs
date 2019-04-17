using SaleManagement.SaleView;
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
    public partial class Form2 : Form,ISaleView
    {
        public SaleModel.AllSale SaleModel { get; set; }
        public Form2(SaleModel.AllSale Sales)
        {
            InitializeComponent();
            SaleModel = Sales;
        }

        public void ShowSales()
        {
            ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
            DataGridView salesDGV = new DataGridView();
            salesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            salesDGV.Size = new Size(600, 150);
            salesDGV.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
            salesDGV.Location = new Point(100, 100);
            salesDGV.DataSource = SaleModel.AllSales;
            this.Controls.Add(salesDGV);
        }
    }
}
