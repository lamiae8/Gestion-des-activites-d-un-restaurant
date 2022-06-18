namespace RestaurantManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restaudbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.affecter",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date_affectation = c.DateTime(nullable: false),
                        table_id = c.Int(nullable: false),
                        serveur_id = c.Int(nullable: false),
                        Serveur_code_serveur = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.serveur", t => t.Serveur_code_serveur)
                .Index(t => t.Serveur_code_serveur);
            
            CreateTable(
                "public.commande",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date_enregistrement = c.DateTime(nullable: false),
                        date_paiement = c.DateTime(nullable: false),
                        mode_paiement = c.String(),
                        nombre_personne = c.Int(nullable: false),
                        table_num_table = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public._tables", t => t.table_num_table)
                .Index(t => t.table_num_table);
            
            CreateTable(
                "public._tables",
                c => new
                    {
                        num_table = c.Int(nullable: false, identity: true),
                        nombre_place = c.Int(nullable: false),
                        reserved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.num_table);
            
            CreateTable(
                "public.ligne_commande_plat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantite = c.Int(nullable: false),
                        commande_num_commande = c.Int(),
                        plat_code_plat = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.commande", t => t.commande_num_commande)
                .ForeignKey("public.plat", t => t.plat_code_plat)
                .Index(t => t.commande_num_commande)
                .Index(t => t.plat_code_plat);
            
            CreateTable(
                "public.plat",
                c => new
                    {
                        code_plat = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                        type = c.String(),
                        prix_unitaire = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.code_plat);
            
            CreateTable(
                "public.serveur",
                c => new
                    {
                        code_serveur = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        prenom = c.String(),
                    })
                .PrimaryKey(t => t.code_serveur);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.affecter", "Serveur_code_serveur", "public.serveur");
            DropForeignKey("public.ligne_commande_plat", "plat_code_plat", "public.plat");
            DropForeignKey("public.ligne_commande_plat", "commande_num_commande", "public.commande");
            DropForeignKey("public.commande", "table_num_table", "public._tables");
            DropIndex("public.ligne_commande_plat", new[] { "plat_code_plat" });
            DropIndex("public.ligne_commande_plat", new[] { "commande_num_commande" });
            DropIndex("public.commande", new[] { "table_num_table" });
            DropIndex("public.affecter", new[] { "Serveur_code_serveur" });
            DropTable("public.serveur");
            DropTable("public.plat");
            DropTable("public.ligne_commande_plat");
            DropTable("public._tables");
            DropTable("public.commande");
            DropTable("public.affecter");
        }
    }
}
