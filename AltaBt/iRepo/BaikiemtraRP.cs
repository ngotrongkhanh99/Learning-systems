using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class BaikiemtraRP : IBaiKiemtra
    {
        private readonly DataContext _dataContext;
        public BaikiemtraRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Baikiemtra test)
        {
            _dataContext.Baikiemtra.Add(test);
            _dataContext.SaveChanges();
        }

        public void delete(int IdKiemtra)
        {
            var p = _dataContext.Baikiemtra.FirstOrDefault(x => x.IdKiemtra == IdKiemtra);
            _dataContext.Baikiemtra.Remove(p);
            _dataContext.SaveChanges();
        }

        public Baikiemtra get(int IdKiemtra)
        {
            return _dataContext.Baikiemtra.FirstOrDefault(x => x.IdKiemtra == IdKiemtra);
        }

        public IEnumerable<Baikiemtra> getAll()
        {
            return _dataContext.Baikiemtra.ToList();
        }

        public void update(Baikiemtra test)
        {
            _dataContext.Baikiemtra.Update(test);
            _dataContext.SaveChanges();
        }
    }
}
