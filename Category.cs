namespace GraphQLTest;

public class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Guid? ParentId { get; set; }

    public virtual ICollection<Category> Children { get; set; } = new List<Category>();

    public virtual Category? Parent { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
