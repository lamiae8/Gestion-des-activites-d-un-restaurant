using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class LoginControlForm : UserControl
    {
        public LoginControlForm()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginBox.Text=="limy" && passwordBox.Text == "limy")
            {
                this.Hide();
                this.Parent.Controls.Add(new TasksDashboardControlForm());
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

    }
}
