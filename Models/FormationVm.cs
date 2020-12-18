using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Models
{
    public class FormationVm
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Durée { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NombreInscrit { get; set; }
        public int idModule { get; set; }
    }
}