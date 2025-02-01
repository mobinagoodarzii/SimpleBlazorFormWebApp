using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ClientDto
    {
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; } = 0;

        [Required]
        public string Education { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Phone]
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
