﻿using Cedro.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Cedro.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity<T>
    {
        T Add(T obj);
        T Update(T obj);
        void Delete(Guid id);
        T GetbyId(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}
