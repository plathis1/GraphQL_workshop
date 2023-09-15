using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using HotChocolate;
using ConferencePlanner.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=conferences.db"));
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

//Middlewares

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();
app.UseGraphQLVoyager( "/graphql-voyager");

app.Run();