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
        public void create(Test test)
        {
            _dataContext.tests.Add(test);
            _dataContext.SaveChanges();
        }

        public void delete(int TestId)
        {
            var p = _dataContext.tests.FirstOrDefault(x => x.TestId == TestId);
            _dataContext.tests.Remove(p);
            _dataContext.SaveChanges();
        }

        public Test get(int TestId)
        {
            return _dataContext.tests.FirstOrDefault(x => x.TestId == TestId);
        }

        public IEnumerable<Test> getAll()
        {
            return _dataContext.tests.ToList();
        }

        public void update(Test test)
        {
            _dataContext.tests.Update(test);
            _dataContext.SaveChanges();
        }
    }
}
