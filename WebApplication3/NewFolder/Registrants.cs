using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using WebApplication3.ValidationFilter;

namespace WebApplication3.NewFolder
{

    public class Registrants
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "About Yourself is required.")]
        [StringLength(250, ErrorMessage = "About Yourself must be less than or equal to 250 characters.")]
        public string AboutYourself { get; set; }

        [Required(ErrorMessage = "Photo is required.")]
        [MaxFileSize(250 * 1024, ErrorMessage = "Photo size cannot exceed 250KB.")]
        public IFormFile Photo { get; set; }
    }

}
