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
            InitializeComponent();
            double total=0;
            table_id = table_idd;

            Table table = db.tables.Find(table_id);
            Commande cmd = db.commandes.Where(s => s.table_id == table.num_table).SingleOrDefault();
            Serveur serveur = db.serveurs.Find(db.affectations.Where(a=>a.table_id==table.num_table).SingleOrDefault().serveur_id);

            //bill
            DataTable facture = new DataTable();
            facture.Columns.Add("Plats");
            facture.Columns.Add("quantite");
            facture.Columns.Add("prix total");
            facture.Columns.Add("table id");
            facture.Columns.Add("serveur id");
            facture.Columns.Add("Total");

            facture.Rows.Add("aaa",1,1,1,1,1);

            

            //meta data about bill
            DataTable facture_donnees = new DataTable();
            facture_donnees.Columns.Add("Table Number");
            facture_donnees.Columns.Add("Serveur Name");
            facture_donnees.Columns.Add("Serveur Id");

            facture_donnees.Rows.Add(1, "A", 2);


            CrystalReport2 report = new CrystalReport2();
            report.Database.Tables["bill"].SetDataSource(facture);
            report.Database.Tables["bill_meta"].SetDataSource(facture_donnees);

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;

        }

        private void CrystalReportForm_Load(object sender, EventArgs e) { }


    }
}
