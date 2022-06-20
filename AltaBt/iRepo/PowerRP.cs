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
        public void create(Power power)
        {
            _dataContext.Powers.Add(power);
            _dataContext.SaveChanges();
        }

        public void delete(int id)
        {
            var p = _dataContext.Powers.FirstOrDefault(x => x.Id == id);
            _dataContext.Powers.Remove(p) ;
            _dataContext.SaveChanges() ;
        }

        public Power get(int id)
        {
            return _dataContext.Powers.FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<Power> getAll()
        {
            return _dataContext.Powers.ToList();
        }
        public void update(Power power)
        {
            _dataContext.Powers.Update(power);
            _dataContext.SaveChanges();
        }

    }
}
