using System.ComponentModel.DataAnnotations;

namespace EF_Core_Learning.Model
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public UserPasswords Passwords { get; set; }

        
    }
}
