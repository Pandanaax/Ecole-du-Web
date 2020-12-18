namespace WebApplicationEcoleWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stagiaire : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pseudo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Anonymes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Durée = c.String(),
                        DateDebut = c.String(),
                        DateFin = c.String(),
                        NombreInscrit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Duree = c.String(),
                        Resumer = c.String(),
                        Logo = c.String(),
                        Chapitre = c.String(),
                        Objectifs = c.String(),
                        PreRequis = c.String(),
                        Formation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formations", t => t.Formation_Id)
                .Index(t => t.Formation_Id);
            
            CreateTable(
                "dbo.Stagiaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        DateNaissance = c.String(),
                        DateInscription = c.String(),
                        AdressePostale = c.String(),
                        StatutInscription = c.Int(nullable: false),
                        SessionSouhaite = c.String(),
                        Formation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formations", t => t.Formation_Id)
                .Index(t => t.Formation_Id);
            
            CreateTable(
                "dbo.PersonneComptes",
                c => new
                    {
                        Personne_Id = c.Int(nullable: false),
                        Compte_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Personne_Id, t.Compte_Id })
                .ForeignKey("dbo.Personnes", t => t.Personne_Id, cascadeDelete: true)
                .ForeignKey("dbo.Comptes", t => t.Compte_Id, cascadeDelete: true)
                .Index(t => t.Personne_Id)
                .Index(t => t.Compte_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stagiaires", "Formation_Id", "dbo.Formations");
            DropForeignKey("dbo.Modules", "Formation_Id", "dbo.Formations");
            DropForeignKey("dbo.PersonneComptes", "Compte_Id", "dbo.Comptes");
            DropForeignKey("dbo.PersonneComptes", "Personne_Id", "dbo.Personnes");
            DropIndex("dbo.PersonneComptes", new[] { "Compte_Id" });
            DropIndex("dbo.PersonneComptes", new[] { "Personne_Id" });
            DropIndex("dbo.Stagiaires", new[] { "Formation_Id" });
            DropIndex("dbo.Modules", new[] { "Formation_Id" });
            DropTable("dbo.PersonneComptes");
            DropTable("dbo.Stagiaires");
            DropTable("dbo.Modules");
            DropTable("dbo.Formations");
            DropTable("dbo.Personnes");
            DropTable("dbo.Comptes");
            DropTable("dbo.Anonymes");
            DropTable("dbo.Administrateurs");
        }
    }
}
