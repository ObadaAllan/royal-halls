using System;
using System.Collections.Generic;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class HallsTime
    {
        public decimal Id { get; set; }
        public decimal? HallId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string FullDate { get; set; }
        public string TimeFromto { get; set; }

        public virtual Hall Hall { get; set; }
    }
}
