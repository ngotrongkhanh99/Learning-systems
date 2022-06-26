using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class PowerRP : IPower
    {
        private readonly DataContext _dataContext;
        public PowerRP(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }
        public void create(Bangdiem power)
        {
            _dataContext.Bangdiem.Add(power);
            _dataContext.SaveChanges();
        }

        public void delete(int id)
        {
            var p = _dataContext.Bangdiem.FirstOrDefault(x => x.IdBangdiem == id);
            _dataContext.Bangdiem.Remove(p) ;
            _dataContext.SaveChanges() ;
        }

        public Bangdiem get(int id)
        {
            return _dataContext.Bangdiem.FirstOrDefault(x=>x.IdBangdiem == id);
        }

        public IEnumerable<Bangdiem> getAll()
        {
            return _dataContext.Bangdiem.ToList();
        }
        public void update(Bangdiem power)
        {
            _dataContext.Bangdiem.Update(power);
            _dataContext.SaveChanges();
        }

    }
}
