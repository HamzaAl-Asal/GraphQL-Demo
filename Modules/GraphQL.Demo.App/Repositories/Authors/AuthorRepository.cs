using GraphQL.Demo.Context;
using GraphQL.Demo.Context.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Demo.App.Repositories.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly GraphQLDemoDbContext context;

        public AuthorRepository(GraphQLDemoDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            var authors = await context.Authors
                .Include(d => d.Books)
                .ToListAsync();

            return authors;
        }
    }
}