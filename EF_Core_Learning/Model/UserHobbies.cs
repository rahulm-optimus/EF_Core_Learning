using System.ComponentModel.DataAnnotations;

namespace EF_Core_Learning.Model
{
    public class UserHobbies()
    {
        [Key]
        public int HobbiesId { get; set; }
        [Required]
        public string HobbiesName { get; set; }


    }
}