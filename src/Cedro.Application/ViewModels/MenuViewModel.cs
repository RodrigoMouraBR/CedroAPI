using System;
using System.ComponentModel.DataAnnotations;
namespace Cedro.Application.ViewModels
{
    public class MenuViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Guid RestaurantId { get; set; }
        public RestaurantViewModel Restaurants { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
