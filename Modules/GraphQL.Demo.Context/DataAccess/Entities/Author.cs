namespace GraphQL.Demo.Context.DataAccess.Entities
{
    public class Author : BaseEntity
    {
        public int Age { get; set; }
        public string Nationality { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}