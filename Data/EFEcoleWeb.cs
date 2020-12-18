namespace WebApplicationEcoleWeb.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplicationEcoleWeb.Models;

    public class EFEcoleWeb : DbContext
    {
        // Your context has been configured to use a 'EFEcoleWeb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplicationEcoleWeb.Data.EFEcoleWeb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EFEcoleWeb' 
        // connection string in the application configuration file.
        public EFEcoleWeb()
            : base("name=EFEcoleWeb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Stagiaire> Stagiaires { get; set; }
        public virtual DbSet<Anonyme> Anonymes { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Administrateur> Administrateurs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}