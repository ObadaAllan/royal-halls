using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class Hall
    {
        public Hall()
        {
            HallsTimes = new HashSet<HallsTime>();
            Reservations = new HashSet<Reservation>();
        }

        public decimal HId { get; set; }
        [DisplayName("Hall Name")]
        [Required]


        public string HName { get; set; }

        [DisplayName("Hall Description")]
        [Required]

        public string HDescription { get; set; }
        [DisplayName("Hall Address")]
        [Required]

        public string HAddress { get; set; }
        [DisplayName("Hall Photo")]

        public string HPhoto { get; set; }
        [NotMapped]
        public IFormFile HImageFile { get; set; }

        [DisplayName("Hall price")]
        [Required]

        public decimal HPrice { get; set; }


        public virtual ICollection<HallsTime> HallsTimes { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
