using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class Home
    {
        public decimal Id { get; set; }
        [NotMapped]
        public IFormFile LogoImageFile { get; set; }

        public string LogoImage { get; set; }
        public string Title { get; set; }
        [DisplayName("Title Description")]

        public string Titledesc { get; set; }
        [NotMapped]
        public IFormFile SliderImageFile1 { get; set; }
        [DisplayName("First Slider Image")]


        public string SImage1 { get; set; }
        [NotMapped]
        public IFormFile SliderImageFile2 { get; set; }
        [DisplayName("Second Slider Image")]


        public string SImage2 { get; set; }

        [NotMapped]
        public IFormFile SliderImageFile3 { get; set; }
        [DisplayName("Third Slider Image")]


        public string SImage3 { get; set; }
        public string GalImg1 { get; set; }
        public string GalImg2 { get; set; }
        public string GalImg3 { get; set; }
        public string GalImg4 { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Medialink1 { get; set; }
        public string Medialink2 { get; set; }
        public string Medialink3 { get; set; }
    }
}
