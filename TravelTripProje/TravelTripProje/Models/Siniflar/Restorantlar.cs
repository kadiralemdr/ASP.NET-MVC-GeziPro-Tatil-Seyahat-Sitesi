using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Restorantlar
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Konum { get; set; }
        public string RestorantImage { get; set; }
    }
}