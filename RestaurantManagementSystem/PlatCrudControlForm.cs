using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.Model;

namespace RestaurantManagementSystem
{
    public partial class PlatCrudControlForm : UserControl
    {
        DataTable platsDT = new DataTable();

        RestaurantManagementContext db = new RestaurantManagementContext();

        public PlatCrudControlForm()
        {
            InitializeComponent();
            platsDT.Columns.Add("Code");
            platsDT.Columns.Add("Libelle");
            platsDT.Columns.Add("Type");
            platsDT.Columns.Add("Prix");

            display();//display tables in tables

            Plat latestPlat = db.plats.OrderByDescending(t => t.code_plat).FirstOrDefault();
            if (latestPlat != null)
            {
            code_plat_textbox.Text = (latestPlat.code_plat + 1).ToString();//initalize table id     
            }

        }

        public void display()
        {


            DataRow dr;

            db.plats.ToList().ForEach(t =>
            {
                dr = platsDT.NewRow();
                dr[0] = t.code_plat;
                dr[1] = t.libelle;
                dr[2] = t.type;
                dr[3] = t.prix_unitaire;

                platsDT.Rows.Add(dr);
            }
            );

            dataGridView2.DataSource = platsDT;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TasksDashboardControlForm());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_plat_button_click(object sender, EventArgs e)
        {
            Plat table_to_update = db.plats.Find(Int32.Parse(code_plat_textbox.Text));

            table_to_update.libelle = libelle_textbox.Text;
            table_to_update.prix_unitaire = Int32.Parse(prix_textbox.Text);
            table_to_update.type = type_textbox.Text;

            db.SaveChanges();

            MessageBox.Show("Table Updated Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new PlatCrudControlForm());
        }

        private void add_plat_button_click(object sender, EventArgs e)
        {

            db.plats.Add(
                new Plat()
                {
                    libelle = libelle_textbox.Text,
                    type = type_textbox.Text,
                    prix_unitaire = Int32.Parse(prix_textbox.Text)
                }
            );

            db.SaveChanges();

            MessageBox.Show("Plat Added Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new PlatCrudControlForm());

        }

        private void delete_plat_button_Click(object sender, EventArgs e)
        {
            int code_plat = Int32.Parse(code_plat_textbox.Text);
            Plat plat_to_delete = db.plats.Find(code_plat);
            db.plats.Remove(plat_to_delete);
            db.SaveChanges();
            MessageBox.Show("Plat Successfully Deleted");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new PlatCrudControlForm());
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {


                int selected_code_plat = Int32.Parse(row.Cells[0].Value.ToString());
                string selected_libelle = row.Cells[1].Value.ToString();
                string selected_type = row.Cells[2].Value.ToString();
                int selected_prix = Int32.Parse(row.Cells[3].Value.ToString());


                code_plat_textbox.Text = selected_code_plat.ToString();
                libelle_textbox.Text = selected_libelle;
                type_textbox.Text = selected_type;
                prix_textbox.Text = selected_prix.ToString();
                
              

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
