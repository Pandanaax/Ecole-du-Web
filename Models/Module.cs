using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Duree { get; set; }
        public string Resumer { get; set; }
        public string Logo { get; set; }
        public string Chapitre { get; set; }
        public string Objectifs { get; set; }
        public string PreRequis { get; set; }
    }
}