using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface ITest
    {
        IEnumerable<Baikiemtra> getAll();
        Baikiemtra get(int TestId);
        public void create(Baikiemtra test);
        public void update(Baikiemtra test);
        public void delete(int TestId);
    }
}
