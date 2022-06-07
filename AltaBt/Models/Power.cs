using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Power
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
