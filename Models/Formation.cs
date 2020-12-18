using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Models
{
    public class Formation
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Durée { get; set; }
        public List<Stagiaire> listStagiaires { get; set; }
        public List<Module> listModules { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NombreInscrit { get; set; }
    }
}