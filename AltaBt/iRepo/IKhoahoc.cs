using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IKhoahoc
    {
        IEnumerable<Khoahoc> getAll();
        Khoahoc get(int IdKhoa);
        public void create(Khoahoc kh);
        public void update(Khoahoc kh);
        public void delete(int IdKhoa);
    }
}
