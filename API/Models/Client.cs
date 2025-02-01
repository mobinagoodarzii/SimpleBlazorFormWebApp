using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Index("Email", IsUnique = true)]
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; } = 0;
        public string Education { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
