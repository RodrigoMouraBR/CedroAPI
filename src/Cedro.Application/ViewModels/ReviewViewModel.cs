using System;
using System.ComponentModel.DataAnnotations;
namespace Cedro.Application.ViewModels
{
    public class ReviewViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public Guid RestaurantId { get; set; }
        public RestaurantViewModel Restaurants { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
