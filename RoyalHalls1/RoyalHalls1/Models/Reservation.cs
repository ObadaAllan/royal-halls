using System;
using System.Collections.Generic;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class Reservation
    {
        public decimal Id { get; set; }
        public decimal? UsersId { get; set; }
        public decimal? HallsId { get; set; }
        public DateTime? Datefrom { get; set; }
        public string FullTime { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime? Dateto { get; set; }

        public virtual Hall Halls { get; set; }
        public virtual User Users { get; set; }
    }
}
