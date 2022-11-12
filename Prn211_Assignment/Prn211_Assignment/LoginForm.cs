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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            using (var context = new Prn211assignmentContext())
            {
                var query = from User in context.Users
                            where User.Username == tbUserName.Text && User.Password == tbPassword.Text
                            select User;
                var user = query.FirstOrDefault();
                if(user != null)
                {
                    MainForm m = new MainForm(user);
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }
    }
}
