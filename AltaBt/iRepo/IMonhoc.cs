using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IMonhoc
    {
        IEnumerable<Monhoc> getAll();
        Monhoc get(int IdMonhoc);
        public void create(Monhoc Sj);
        public void update(Monhoc Sj);
        public void delete(int IdMonhoc);
    }
}
