﻿using FBSApp.Models;
using System.Linq.Expressions;

namespace FSBApp.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        public T Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}