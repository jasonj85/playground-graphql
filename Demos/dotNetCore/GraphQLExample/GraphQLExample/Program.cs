using GraphQLExample.GraphQL;
using GraphQLExample.Models;
using GraphQLExample.Services;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DatabaseContext>(item => item.UseSqlServer(configuration.GetConnectionString("MyConnection")));
builder.Services
    .AddGraphQLServer()
    .AddQueryType<DbLoggerCategory.Query>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<Query>();
builder.Services.AddScoped<Mutation>();
builder.Services.AddGraphQL(c => SchemaBuilder.New().AddServices(c).AddType<GraphQLTypes>().AddQueryType<Query>().AddMutationType<Mutation>().Create());
//builder.Services
//    .AddGraphQLServer().AddType<GraphQLTypes>().AddQueryType<Query>().AddMutationType<Mutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UsePlayground(new PlaygroundOptions
    {
        QueryPath = "/api",
        Path = "/playground"
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGraphQL();

app.Run();
