using GraphQL.Demo.Context.DataAccess.Entities;
using GraphQL.Demo.Context.DataAccess.Entities.TypeConfigurations.Books;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Demo.Context
{
    public class GraphQLDemoDbContext : DbContext
    {
        public GraphQLDemoDbContext(DbContextOptions<GraphQLDemoDbContext> dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookEntityTypeConfiguration).Assembly);
        }
    }
}