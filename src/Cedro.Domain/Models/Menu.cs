using Cedro.Domain.Core.Entities;
using System;
namespace Cedro.Domain.Models
{
    public class Menu : Entity<Menu>
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }        
        public string Description { get; set; }
        public string Price { get; set; }
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurants { get; set; }
        public override bool IsValidated()
        {
           return true;
        }
    }
}
