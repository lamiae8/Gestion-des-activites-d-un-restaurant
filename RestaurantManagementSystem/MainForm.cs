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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginControlForm1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tasksDashboardControlForm1.Hide();
            tableCrudControlForm1.Hide();
            serveurCrudControlForm1.Hide();
            affecterServeurTable1.Hide();
            commandeControlForm1.Hide();
            tableACommanderControlForm1.Hide();
            loginControlForm1.Show();
        }

        private void loginControlForm1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
