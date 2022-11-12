using Prn211_Assignment.Forms;
using Prn211_Assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prn211_Assignment
{
    public partial class MainForm : Form
    {
        User curUser;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            if (curUser.RoleId != 1)
            {
                btProduct.Enabled = false;
            } 
                ProductForm p = new ProductForm();
                p.ShowDialog();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            OrderForm o = new OrderForm();
            o.ShowDialog();
        }

        private void btCart_Click(object sender, EventArgs e)
        {
            CashForm c = new CashForm();
            c.ShowDialog();
        }
    }
}
