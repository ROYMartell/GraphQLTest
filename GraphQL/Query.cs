namespace GraphQLTest.GraphQL
{
    public class Query
    {

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts([Service] GraphQLTestContext context) => context.Products;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Category> GetCategories([Service] GraphQLTestContext context) => context.Categories;
    }
}
