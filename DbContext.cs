using Microsoft.EntityFrameworkCore;

namespace GraphQLTest
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
