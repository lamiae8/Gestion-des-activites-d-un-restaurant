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

    
    public partial class TableCrudControlForm : UserControl
    {

        //selected from grid
        int selected_numero = 0;
        int selected_Nbre_Personne = 0;

        DataTable tables = new DataTable();

        RestaurantManagementContext db = new RestaurantManagementContext();

        public TableCrudControlForm()
        {

            InitializeComponent();

            //initialize grid
            tables.Columns.Add("Numero");
            tables.Columns.Add("Nbre Personne");
            tables.Columns.Add("Serveur");

            display();//display tables in tables

            Table latestTable = db.tables.OrderByDescending(t => t.num_table).FirstOrDefault();
            if(latestTable!=null) num_table_textbox.Text = (latestTable.num_table + 1).ToString();//initalize table id


            

        }




        //add table to db
        private void add_table_button_click(object sender, EventArgs e)
        {
            int nb_personne = Int32.Parse(num_personnes_textbox.Text);

            db.tables.Add(
                new Table()
                {
                    nombre_place = nb_personne,
                }
            );

            db.SaveChanges();

            MessageBox.Show("Table Added Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new TableCrudControlForm());

        }


        //delete selected element
        private void delete_table_button_click(object sender, EventArgs e)
        {
            int num_table = Int32.Parse(num_table_textbox.Text);
            Table table_to_delete = db.tables.Find(num_table);
            db.tables.Remove(table_to_delete);
            db.SaveChanges();
            MessageBox.Show("Table Successfully Deleted");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new TableCrudControlForm());

        }








        public void display()
        {


            DataRow dr;

            db.tables.ToList().ForEach(t =>
                {
                    dr = tables.NewRow();
                    dr[0] = t.num_table;
                    dr[1] = t.nombre_place;

                    tables.Rows.Add(dr);
                }
            );

            dataGridView2.DataSource = tables;


        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TasksDashboardControlForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_table_button(object sender, EventArgs e)
        {
            Table table_to_update = db.tables.Find(Int32.Parse(num_table_textbox.Text));
            table_to_update.nombre_place = Int32.Parse(num_personnes_textbox.Text);
            db.SaveChanges();

            MessageBox.Show("Table Updated Successfully");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new TableCrudControlForm());

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                selected_numero = Int32.Parse(row.Cells[0].Value.ToString());
                selected_Nbre_Personne = Int32.Parse(row.Cells[1].Value.ToString());

                Console.WriteLine("selected num : " + selected_numero);
                Console.WriteLine("selected nb perso : " + selected_Nbre_Personne);

                if (selected_numero != 0 && selected_Nbre_Personne != 0)
                {
                    num_table_textbox.Text = selected_numero.ToString();
                    num_personnes_textbox.Text = selected_Nbre_Personne.ToString();
                }

            }
        }
    }   
}
