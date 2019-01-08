using Cedro.Domain.Models;
using System.Data.Entity.ModelConfiguration;
namespace Cedro.Infra.Data.Mappings
{
    public class MenuMapping : EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(80);
            Property(c => c.Description)
               .IsRequired()
               .HasMaxLength(200);
            Property(c => c.Price)
               .IsRequired()
               .HasMaxLength(10);
            HasRequired(c => c.Restaurants)
                .WithMany(e => e.Menus)
                .HasForeignKey(c => c.RestaurantId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Menu");
        }
    }
}
