﻿using FluentValidation;
using FluentValidation.Results;
using System;
namespace Cedro.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public abstract bool IsValidated();
        public ValidationResult ValidationResult { get; set; }
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }
        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }
        public static bool operator !=(Entity<T> a, Entity<T> b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }
    }
}
