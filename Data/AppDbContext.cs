using Microsoft.EntityFrameworkCore;
using MobilePhoneRegistrationMVC.Models;

namespace MobilePhoneRegistrationMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PhoneRegistration> PhoneRegistrations { get; set; }
    }
}
