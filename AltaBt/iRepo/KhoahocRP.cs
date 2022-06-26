using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class KhoahocRP : IKhoahoc
    {
        private readonly DataContext _dataContext;
        public KhoahocRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Baikiemtra bkt)
        {
            _dataContext.Baikiemtra.Add(bkt);
            _dataContext.SaveChanges();
        }

        public void create(Khoahoc kh)
        {
            throw new NotImplementedException();
        }

        public void delete(int IdKhoa)
        {
            var p = _dataContext.Khoahoc.FirstOrDefault(x => x.IdKhoa == IdKhoa);
            _dataContext.Khoahoc.Remove(p);
            _dataContext.SaveChanges();
        }

        public Khoahoc get(int IdKhoa)
        {
            return _dataContext.Khoahoc.FirstOrDefault(x => x.IdKhoa == IdKhoa);
        }

        public IEnumerable<Khoahoc> getAll()
        {
            return _dataContext.Khoahoc.ToList();
        }

        public void update(Baikiemtra bkt)
        {
            _dataContext.Baikiemtra.Update(bkt);
            _dataContext.SaveChanges();
        }

        public void update(Khoahoc kh)
        {
            throw new NotImplementedException();
        }
    }
}
