using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IBangdiem
    {

        IEnumerable<Bangdiem> getAll();
        Bangdiem get(int IdBangdiem);
        public void create(Bangdiem power);
        public void update( Bangdiem power);
        public void delete(int IdBangdiem);
    }
}

