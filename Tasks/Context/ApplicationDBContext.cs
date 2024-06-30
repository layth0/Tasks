using Microsoft.EntityFrameworkCore;
using Tasks.Models;

namespace Tasks.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { }

        public DbSet<Products> Products { get; set; }

    }
}
