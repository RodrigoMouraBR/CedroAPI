using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Cedro.Application.ViewModels
{
    public class RestaurantViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string DeliveryEstimate { get; set; }
        public string Rating { get; set; }
        public string ImagePath { get; set; }
        public string About { get; set; }
        public string Hours { get; set; }
        public virtual ICollection<ReviewViewModel> Reviews { get; set; }
        public virtual ICollection<MenuViewModel> Menus { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
