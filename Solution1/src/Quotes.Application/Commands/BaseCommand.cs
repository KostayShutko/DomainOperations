using Quotes.Domain.Entities;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands;

public abstract class BaseCommand<TEntity>
    where TEntity : Entity
{
    protected readonly IRepository<TEntity> repository;

    protected BaseCommand(IRepository<TEntity> repository)
    {
        this.repository = repository;
    }

    protected Task<TEntity> FindByIdAsync(int entityId)
    {
        return repository.FindByIdAsync(entityId);
    }

    protected Task<TEntity> FindFirstBySpecification(ISpecification<TEntity> specification)
    {
        return repository.FindFirstAsync(specification);
    }

    protected Task<IEnumerable<TEntity>> FindBySpecification(ISpecification<TEntity> specification)
    {
        return repository.FindAsync(specification);
    }

    protected async Task<TEntity> SaveChangesAsync(TEntity entity)
    {
        if (entity.IsNew())
        {
            var addedEntity = await repository.AddAsync(entity);
            await repository.SaveChangesAsync();
            return addedEntity;
        }

        repository.Update(entity);
        await repository.SaveChangesAsync();
        return entity;
    }
}
