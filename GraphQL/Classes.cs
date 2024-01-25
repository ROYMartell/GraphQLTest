//namespace GraphQLTest.GraphQL
//{
//    public class Product
//    {
//        [ID] public Guid Id { get; set; }
//        public required string Name { get; set; }
//        public ICollection<ProductCategory> ProductCategories { get; set; }
//    }

//    public class ProductCategory
//    {
//        public Guid Id { get; set; }
//        public virtual Guid ProductId { get; protected set; }
//        public virtual Product Product { get; protected set; }
//        public virtual Guid CategoryId { get; protected set; }
//        public virtual Category Category { get; protected set; }

//        private ProductCategory()
//        {
//        }

//        public ProductCategory(Guid productId, Guid categoryId)
//        {
//            Id = Guid.NewGuid();
//            ProductId = productId;
//            CategoryId = categoryId;

//        }
//    }

//    public class Category
//    {
//        public Guid Id { get; set; }
//        public required string Name { get; set; }
//        public Category? Parent { get; set; }
//        public Guid? ParentId { get; set; }
//        public virtual ICollection<Category>? Children { get; set; } = [];
//        public virtual ICollection<ProductCategory>? ProductCategories { get; set; } = [];
//    }
//}
