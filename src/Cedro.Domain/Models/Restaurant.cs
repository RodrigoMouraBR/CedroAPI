using Cedro.Domain.Core.Entities;
using System;
using System.Collections.Generic;
namespace Cedro.Domain.Models
{
    public class Restaurant : Entity<Restaurant>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string DeliveryEstimate { get; set; }
        public string Rating { get; set; }
        public string ImagePath { get; set; }
        public string About { get; set; }
        public string Hours { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public override bool IsValidated()
        {
           return true;
        }
    }
}
