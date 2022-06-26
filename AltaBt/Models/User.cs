using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        public string TaikhoanHV { get; set; }
        public string MatkhauHV { get; set; }
        public string TenHV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
