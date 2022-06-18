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
    public partial class TableACommanderControlForm : UserControl
    {

        RestaurantManagementContext db = new RestaurantManagementContext();
        public TableACommanderControlForm()
        {
            InitializeComponent();

            Label[] table_labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24 };
            Button[] table_buttons = { table_1, table_2, table_3, table_4, table_5, table_6, table_7, table_8, table_9, table_10, table_11, table_12, table_13, table_14, table_15, table_16, table_17, table_18, table_19, table_20, table_21, table_22, table_23, table_24 };



            int numberoftables = db.tables.Count();

            //hiding
            for (int i = numberoftables; i < table_labels.Length; i++){ table_labels[i].Hide(); }
            for (int i = numberoftables; i < table_buttons.Length; i++) { table_buttons[i].Hide(); table_buttons[i].Cursor=Cursors.Hand;  }

            //naming
            int j = 0;
            db.tables.ToList().ForEach(i => { table_labels[j].Text = "Table "+ i.num_table.ToString(); table_buttons[j].Text= i.num_table.ToString();  j++; });


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void affecter_button_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TasksDashboardControlForm());
        }

        private void table_2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table1_button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_21_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_23_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }

        private void table_24_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int table_num = Int32.Parse(button.Text);
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_num));
        }
    }
}
