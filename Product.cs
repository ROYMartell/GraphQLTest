namespace GraphQLTest;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<Category> Categories { get; set; } = [];
}
