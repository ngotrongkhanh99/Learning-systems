using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string Discription { get; set; }
        public int numberday { get; set; }
        public string Time { get; set; }
        public DateTime start_day { get; set; }
        public DateTime end_day { get; set; }
        public string Link { get; set; }
        public string PassClass { get; set; }
        public string Security { get; set; }
        public int status { get; set; }
        public Teacher Teacher { get; set; }
        public string UsernameGV { get; set; }
        public Student Student { get; set; }
        public string UsernameHV { get; set; }
        public Subject Subject { get; set; }
        public int subjectID { get; set; }
        public int TestId { get; set; }
    }
}
