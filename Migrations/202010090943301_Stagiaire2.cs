namespace WebApplicationEcoleWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stagiaire2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Modules", "Formation_Id", "dbo.Formations");
            DropIndex("dbo.Modules", new[] { "Formation_Id" });
            CreateTable(
                "dbo.ModuleFormations",
                c => new
                    {
                        Module_Id = c.Int(nullable: false),
                        Formation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Module_Id, t.Formation_Id })
                .ForeignKey("dbo.Modules", t => t.Module_Id, cascadeDelete: true)
                .ForeignKey("dbo.Formations", t => t.Formation_Id, cascadeDelete: true)
                .Index(t => t.Module_Id)
                .Index(t => t.Formation_Id);
            
            DropColumn("dbo.Modules", "Formation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modules", "Formation_Id", c => c.Int());
            DropForeignKey("dbo.ModuleFormations", "Formation_Id", "dbo.Formations");
            DropForeignKey("dbo.ModuleFormations", "Module_Id", "dbo.Modules");
            DropIndex("dbo.ModuleFormations", new[] { "Formation_Id" });
            DropIndex("dbo.ModuleFormations", new[] { "Module_Id" });
            DropTable("dbo.ModuleFormations");
            CreateIndex("dbo.Modules", "Formation_Id");
            AddForeignKey("dbo.Modules", "Formation_Id", "dbo.Formations", "Id");
        }
    }
}
