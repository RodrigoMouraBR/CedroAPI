using Cedro.Domain.Core.Entities;
using System;
namespace Cedro.Domain.Models
{
    public class Review : Entity<Review>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurants { get; set; }
        public override bool IsValidated()
        {
            throw new NotImplementedException();
        }
    }
}
