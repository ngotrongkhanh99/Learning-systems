using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Bangdiem
    {
        [Key]
        public int IdBangdiem { get; set; }
        public string SoDiem { get; set; }
        public string Nhanxet { get; set; }
        public Lophoc Lophoc { get; set; }
        public Monhoc Monhoc { get; set; }
        public int IdMonhoc { get; set; }
        public string Trangthai { get; set; }
        public string TenHV { get; set; }
    }
}
