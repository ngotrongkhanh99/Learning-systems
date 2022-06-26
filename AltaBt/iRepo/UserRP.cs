using AltaBt.DBContext;
using AltaBt.Models;

namespace AltaBt.iRepo
{
    public class UserRP : IUser
    {
        private readonly DataContext _dataContext;
        public UserRP(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void create(User Std)
        {
            _dataContext.User.Add(Std);
            _dataContext.SaveChanges();
        }

        public void delete(string UsernameHV)
        {
            var p = _dataContext.User.FirstOrDefault(x => x.TaikhoanHV == UsernameHV);
            _dataContext.User.Remove(p);
            _dataContext.SaveChanges();
        }

        public User get(string UsernameHV)
        {
            return _dataContext.User.FirstOrDefault(x => x.TaikhoanHV == UsernameHV);
        }

        public IEnumerable<User> getAll()
        {
            return _dataContext.User.ToList();
        }

        public void update(User Std)
        {
            _dataContext.User.Update(Std);
            _dataContext.SaveChanges();
        }
    }
}
