using GraphQLTest;
using GraphQLTest.GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services
//    .AddDbContext<TestDbContext>(options =>
//        options.UseSqlServer(
//            "Server=localhost;Database=GraphQLTest;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services
    .AddDbContext<GraphQLTestContext>(options =>
        options.UseSqlServer(
            "Server=localhost;Database=GraphQLTest;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();
