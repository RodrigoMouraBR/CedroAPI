using Cedro.Domain.Models;
using System.Data.Entity.ModelConfiguration;
namespace Cedro.Infra.Data.Mappings
{
    public class ReviewMapping : EntityTypeConfiguration<Review>
    {
        public ReviewMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Name)
              .IsRequired()
              .HasMaxLength(80);
            Property(c => c.Date)
              .IsRequired();
              Property(c => c.Rating)
              .IsRequired()
              .HasMaxLength(10);
            Property(c => c.Comments)
              .IsRequired()
              .HasMaxLength(200);


            HasRequired(c => c.Restaurants)
                .WithMany(e => e.Reviews)
                .HasForeignKey(c => c.RestaurantId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Review");
        }
    }
}
