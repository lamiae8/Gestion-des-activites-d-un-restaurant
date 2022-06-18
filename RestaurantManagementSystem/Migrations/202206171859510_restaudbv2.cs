namespace RestaurantManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restaudbv2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.commande", "table_num_table", "public._tables");
            DropForeignKey("public.ligne_commande_plat", "commande_num_commande", "public.commande");
            DropForeignKey("public.ligne_commande_plat", "plat_code_plat", "public.plat");
            DropIndex("public.commande", new[] { "table_num_table" });
            DropIndex("public.ligne_commande_plat", new[] { "commande_num_commande" });
            DropIndex("public.ligne_commande_plat", new[] { "plat_code_plat" });
            AddColumn("public.commande", "table_id", c => c.Int(nullable: false));
            AddColumn("public.ligne_commande_plat", "plat_id", c => c.Int(nullable: false));
            AddColumn("public.ligne_commande_plat", "commande_id", c => c.Int(nullable: false));
            DropColumn("public.commande", "table_num_table");
            DropColumn("public.ligne_commande_plat", "commande_num_commande");
            DropColumn("public.ligne_commande_plat", "plat_code_plat");
        }
        
        public override void Down()
        {
            AddColumn("public.ligne_commande_plat", "plat_code_plat", c => c.Int());
            AddColumn("public.ligne_commande_plat", "commande_num_commande", c => c.Int());
            AddColumn("public.commande", "table_num_table", c => c.Int());
            DropColumn("public.ligne_commande_plat", "commande_id");
            DropColumn("public.ligne_commande_plat", "plat_id");
            DropColumn("public.commande", "table_id");
            CreateIndex("public.ligne_commande_plat", "plat_code_plat");
            CreateIndex("public.ligne_commande_plat", "commande_num_commande");
            CreateIndex("public.commande", "table_num_table");
            AddForeignKey("public.ligne_commande_plat", "plat_code_plat", "public.plat", "code_plat");
            AddForeignKey("public.ligne_commande_plat", "commande_num_commande", "public.commande", "id");
            AddForeignKey("public.commande", "table_num_table", "public._tables", "num_table");
        }
    }
}
