#nullable disable

namespace RoyalHalls1.Models
{
    public partial class Testimonial
    {
        public decimal Id { get; set; }
        public decimal? UserId { get; set; }
        public string Content { get; set; }
        public virtual User User { get; set; }

    }
}
