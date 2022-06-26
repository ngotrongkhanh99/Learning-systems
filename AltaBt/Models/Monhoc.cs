using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Monhoc
    {
        [Key]
        public int IdMonhoc { get; set; }
        public string Tenmonhoc { get; set; }
        public string Mamonhoc { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthuc { get; set; }
    }
}
