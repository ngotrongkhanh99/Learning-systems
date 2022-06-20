using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IPower
    {

        IEnumerable<Power> getAll();
        Power get(int id);
        public void create(Power power);
        public void update( Power power);
        public void delete(int id);
    }
}

