﻿using System.Linq.Expressions;

namespace Monopolia.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<TEntity> Add(TEntity model);
    Task<TEntity> Update(TEntity model);

    TEntity Delete(TEntity model);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> Find(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>>? predicate = null);
}