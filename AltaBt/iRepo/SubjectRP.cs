using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class SubjectRP : ISubject
    {
        private readonly DataContext _dataContext;
        public SubjectRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Subject Sj)
        {
            _dataContext.Subjects.Add(Sj);
            _dataContext.SaveChanges();
        }

        public void delete(int subjectID)
        {
            var p = _dataContext.Subjects.FirstOrDefault(x => x.subjectID == subjectID);
            _dataContext.Subjects.Remove(p);
            _dataContext.SaveChanges();
        }

        public Subject get(int subjectID)
        {
            return _dataContext.Subjects.FirstOrDefault(x => x.subjectID == subjectID);
        }

        public IEnumerable<Subject> getAll()
        {
            return _dataContext.Subjects.ToList();
        }

        public void update(Subject Sj)
        {
            _dataContext.Subjects.Update(Sj);
            _dataContext.SaveChanges();
        }
    }
}




