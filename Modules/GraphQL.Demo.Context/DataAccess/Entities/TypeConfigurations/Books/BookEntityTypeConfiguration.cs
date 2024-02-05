using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Demo.Context.DataAccess.Entities.TypeConfigurations.Books
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(300);

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Property(x => x.Currency)
                .HasMaxLength(5);
        }
    }
}