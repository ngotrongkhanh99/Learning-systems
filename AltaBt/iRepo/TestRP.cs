using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class TestRP : ITest
    {
        private readonly DataContext _dataContext;
        public TestRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(Baikiemtra test)
        {
            _dataContext.Baikiemtra.Add(test);
            _dataContext.SaveChanges();
        }

        public void delete(int TestId)
        {
            var p = _dataContext.Baikiemtra.FirstOrDefault(x => x.IdKiemtra == TestId);
            _dataContext.Baikiemtra.Remove(p);
            _dataContext.SaveChanges();
        }

        public Baikiemtra get(int TestId)
        {
            return _dataContext.Baikiemtra.FirstOrDefault(x => x.IdKiemtra == TestId);
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
