using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
namespace FlyAway.Models
{
    public class AeroportOfficielViemModel
    {
        FlyAwayDataEntities db = new FlyAwayDataEntities();
        public IEnumerable<string> SelectedAeroport { get; set; }
        public IEnumerable<SelectListItem> Aeroport { get; set; }
        public AeroportOfficielViemModel()
        {
            Aeroport = new List<SelectListItem>();
        }


        private void Remplir()
        {
            foreach (var city in db.AeroportOfficiel)
            {

            }
        }
        //[Key]
        //public int Id { get; set; }
        //public string Pays { get; set; }

        //public string Aeroport { get; set; }

        //public string Ville { get; set; }
        //private string pays;
        //private string aeroport;
        //private string ville;

        //public AeroportOfficiel(int id, string pays, string aeroport, string ville)
        //{
        //    this.Id = id;
        //    this.Pays = pays;
        //    this.Aeroport = aeroport;
        //    this.Ville = ville;
        //}

        //public AeroportOfficiel()
        //{

        //}
    }
}