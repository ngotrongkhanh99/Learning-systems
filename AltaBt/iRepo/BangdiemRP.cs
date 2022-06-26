using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class BangdiemRP : IBangdiem
    {
        private readonly DataContext _dataContext;
        public BangdiemRP(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }
        public void create(Bangdiem power)
        {
            _dataContext.Bangdiem.Add(power);
            _dataContext.SaveChanges();
        }

        public void delete(int IdBangdiem)
        {
            var p = _dataContext.Bangdiem.FirstOrDefault(x => x.IdBangdiem == IdBangdiem);
            _dataContext.Bangdiem.Remove(p) ;
            _dataContext.SaveChanges() ;
        }

        public Bangdiem get(int IdBangdiem)
        {
            return _dataContext.Bangdiem.FirstOrDefault(x=>x.IdBangdiem == IdBangdiem);
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
