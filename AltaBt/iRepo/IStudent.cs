using AltaBt.Models;

namespace AltaBt.iRepo
{
    public interface IStudent
    {
        IEnumerable<User> getAll();
        User get(string UsernameHV);
        public void create (User Std);
        public void update ( User Std);
        public void delete (string UsernameHV);
    }
}
