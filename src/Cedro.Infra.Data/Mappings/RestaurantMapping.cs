using Cedro.Domain.Models;
using System.Data.Entity.ModelConfiguration;
namespace Cedro.Infra.Data.Mappings
{
    public class RestaurantMapping : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(80);
            Property(c => c.Category)
               .IsRequired()
               .HasMaxLength(80);
            Property(c => c.DeliveryEstimate)
               .IsRequired()
               .HasMaxLength(10);
            Property(c => c.Rating)
              .IsRequired()
              .HasMaxLength(10);
            Property(c => c.ImagePath)
             .IsRequired()
             .HasMaxLength(200);
            Property(c => c.About)
            .IsRequired()
            .HasMaxLength(200);
            Property(c => c.Hours)
            .IsRequired()
            .HasMaxLength(200);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Restaurant");

        }
    }
}
