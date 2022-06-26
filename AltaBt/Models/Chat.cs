using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public Lophoc Class { get; set; }
        public int ClassId { get; set; }
    }
}
