using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationEcoleWeb.Models
{       
    public class Administrateur 
        
    {
        [Key]
        public int Id { get; set; }
        public string Pseudo { get; set; }
    }
}