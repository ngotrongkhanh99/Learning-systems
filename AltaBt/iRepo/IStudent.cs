using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IStudent
    {
        IEnumerable<Student> getAll();
        Student get(string UsernameHV);
        public void create (Student Std);
        public void update ( Student Std);
        public void delete (string UsernameHV);
    }
}
