using System.ComponentModel.DataAnnotations;

namespace coreWebApplication.Models
{
    public class Account
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string  UserName { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string  WebSite { get; set; }
    }
}
