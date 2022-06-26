using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class MonhocRP : IMonhoc
    {
        private readonly DataContext _dataContext;
        public MonhocRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Monhoc Sj)
        {
            _dataContext.Monhoc.Add(Sj);
            _dataContext.SaveChanges();
        }

        public void delete(int IdMonhoc)
        {
            var p = _dataContext.Monhoc.FirstOrDefault(x => x.IdMonhoc == IdMonhoc);
            _dataContext.Monhoc.Remove(p);
            _dataContext.SaveChanges();
        }

        public Monhoc get(int IdMonhoc)
        {
            return _dataContext.Monhoc.FirstOrDefault(x => x.IdMonhoc == IdMonhoc);
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




