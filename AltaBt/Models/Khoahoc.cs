using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Khoahoc
    {
        [Key]
        public int IdKhoa { get; set; }
        public Lophoc Lophoc { get; set; }
        public string Tenkhoa { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthuc { get; set; }

    }
}
