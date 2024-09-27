using Sesion_12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_12
{
    public partial class Form1 : Form
    {
        List<Product> products;

        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(tbId.Text);
            product.Name = (tbName.Text);
            product.Description = (tbDescription.Text);
            product.Price = double.Parse(tbPrice.Text);
            products.Add(product);
            showData();
            clearText();

        }
        private void showData()
        {
            
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
        private void clearText()
        {
            tbId.Clear();
            tbName.Clear();
            tbDescription.Clear();
            tbPrice.Clear();

        }
    }
}
