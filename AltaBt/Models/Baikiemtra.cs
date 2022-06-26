using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Baikiemtra
    {
        public string TenHV { get; set; }
        public Lophoc Lophoc { get; set; }
        public string TenGV { get; set; }
        public string Thoigian { get; set; }
        public string Diem { get; set; }
        public string Trangthai { get; set; }
        public string Tenbaikiemtra { get; set; }
        [Key]
        public int IdKiemtra { get; set; }

    }
}
