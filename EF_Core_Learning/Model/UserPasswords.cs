using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Learning.Model
{
    public class UserPasswords
    {
        [Key]
        public int PasswordId { get; set; }

        public string Password { get; set; }

        [ForeignKey("Details")]
        public int UserId { get; set; }
        public UserDetails Details { get; set; }



    }
}
