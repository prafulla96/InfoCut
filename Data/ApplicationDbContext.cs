using Microsoft.EntityFrameworkCore;
using InfoCut.Models;

namespace InfoCut.Data
{
    
public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SignUp> SignUps { get; set; }
    
    }

}