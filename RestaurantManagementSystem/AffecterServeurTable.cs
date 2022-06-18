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
    public partial class AffecterServeurTable : UserControl
    {
        DataTable serveur_tables = new DataTable();
        RestaurantManagementContext db = new RestaurantManagementContext();
        public AffecterServeurTable()
        {
            InitializeComponent();

            serveur_tables.Columns.Add("Serveur");
            serveur_tables.Columns.Add("Table");
            serveur_tables.Columns.Add("Date d'affectation");

            display();

            dateTimePicker1.Value = DateTime.Now;

            db.serveurs.ToList().ForEach(t =>{serveur_combo_box.Items.Add(t.nom + " " + t.prenom);});

            db.tables.ToList().ForEach(t =>{
                if(!t.reserved) tables_combo_box.Items.Add(t.num_table);
            });


        }


        public void display()
        {

            DataRow dr;

            db.affectations.ToList().ForEach(t =>
            {   
                dr = serveur_tables.NewRow();
                Serveur serveur = db.serveurs.Where(s => s.code_serveur == t.serveur_id).SingleOrDefault();

                Table table = db.tables.Find(t.table_id);

                if (serveur != null)
                {
                    dr[0] = serveur.nom + " " + serveur.prenom;
                    dr[1] = table.num_table;
                    dr[2] = t.date_affectation;
                    
                    serveur_tables.Rows.Add(dr);
                }


            }
            );

            dataGridView2.DataSource = serveur_tables;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TasksDashboardControlForm());
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void affecter_button_click(object sender, EventArgs e)
        {

            Serveur serveur = db.serveurs.Where(s => s.nom + " " + s.prenom == serveur_combo_box.Text).Single();
            Table table = db.tables.Find(Int32.Parse(tables_combo_box.Text));

            db.affectations.Add(
                new Affecter()
                {
                    serveur_id=serveur.code_serveur,
                    table_id=table.num_table,
                    date_affectation = dateTimePicker1.Value
                }
            );

            table.reserved = true;

            db.SaveChanges();

            MessageBox.Show("Affectation Added Successfully");


            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new AffecterServeurTable());

        }

        private void s(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void serveur_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
