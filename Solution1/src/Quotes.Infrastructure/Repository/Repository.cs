﻿using Microsoft.EntityFrameworkCore;
using Quotes.Domain.Entities;
using System.Linq.Expressions;

namespace Quotes.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{ 
    protected readonly DbContext context;

    public Repository(DbContext context)
    {
        this.context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        return (await context.Set<TEntity>().AddAsync(entity)).Entity;
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await context.Set<TEntity>().AddRangeAsync(entities);
    }

    public async Task<bool> ContainsAsync(ISpecification<TEntity> specification)
    {
        var count = await CountAsync(specification);
        return count > 0 ? true : false;
    }

    public async Task<bool> ContainsAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var count = await CountAsync(predicate);
        return count > 0 ? true : false;
    }

    public async Task<int> CountAsync(ISpecification<TEntity> specification)
    {
        return await ApplySpecification(specification).CountAsync();
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await context.Set<TEntity>().Where(predicate).CountAsync();
    }

    public async Task<TEntity> FindFirstAsync(ISpecification<TEntity> specification)
    {
        return await ApplySpecification(specification).FirstAsync();
    }

    public async Task<IEnumerable<TEntity>> FindAsync(ISpecification<TEntity> specification)
    {
        return await ApplySpecification(specification).ToListAsync();
    }

    public async Task<bool> HasAnyAsync(ISpecification<TEntity> specification)
    {
        return await ApplySpecification(specification).AnyAsync();
    }

    public async Task<TEntity> FindByIdAsync(int id)
    {
        return await context.Set<TEntity>().FindAsync(id);
    }

    public void Remove(TEntity entity)
    {
        context.Set<TEntity>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        context.Set<TEntity>().RemoveRange(entities);
    }

    public void Update(TEntity entity)
    {
        context.Set<TEntity>().Attach(entity);
        context.Entry(entity).State = EntityState.Modified;
    }

    public Task<int> SaveChangesAsync()
    {
        return context.SaveChangesAsync();
    }

    public void Dispose()
    {
        context.Dispose();
    }

    private IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> spec)
    {
        return SpecificationEvaluator<TEntity>.GetQuery(context.Set<TEntity>().AsQueryable(), spec);
    }
}
