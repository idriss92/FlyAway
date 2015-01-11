 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlyAway.Models
{
    public class VolModel
    {

        public FlyAway.Vols Vols { get; set; }
    //    //[Required]
    //    [Key]
    //    public int Id { get; set; }
    //    public string Depart { get; set; }
    //    public string  Arrivee { get; set; }
    ////    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    //    public DateTime DepartHeure { get; set; }
    ////    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    //    public DateTime ArriveeHeure { get; set; }
    //    public int Distance { get; set; }
    //    public int Prix { get; set; }

    //    public Vol(string depart, string arrivee, DateTime departHeure, DateTime arriveeHeure, int distance, int prix)
    //    {
    //        Depart = depart;
    //        Arrivee = arrivee;
    //        DepartHeure = departHeure;
    //        ArriveeHeure = arriveeHeure;
    //        Distance = distance;
    //        Prix = prix;
    //    }

    //    public Vol()
    //    {

    //    }

    }


    //public class FlyAwayDb : DbContext
    //{
    //    public DbSet<Vol> Vols { get; set; }
    //    public DbSet<Reservation> Reservations { get; set; }
    //    public DbSet<AeroportOfficiel> AeroportOfficiel { get; set; }
    //}
}