using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace FlyAway.Models
{
    public class Reservation
    {

        public Vol vol;
        public int Id { get; set; }
        public string Depart { get; set; }
        public string Arrivee { get; set; }
        
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DepartHeure { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ArriveeHeure { get; set; }
        public int Distance { get; set; }
        public int Prix { get; set; }
        public int NombreAdultes { get; set; }

        public Reservation(Vol vol, int passager)
        {
            Depart = vol.Depart;
            Arrivee = vol.Arrivee;
            DepartHeure = vol.DepartHeure;
            ArriveeHeure = vol.ArriveeHeure;
            Distance = vol.Distance;
            Prix = vol.Prix;
            NombreAdultes = passager;
        }

        public Reservation()
        {

        }

        public Reservation(string depart, string arrivee, DateTime departHeure, DateTime arriveeHeure, int distance, int prix, int nombre)
        {
            Depart = depart;
            Arrivee = arrivee;
            DepartHeure = departHeure;
            ArriveeHeure = arriveeHeure;
            Distance = distance;
            Prix = prix;
            NombreAdultes = nombre;
        }
    }
}