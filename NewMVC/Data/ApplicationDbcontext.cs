using Microsoft.EntityFrameworkCore;
using NewMVC.Models;

namespace NewMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
    }
}

    
