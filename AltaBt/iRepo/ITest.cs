using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface ITest
    {
        IEnumerable<Test> getAll();
        Test get(int TestId);
        public void create(Test test);
        public void update(Test test);
        public void delete(int TestId);
    }
}
