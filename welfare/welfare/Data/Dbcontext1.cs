using Microsoft.EntityFrameworkCore;
using welfare.Models;


namespace welfare.Data
{
    public class Dbcontext1 : DbContext
    {
        public Dbcontext1(DbContextOptions<Dbcontext1>options):base(options)
        {
            
        }

        public DbSet<RegisterModel> registrations { get; set; }
        //public DbSet<loginModel> logins { get; set; }

        public DbSet<contact> contacts { get; set; }
    }
}
