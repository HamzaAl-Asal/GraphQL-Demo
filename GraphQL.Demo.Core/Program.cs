using GraphQL.Demo.App;
using GraphQL.Demo.Context;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GraphQLDemoDbContext>(e =>
           e.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDemoDbContext")));

builder.Services.RegisterAppModuleServices();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseGraphQLAltair();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseGraphQL<ISchema>();

app.Run();