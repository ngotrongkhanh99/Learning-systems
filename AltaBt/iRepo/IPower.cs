using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IPower
    {

        IEnumerable<Bangdiem> getAll();
        Bangdiem get(int id);
        public void create(Bangdiem power);
        public void update( Bangdiem power);
        public void delete(int id);
    }
}

