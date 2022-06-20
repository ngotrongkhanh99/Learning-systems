using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class TeacherRP : ITeacher
    {
        private readonly DataContext _dataContext;
        public TeacherRP (DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Teacher t)
        {
            _dataContext.Teachers.Add(t);
            _dataContext.SaveChanges();
        }

        public void delete(string UsernameGV)
        {
            var p = _dataContext.Teachers.FirstOrDefault(x => x.UsernameGV == UsernameGV);
            _dataContext.Teachers.Remove(p);
            _dataContext.SaveChanges();
        }

        public Teacher get(string UsernameGV)
        {
            return _dataContext.Teachers.FirstOrDefault(x => x.UsernameGV == UsernameGV);
        }

        public IEnumerable<Teacher> getAll()
        {
            return _dataContext.Teachers.ToList();
        }

        public void update(Teacher t)
        {
            _dataContext.Teachers.Update(t);
            _dataContext.SaveChanges();
        }
    }
}
