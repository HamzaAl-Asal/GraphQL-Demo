using GraphQL.Demo.Context.DataAccess.Entities;
using GraphQL.Types;

namespace GraphQL.Demo.App.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            DefineFields();
        }

        private void DefineFields()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field(x => x.Price);
            Field(x => x.Currency);
            Field(x => x.PublishDate);
            Field(x => x.AuthorId);

            Field(f => f.CreatedOn, nullable: false);
            Field(f => f.ModifiedOn, nullable: false);
            Field(f => f.IsDeleted, nullable: false);
        }
    }
}