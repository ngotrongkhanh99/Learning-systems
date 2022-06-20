using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface ITeacher
    {
        IEnumerable<Teacher> getAll();
        Teacher get(string UsernameGV);
        public void create(Teacher t);
        public void update(Teacher t);
        public void delete(string UsernameGV);
    }
}
