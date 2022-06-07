using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Subject
    {
        [Key]
        public int subjectID { get; set; }
        public string subjectName { get; set; }
        public DateTime schedule { get; set; }
        public string Time { get; set; }
        public string Discription { get; set; }
    }
}
