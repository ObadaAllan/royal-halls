using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class About
    {
        public decimal Id { get; set; }
        public string Title { get; set; }
        public string Descriotion { get; set; }
        [NotMapped]
        public IFormFile Aboutphoto { get; set; }
        public string Photo { get; set; }
    }
}
