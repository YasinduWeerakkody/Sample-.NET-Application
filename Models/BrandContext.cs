using Microsoft.EntityFrameworkCore;

namespace crudApp.Models
{
    public class BrandContext : DbContext
    {

        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }


    }
}
