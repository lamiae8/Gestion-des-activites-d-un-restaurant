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
    public partial class ServeurCrudControlForm : UserControl
    {

        DataTable serveurs = new DataTable();
        RestaurantManagementContext db = new RestaurantManagementContext();

        public ServeurCrudControlForm()
        {
            InitializeComponent();
            serveurs.Columns.Add("Numero");
            serveurs.Columns.Add("Nom");
            serveurs.Columns.Add("Prenom");
            serveurs.Columns.Add("Tables");

            display();//display tables in tables

           Serveur latestServeur = db.serveurs.OrderByDescending(t => t.code_serveur).FirstOrDefault();
           if (latestServeur != null)
           {
               num_serveur_textbox.Text = (latestServeur.code_serveur + 1).ToString();//initalize table id     
           }

        }


        public void display()
        {


            DataRow dr;

            db.serveurs.ToList().ForEach(t =>
            {
                dr = serveurs.NewRow();
                dr[0] = t.code_serveur;
                dr[1] = t.nom;
                dr[2] = t.prenom;

                serveurs.Rows.Add(dr);
            }
            );

            dataGridView2.DataSource = serveurs;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TasksDashboardControlForm());
        }

        private void add_serveur_button_click(object sender, EventArgs e)
        {

            db.serveurs.Add(
                new Serveur()
                {
                    nom = nom_serveur_textbox.Text,
                    prenom = prenom_serveur_textbox.Text
                }
            );

            db.SaveChanges();

            MessageBox.Show("Serveur Added Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new ServeurCrudControlForm());

        }

      

     

        private void delete_serveur_button_click(object sender, EventArgs e)
        {
            int code_serveur = Int32.Parse(num_serveur_textbox.Text);
            Serveur serveur_to_delete = db.serveurs.Find(code_serveur);

            db.serveurs.Remove(serveur_to_delete);
            db.SaveChanges();
            MessageBox.Show("Serveur Successfully Deleted");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new ServeurCrudControlForm());
        }

        private void update_serveur_button_click(object sender, EventArgs e)
        {
            Serveur serveur_to_update = db.serveurs.Find(Int32.Parse(num_serveur_textbox.Text));

            serveur_to_update.nom = nom_serveur_textbox.Text;
            serveur_to_update.prenom = prenom_serveur_textbox.Text;

            db.SaveChanges();

            MessageBox.Show("Serveur Updated Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new ServeurCrudControlForm());
        }

        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {


                int selected_code_serveur = Int32.Parse(row.Cells[0].Value.ToString());
                string selected_nom = row.Cells[1].Value.ToString();
                string selected_prenom = row.Cells[2].Value.ToString();


                num_serveur_textbox.Text = selected_code_serveur.ToString();
                nom_serveur_textbox.Text = selected_nom;
                prenom_serveur_textbox.Text = selected_prenom;



            }
        }
    }
}
