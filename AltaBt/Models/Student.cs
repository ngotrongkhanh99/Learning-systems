using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Student
    {
        [Key]
        public string UsernameHV { get; set; }
        public string PasswordHV { get; set; }
        public string NameHV { get; set; }
        public int active { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
