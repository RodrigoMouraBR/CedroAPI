using Cedro.Domain.Core.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
namespace Cedro.Infra.Data.Respositories
{
    public class Repository<T> : IRepository<T> where T : Entity<T>
    {
        protected CedroContext _context;
        protected DbSet<T> _dbSet;
        public Repository(CedroContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T obj)
        {
            _dbSet.Add(obj);
            return obj;
        }
        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetbyId(Guid id)
        {
            return _dbSet.Find(id);
        }
        public int SaveChanges()
        {
           return  _context.SaveChanges();
        }
        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public T Update(T obj)
        {
            var entry = _context.Entry(obj);
            _dbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }
    }
}
