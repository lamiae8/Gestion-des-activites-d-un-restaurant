using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.CrystalReport.Report;
using RestaurantManagementSystem.Model;
namespace RestaurantManagementSystem
{
    public partial class CrystalReportForm : Form
    {
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        RestaurantManagementContext db = new RestaurantManagementContext();
        int table_id;

        public CrystalReportForm(int table_idd)
        {
            table_id = table_idd;

            InitializeComponent();

            Table table = db.tables.Find(table_id);
            Commande cmd = db.commandes.Where(s => s.table_id == table.num_table).SingleOrDefault();
            //Ligne_Commande_Plat lcc = db.lignes_commandes_plats.Where(s=>s.commande_id==cmd.num_commande).;
            double total=0;
            Serveur serveur = db.serveurs.Find(db.affectations.Where(a=>a.table_id==table.num_table).SingleOrDefault().serveur_id);

            //bill
            DataTable bill = new DataTable();
            bill.Columns.Add("Plats");
            bill.Columns.Add("quantite");
            bill.Columns.Add("prix total");
            bill.Columns.Add("table id");
            bill.Columns.Add("serveur id");
            bill.Columns.Add("Total");

            bill.Rows.Add("7ouuut",200,32,1,2,324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            /*
            if (cmd != null) //si table a une commande pour afficher sur datatable
            {
                //calculate total
                db.lignes_commandes_plats.ToList().ForEach(
                    lc => { if (lc.commande_id == cmd.num_commande) {total += lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire;}}
                );

                //ligne cmd
                db.lignes_commandes_plats.ToList().ForEach(
                    lc => {
                        if (lc.commande_id == cmd.num_commande)
                        {
                            bill.Rows.Add(
                                db.plats.Find(lc.plat_id).libelle,
                                lc.quantite,
                                lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire,
                                table_id,
                                serveur.code_serveur,
                                total
                            );
                            
                        }
                    }
                );
            }


            */

            //meta data about bill
            DataTable bill_meta = new DataTable();
            bill_meta.Columns.Add("Table Number");
            bill_meta.Columns.Add("Serveur Name");
            bill_meta.Columns.Add("Serveur Id");

            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);

            string name = serveur.nom + " " + serveur.prenom;
            //bill_meta.Rows.Add(table_id, name ,serveur.code_serveur);


            CrystalReport2 report = new CrystalReport2();
            report.Database.Tables["bill"].SetDataSource(bill);
            report.Database.Tables["bill_meta"].SetDataSource(bill_meta);

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;

        }

        private void CrystalReportForm_Load(object sender, EventArgs e){


            Table table = db.tables.Find(table_id);
            Commande cmd = db.commandes.Where(s => s.table_id == table.num_table).SingleOrDefault();
            //Ligne_Commande_Plat lcc = db.lignes_commandes_plats.Where(s=>s.commande_id==cmd.num_commande).;
            double total = 0;
            Serveur serveur = db.serveurs.Find(db.affectations.Where(a => a.table_id == table.num_table).SingleOrDefault().serveur_id);

            //bill
            DataTable bill = new DataTable();
            bill.Columns.Add("Plats");
            bill.Columns.Add("quantite");
            bill.Columns.Add("prix total");
            bill.Columns.Add("table id");
            bill.Columns.Add("serveur id");
            bill.Columns.Add("Total");

            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            bill.Rows.Add("7ouuut", 200, 32, 1, 2, 324);
            /*
            if (cmd != null) //si table a une commande pour afficher sur datatable
            {
                //calculate total
                db.lignes_commandes_plats.ToList().ForEach(
                    lc => { if (lc.commande_id == cmd.num_commande) {total += lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire;}}
                );

                //ligne cmd
                db.lignes_commandes_plats.ToList().ForEach(
                    lc => {
                        if (lc.commande_id == cmd.num_commande)
                        {
                            bill.Rows.Add(
                                db.plats.Find(lc.plat_id).libelle,
                                lc.quantite,
                                lc.quantite * db.plats.Find(lc.plat_id).prix_unitaire,
                                table_id,
                                serveur.code_serveur,
                                total
                            );
                            
                        }
                    }
                );
            }


            */

            //meta data about bill
            DataTable bill_meta = new DataTable();
            bill_meta.Columns.Add("Table Number");
            bill_meta.Columns.Add("Serveur Name");
            bill_meta.Columns.Add("Serveur Id");

            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);
            bill_meta.Rows.Add(1, "aadf", 234);

            string name = serveur.nom + " " + serveur.prenom;
            //bill_meta.Rows.Add(table_id, name ,serveur.code_serveur);


            CrystalReport2 report = new CrystalReport2();
            report.Database.Tables["bill"].SetDataSource(bill);
            report.Database.Tables["bill_meta"].SetDataSource(bill_meta);

            //crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            //crystalReportViewer1.Refresh();
        }

    }
}
