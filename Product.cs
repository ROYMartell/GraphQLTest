namespace GraphQLTest;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
