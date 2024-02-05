using GraphQL.Demo.App.GraphQL.Types;
using GraphQL.Demo.App.Repositories.Authors;
using GraphQL.Types;

namespace GraphQL.Demo.App.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        private readonly IAuthorRepository authorRepository;

        public AppQuery(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
            
            FieldAsync<ListGraphType<AuthorType>>(
               "authors",
                resolve: async context => await authorRepository.GetAuthors());
        }
    }
}