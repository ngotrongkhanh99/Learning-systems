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
        public void create(Monhoc Sj)
        {
            _dataContext.Monhoc.Add(Sj);
            _dataContext.SaveChanges();
        }

        public void delete(int subjectID)
        {
            var p = _dataContext.Monhoc.FirstOrDefault(x => x.IdMonhoc == subjectID);
            _dataContext.Monhoc.Remove(p);
            _dataContext.SaveChanges();
        }

        public Monhoc get(int subjectID)
        {
            return _dataContext.Monhoc.FirstOrDefault(x => x.IdMonhoc == subjectID);
        }

        public IEnumerable<Monhoc> getAll()
        {
            return _dataContext.Monhoc.ToList();
        }

        public void update(Monhoc Sj)
        {
            _dataContext.Monhoc.Update(Sj);
            _dataContext.SaveChanges();
        }
    }
}




