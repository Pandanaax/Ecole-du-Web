using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Data
{
    public class WebApplicationEcoleWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplicationEcoleWebContext() : base("name=WebApplicationEcoleWebContext")
        {
        }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Administrateur> Administrateurs { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Compte> Comptes { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Anonyme> Anonymes { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Formation> Formations { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Module> Modules { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Stagiaire> Stagiaires { get; set; }

        public System.Data.Entity.DbSet<WebApplicationEcoleWeb.Models.Personne> Personnes { get; set; }
    }
}
