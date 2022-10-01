using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class User
    {
        public User()
        {
            Payments = new HashSet<Payment>();
            Reservations = new HashSet<Reservation>();
        }

        public decimal Id { get; set; }

        [DisplayName("First name")]
        [Required]

        public string Fname { get; set; }
        [DisplayName("Last name")]

        public string Lname { get; set; }


        [DisplayName("User Name")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
        public string Username { get; set; }
        [DisplayName("Email")]


        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, ErrorMessage = "Must be between 5 and  50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]

        public string Email { get; set; }
        [DisplayName("Password")]

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Must be between 8 and 50 characters", MinimumLength = 8)]

        public string Userpassword { get; set; }
        public string Photo { get; set; }
        [NotMapped]

        public IFormFile ImageFile { get; set; }
        public decimal? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
