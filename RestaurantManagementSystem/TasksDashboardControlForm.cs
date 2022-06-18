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
    public partial class TasksDashboardControlForm : UserControl
    {
        public TasksDashboardControlForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new ServeurCrudControlForm());
        }

        private void crudTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TableCrudControlForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new PlatCrudControlForm());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           this.Hide();
           this.Parent.Controls.Add(new AffecterServeurTable());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TableACommanderControlForm());
        }
    }
}
