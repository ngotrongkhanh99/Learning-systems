using System.ComponentModel.DataAnnotations;

namespace AltaBt.Models
{
    public class Test
    {
        public int subjectId { get; set; }
        public int ClassId { get; set; }
        //[Key]
       // public int testID { get; set; }
        public string subjectName { get; set; }
        public string NameHV { get; set; }
        public Student Student { get; set; }
        public string NameGV { get; set; }
        public Teacher Teacher { get; set; }
        public string Time { get; set; }
        public string upcoming_test { get; set; }
        public string test_score { get; set; }
        public string status { get; set; }
        public string test { get; set; }
        /// <summary>
        //[Key]
        /// </summary>
        //public int TestID { get; set; }
        [Key]
        public int TestId { get; set; }

    }
}
