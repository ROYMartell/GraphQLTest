namespace GraphQLTest;

public class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Guid? ParentId { get; set; }

    public ICollection<Category> Children { get; set; } = [];

    public Category? Parent { get; set; }

    public ICollection<Product> Products { get; set; } = [];
}
