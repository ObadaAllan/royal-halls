using System;
using System.Collections.Generic;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class Payment
    {
        public decimal Id { get; set; }
        public decimal? UserId { get; set; }
        public string CardName { get; set; }
        public decimal? Cvv { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? Ballance { get; set; }

        public virtual User User { get; set; }
    }
}
