using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestaurantManagementSystem.Model;

namespace RestaurantManagementSystem
{
    class RestaurantManagementContext : DbContext
    {

        public DbSet<Plat> plats { get; set; }
        public DbSet<Serveur> serveurs { get; set; }
        public DbSet<Table> tables { get; set; }
        public DbSet<Commande> commandes { get; set; }
        public DbSet<Affecter> affectations { get; set; }
        public DbSet<Ligne_Commande_Plat> lignes_commandes_plats { get; set; }


        public RestaurantManagementContext() : base(nameOrConnectionString: "PGConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        } 

    }
}
