using AltaBt.Models;
using Microsoft.EntityFrameworkCore;

namespace AltaBt.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Lophoc> Lophoc { get; set; }
        public DbSet<Khoahoc> Khoahoc { get; set; }
        public DbSet<Bangdiem> Bangdiem { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Monhoc> Monhoc { get; set; }
        public DbSet<Baikiemtra> Baikiemtra { get; set; }


    }
}
