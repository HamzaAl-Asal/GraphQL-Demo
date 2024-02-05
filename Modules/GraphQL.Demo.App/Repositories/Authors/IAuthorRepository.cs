using GraphQL.Demo.Context.DataAccess.Entities;

namespace GraphQL.Demo.App.Repositories.Authors
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthors();
    }
}