namespace GraphQL.Demo.Context.DataAccess.Entities
{
    public class Book : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}