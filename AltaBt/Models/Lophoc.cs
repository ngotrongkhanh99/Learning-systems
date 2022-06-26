using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Lophoc
    {
        [Key]
        public int IdLophoc { get; set; }
        public string Malop { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthuc { get; set; }
        public int trangthai { get; set; }
        public string Maphonghoc { get; set; }
        public string Giangvien { get; set; }
    }
}
