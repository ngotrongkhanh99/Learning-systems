using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Teacher
    {
        [Key]
        public string UsernameGV { get; set; }
        public string PasswordGV { get; set; }
        public string NameGV { get; set; }
        public int active { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Bangdiem Power { get; set; }
        public int Id { get; set; }
    }
}
