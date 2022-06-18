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
    public partial class CommandeControlForm : UserControl
    {
        int table_number;
        
        DataTable commande_tables = new DataTable();

        RestaurantManagementContext db = new RestaurantManagementContext();

        public CommandeControlForm()
        {
            InitializeComponent();
        }

        public CommandeControlForm(int table_num)
        {
            InitializeComponent();
            table_number = table_num;
            //commande_tables.Columns.Add("Num Cmd");
            //commande_tables.Columns.Add("Date Enr");
            //commande_tables.Columns.Add("Nbre Personne");
            commande_tables.Columns.Add("Plats");
            commande_tables.Columns.Add("Qtte");
            commande_tables.Columns.Add("Prix");


            display();

            db.plats.ToList().ForEach(t => {
                plat_combo_box.Items.Add(t.libelle);
            });

            //set nbre personne maximal
            int max_nbre_personne_par_table = db.tables.Find(table_number).nombre_place;
            nbre_personne.Maximum = max_nbre_personne_par_table;
            Commande commande = db.commandes.Where(s => s.table_id == table_number).SingleOrDefault();
            double totalprice = 0;

            //Hide payment tab if no commande exists
            if (commande == null)
            {
                panel2.Hide();
            }
            else {
                string[] mode_pay = { "credit card", "cash", "debit card", "cheque", "points", "gift card", "coupon" };
                for (int i = 0; i < mode_pay.Length; i++) { mode_paiement_combo_box.Items.Add(mode_pay[i]); }
                date_paiement.Value = DateTime.Now;
                
                //prix total
                db.lignes_commandes_plats.ToList().ForEach(lc => { if (lc.commande_id == commande.num_commande) totalprice+= lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire; });
                
                total_numeric_updown.Value = (decimal)totalprice;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_commande_Click(object sender, EventArgs e)
        {

            DateTime date_eng = date_enregistrement.Value;
            int nbre_pers = (int)nbre_personne.Value;
            int qtte = (int)qtte_numeric.Value;
            string plat = plat_combo_box.Text;


            Plat plat_choisit=db.plats.Where(s => s.libelle == plat).SingleOrDefault();

            //commande of table
            Commande commande= db.commandes.Where(s => s.table_id == table_number).SingleOrDefault();


            if (commande == null) //if table doesn't have command
            {
                commande = db.commandes.Add(
                    new Commande()
                    {
                        date_enregistrement = date_eng,
                        nombre_personne = nbre_pers,
                        table_id = table_number,
                    }
                );
                db.SaveChanges();
            }
            

            db.lignes_commandes_plats.Add(
                new Ligne_Commande_Plat()
                {
                    quantite=qtte,
                    plat_id= plat_choisit.code_plat,
                    commande_id = commande.num_commande
                }
            );
            db.SaveChanges();


            MessageBox.Show("Ligne de Commande Added Successfully");


            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_number));

        }


        public void display()
        {

        DataRow dr;

        Commande commande = db.commandes.Where(s => s.table_id == table_number).SingleOrDefault();

        if(commande != null) //si table a une commande pour afficher sur datatable
        {
                nbre_personne.Value = commande.nombre_personne;
                nbre_personne.ReadOnly = true;
                label6.Text = "Commande N " + commande.num_commande;
                label6.ForeColor = Color.Brown;
        
                db.lignes_commandes_plats.ToList().ForEach(
                    lc => {
                        if (lc.commande_id == commande.num_commande)
                        {
                            dr = commande_tables.NewRow();

                            dr[0] = db.plats.Find(lc.plat_id).libelle; //nom du plat
                            dr[1] = lc.quantite; //qtte
                            dr[2] = lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire; //prix total de ligne de cmd
                       
                            commande_tables.Rows.Add(dr);
                        }
                    } 
                );
        }
            
           

        dataGridView1.DataSource = commande_tables; 

        }


        private void plat_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Add(new TableACommanderControlForm());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
        private void payer_button_Click_1(object sender, EventArgs e)
        {
            Commande commande = db.commandes.Where(s => s.table_id == table_number).SingleOrDefault();

            List<Ligne_Commande_Plat> lcp = new List<Ligne_Commande_Plat>();

            //ligne de cmd payee
            db.lignes_commandes_plats.ToList().ForEach(lc => { if (lc.commande_id == commande.num_commande) lcp.Add(lc); });

            //suprimme cmd
            db.commandes.Remove(commande);
            db.lignes_commandes_plats.RemoveRange(lcp);

            db.SaveChanges();
            
            MessageBox.Show("Commande Paye");

            //refresh form
            this.Hide();
            this.Parent.Controls.Add(new CommandeControlForm(table_number));
        }
    }
}
