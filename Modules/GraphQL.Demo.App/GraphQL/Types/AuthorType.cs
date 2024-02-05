using GraphQL.Demo.Context.DataAccess.Entities;
using GraphQL.Types;

namespace GraphQL.Demo.App.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.Nationality);

            Field(f => f.CreatedOn, nullable: false);
            Field(f => f.ModifiedOn, nullable: false);
            Field(f => f.IsDeleted, nullable: false);

            Field<ListGraphType<BookType>>("books", resolve: context => context?.Source?.Books);
        }
    }
}