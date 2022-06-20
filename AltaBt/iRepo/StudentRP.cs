using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class StudentRP : IStudent
    {
        private readonly DataContext _dataContext;
        public StudentRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Student Std)
        {
            _dataContext.Students.Add(Std);
            _dataContext.SaveChanges();
        }

        public void delete(string UsernameHV)
        {
            var p = _dataContext.Students.FirstOrDefault(x => x.UsernameHV == UsernameHV);
            _dataContext.Students.Remove(p);
            _dataContext.SaveChanges();
        }

        public Student get(string UsernameHV)
        {
            return _dataContext.Students.FirstOrDefault(x => x.UsernameHV == UsernameHV);
        }

        public IEnumerable<Student> getAll()
        {
            return _dataContext.Students.ToList();
        }

        public void update(Student Std)
        {
            _dataContext.Students.Update(Std);
            _dataContext.SaveChanges();
        }
    }
}
