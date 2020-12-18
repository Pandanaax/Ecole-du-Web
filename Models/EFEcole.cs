namespace WebApplicationEcoleWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFEcole : DbContext
    {
        // Your context has been configured to use a 'EFEcole' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplicationEcoleWeb.Models.EFEcole' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EFEcole' 
        // connection string in the application configuration file.
        public EFEcole()
            : base("name=EFEcole")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Stagiaire> Stagiaires { get; set; }
        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Anonyme> Anonymes { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}