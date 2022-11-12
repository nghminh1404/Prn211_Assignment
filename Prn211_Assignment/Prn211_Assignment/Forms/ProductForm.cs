using Prn211_Assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace Prn211_Assignment.Forms
{
    public partial class ProductForm : Form
    {
        Prn211assignmentContext context = new Prn211assignmentContext();
        Product currentProduct;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadCategory();
            DGV();
            //DesignDGV();
           // LoadProductData();
        }
        private void DGV(/*int employeeID, String sortBy*/)
        {
            var context = new Prn211assignmentContext();

            var query = from p in context.Products
                        join c in context.Categories on p.CategoryId equals c.Id
                        select new
                        {
                            ProductID = p.Id,
                            ProductName = p.Name,
                            Price = p.Price,
                            Quantity = p.Quantity,
                            Status = p.Status,
                            CategoryId = c.Id,
                            CategoryName = c.Name
                        };
            var products = query.ToList();  
            dataGridView1.DataSource = products;
            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["ProductID"].Visible = false;
        }
            private void DesignDGV()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns["id"].DataPropertyName = "Id";
            dataGridView1.Columns.Add("productName", "Product Name");
            dataGridView1.Columns["productName"].DataPropertyName = "productName";
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns["price"].DataPropertyName = "Price";
            dataGridView1.Columns.Add("quantity", "Quantity");
            dataGridView1.Columns["quantity"].DataPropertyName = "Quantity";
            dataGridView1.Columns.Add("status", "Status");
            dataGridView1.Columns["status"].DataPropertyName = "Status";
            dataGridView1.Columns.Add("category", "Category");
            dataGridView1.Columns["category"].DataPropertyName = "Category";
        }
        private void loadCategory()
        {
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = context.Categories.ToList();
            cbCategoryAdd.DisplayMember = "Name";
            cbCategoryAdd.ValueMember = "Id";
            cbCategoryAdd.DataSource = context.Categories.ToList();
        }
     /*   private void LoadProductData()
        {
            dataGridView1.DataSource = context.Products.ToList();
            dataGridView1.Columns["Categories"].
            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["Bills"].Visible = false;
            dataGridView1.Columns["Cashes"].Visible = false;
            dataGridView1.Columns["Category"].Visible = false;
        }*/

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
            dataGridView1.DataSource = context.Products.Where(x => x.CategoryId == categoryId).ToList();
        }
        private void LoadDataBySearchByProductName()
        {
            string text = tbSearch.Text;
            dataGridView1.DataSource = context.Products.Where(x => x.Name.Contains(text)).ToList();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            LoadDataBySearchByProductName();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tbProductName.Text;
            double price = double.Parse(tbPrice.Text);
            product.Price = price;
            if (rbStock.Checked == true)
            {
                product.Status = true;
            }
            else
            {
                product.Status = false;
            }
            product.Quantity = Convert.ToInt32(tbQuantity.Text);
            product.CategoryId = Convert.ToInt32(cbCategoryAdd.SelectedValue);
            context.Products.Add(product);
            int count = context.SaveChanges();
            if (count != 0)
            {
                MessageBox.Show("Add new product successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Add new product fail");
                ClearData();
            }
            DGV();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (tbProductId.Text == String.Empty)
            {
                MessageBox.Show("Please enter product ID!");
                return;
            }currentProduct.Id = Convert.ToInt32(tbProductId.Text);
            if (tbProductName.Text == string.Empty)
            {
                MessageBox.Show("Please enter product name!");
                return;
            }
            
           // tbProductId.Enabled = false;

            currentProduct.Name = tbProductName.Text;
            double price = double.Parse(tbPrice.Text);
            currentProduct.Price = price;
            if (rbStock.Checked == true)
            {
                currentProduct.Status = true;
            }
            else
            {
                currentProduct.Status = false;
            }
            currentProduct.Quantity = Convert.ToInt32(tbQuantity.Text);
            currentProduct.CategoryId = Convert.ToInt32(cbCategoryAdd.SelectedValue);
            context.Products.Update(currentProduct);
            int count = context.SaveChanges();
            if (count != 0)
            {
                MessageBox.Show("Update product successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Add product fail");
                ClearData();
            }
            DGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                Product product = context.Products.First(x => x.Id == currentProduct.Id);
                context.Products.Remove(product);
                int count = context.SaveChanges();
                if (count != 0)
                {
                    MessageBox.Show("Delete successfully");
                    DGV();
                }
                else
                {
                    MessageBox.Show("Delete fail");
                    DGV();
                }

            }
        }

        private void ClearData()
        {
            tbProductName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            rbStock.Checked = false;
            rbOutOfStock.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                List<Product> products = (List<Product>)dataGridView1.DataSource;
                currentProduct = products[e.RowIndex];
                if (currentProduct != null)
                {
                tbProductName.Text = currentProduct.Name;
                tbPrice.Text = Convert.ToString(currentProduct.Price);
                tbQuantity.Text = Convert.ToString(currentProduct.Quantity);
                if (currentProduct.Status == true)
                {
                    rbStock.Checked = true;
                }
                else
                {
                    rbOutOfStock.Checked = true;
                }
                cbCategoryAdd.SelectedValue = currentProduct.CategoryId;
            }
        }


    }
}
