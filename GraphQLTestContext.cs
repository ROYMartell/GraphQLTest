using Microsoft.EntityFrameworkCore;

namespace GraphQLTest;

public class GraphQLTestContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }

    public GraphQLTestContext()
    {
    }

    public GraphQLTestContext(DbContextOptions<GraphQLTestContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Categories_ParentId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity
                .HasOne(d => d.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(d => d.ParentId);

            entity
                .HasMany(e => e.Products)
                .WithMany(e => e.Categories)
                .UsingEntity("ProductCategories");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity
                .HasMany(e => e.Categories)
                .WithMany(e => e.Products)
                .UsingEntity(
                    "ProductCategories",
                    r => r.HasOne(typeof(Category)).WithMany().HasForeignKey("CategoryId").HasPrincipalKey(nameof(Category.Id)),
                    l => l.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductId").HasPrincipalKey(nameof(Product.Id)),
                    j => j.HasKey("ProductId", "CategoryId")
                    );
        });
    }
}
