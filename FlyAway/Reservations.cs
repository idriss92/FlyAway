//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlyAway
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservations
    {
        public int Id { get; set; }
        public string Depart { get; set; }
        public string Arrivee { get; set; }
        public System.DateTime DepartHeure { get; set; }
        public System.DateTime ArriveeHeure { get; set; }
        public int Distance { get; set; }
        public int Prix { get; set; }
        public int NombreAdultes { get; set; }
    }
}
