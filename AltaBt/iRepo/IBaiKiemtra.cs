using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IBaiKiemtra
    {
        IEnumerable<Baikiemtra> getAll();
        Baikiemtra get(int IdKiemtra);
        public void create(Baikiemtra test);
        public void update(Baikiemtra test);
        public void delete(int IdKiemtra);
    }
}
