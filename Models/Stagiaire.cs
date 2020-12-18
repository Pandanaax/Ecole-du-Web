using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Models
{
    public class Stagiaire 
    {
        [Key]
        public int Id { get; set; }
        public string DateNaissance { get; set; }
        public string DateInscription { get; set; }
        public string AdressePostale { get; set; }
        public enum Statut
        {
            [Description("Attente Inscription")]
            attenteInscription,
            [Description("Inscription en cours")]
            inscriptionEnCours,
            [Description("Inscription finalisé")]
            InscriptionFinalise,
            [Description("En cours de formation")]
            EnCoursFormation,
            [Description("Terminer sa formation")]
            TerminerFormation,
            [Description("Autre")]
            Autre,
        }
        public Statut StatutInscription { get; set; }
        public string SessionSouhaite { get; set; }
    }
}