
using Entities;
using Microsoft.EntityFrameworkCore;


namespace Dateapp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DataContext(DbSet<AppUser> users)
        {
            Users = users;
        }

        protected DataContext()
        {
        }

        public DbSet<Entities.AppUser> Users { get; set; }
    }
}