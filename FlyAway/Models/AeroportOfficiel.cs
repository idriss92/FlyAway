using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace FlyAway.Models
{
    public class AeroportOfficiel
    {
        [Key]
        public int Id { get; set; }
        public string Pays { get; set; }

        public string Aeroport { get; set; }

        public string Ville { get; set; }
        private string pays;
        private string aeroport;
        private string ville;

        public AeroportOfficiel(string pays, string aeroport, string ville)
        {
            this.pays = pays;
            this.aeroport = aeroport;
            this.ville = ville;
        }

         public AeroportOfficiel()
         {

         }
    }
}