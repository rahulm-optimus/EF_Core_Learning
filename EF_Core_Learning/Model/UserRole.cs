using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Learning.Model
{
    public class UserRole
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [ForeignKey("Details")]
        public int UserId { get; set; }
        public UserDetails Details { get; set; }
    }
}
