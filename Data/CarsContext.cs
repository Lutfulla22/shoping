using Microsoft.EntityFrameworkCore;
using shop.Entities;

namespace shop.Data
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarsContext(DbContextOptions options)
            : base(options) { }
    }
}