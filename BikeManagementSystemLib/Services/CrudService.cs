using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib.Services
{
    /// <summary>
    /// Base class for services.
    /// </summary>
    /// 
    /// <typeparam name="ID">Entity ID type</typeparam>
    /// <typeparam name="ET">Entity type</typeparam>
    public abstract class CrudService<ID,ET> where ET : BaseEntity<ID>
    {
        public static readonly int DEFAULT_PAGE_SIZE = 20;
        protected BikeManagementDbContext context;

        /// <summary>
        /// Entity Dbset from context.
        /// </summary>
        protected DbSet<ET> entitySet;

        /// <summary>
        /// Entity short name.
        /// </summary>
        private readonly String entityName;

        protected CrudService(BikeManagementDbContext context, DbSet<ET> entitySet)
        {
            this.context = context;
            this.entitySet = entitySet;
            entityName=typeof(ET).Name;
        }

        /// <summary>
        /// Retreives entity from DB.
        /// </summary>
        /// 
        /// <exception cref="BikeManagementSystemLib.Exceptions.EntityNotFoundException">If entity was not found</exception>
        /// <returns>Entity from DB</returns>
        public virtual ET GetEntity(ID entityID)
        {
            return entitySet.FirstOrDefault(entity => entity.Id.Equals(entityID))
                ?? throw new EntityNotFoundException(entityName,entityID);
        }

        /// <summary>
        /// Retreives entity from DB asynchronously.
        /// </summary>
        /// 
        /// <exception cref="BikeManagementSystemLib.Exceptions.EntityNotFoundException">If entity was not found</exception>
        /// <returns>Entity from DB</returns>
        public virtual async Task<ET> GetEntityAsync(ID entityID)
        {
            return await entitySet.FirstOrDefaultAsync(entity => entity.Id.Equals(entityID)).ConfigureAwait(false)
                ?? throw new EntityNotFoundException(entityName, entityID);
        }

        public long CountEntities()
        {
            return entitySet.LongCount();
        }

        public Task<long> CountEntitiesAysnc()
        { 
            return entitySet.LongCountAsync();
        }

        public int GetPageCount(int pageSize)
        {
            return (int)(CountEntities() / pageSize);
        }

        public async Task<int> GetPageCountAsync(int pageSize)
        {
            long count = await CountEntitiesAysnc()
                .ConfigureAwait(false);
            return (int)(count / pageSize);

        }

        /// <summary>
        /// Creates page of entities.
        /// </summary>
        /// 
        /// <param name="pageNumber">From which page to start</param>
        /// <param name="pageSize">How many elements to take</param>
        /// 
        /// <returns>Page prepared to fetch data</returns>
        protected IQueryable<ET> PrepareEntiytPage(int pageNumber, int pageSize)
        {
            return PrepareEntiytPage(entitySet, pageNumber, pageSize);
        }

        /// <summary>
        /// Creates page of entities.
        /// </summary>
        /// 
        /// <param name="dbQuery">From what to create page</param>
        /// <param name="pageNumber">From which page to start</param>
        /// <param name="pageSize">How many elements to take</param>
        /// 
        /// <returns>Page prepared to fetch data</returns>
        protected IQueryable<T> PrepareEntiytPage<T>(IQueryable<T> dbQuery,int pageNumber, int pageSize)
        {
            int toSkip = (pageNumber - 1) * pageSize;
            return dbQuery.Skip(toSkip)
                .Take(pageSize);
        }

        /// <summary>
        /// Retreives page of entities from DB.
        /// </summary>
        /// 
        /// <param name="pageNumber">Which page</param>
        /// <param name="pageSize">How many elements to get</param>
        /// <returns>Page of entities</returns>
        public virtual List<ET> GetEntityPage(int pageNumber,int pageSize)
        {
            return PrepareEntiytPage(pageNumber,pageSize)
                .ToList();
        }

        /// <summary>
        /// Retreives page of entities from DB asynchronously.
        /// </summary>
        /// 
        /// <param name="pageNumber">Which page</param>
        /// <param name="pageSize">How many elements to get</param>
        /// <returns>Page of entities</returns>
        public virtual Task<List<ET>> GetEntityPageAsync(int pageNumber,int pageSize)
        {
            return PrepareEntiytPage(pageNumber,pageSize)
                .ToListAsync();
        }

        public virtual List<ET> GetAllEntities()
        {
            return entitySet.ToList();
        }

        public virtual Task<List<ET>> GetAllEntitiesAsync()
        {
            return entitySet.ToListAsync();
        }

        public virtual ID AddEntity(ET entity)
        {
            var toAdd=context.Add(entity);
            context.SaveChanges();
            return toAdd.Entity.Id;
        }

        public virtual async Task<ID> AddEntityAsync(ET entity)
        {
            var toAdd=await context.AddAsync(entity);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return toAdd.Entity.Id;
        }

        public virtual ET EditEntity(ET entity)
        {
            ET updated=context.Update(entity).Entity;
            context.SaveChanges();
            return updated;
        }

        public virtual async Task<ET> EditEntityAsync(ET entity)
        {
            ET updated = context.Update(entity).Entity;
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return updated;
        }

        /// <summary>
        /// Deletes entity from DB.
        /// </summary>
        /// 
        /// <exception cref="BikeManagementSystemLib.Exceptions.EntityNotFoundException">If entity was not found</exception>
        public virtual void DeleteEntity(ID entityID)
        { 
            ET entity = GetEntity(entityID);
            context.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes entity from DB asynchronously.
        /// </summary>
        /// 
        /// <exception cref="BikeManagementSystemLib.Exceptions.EntityNotFoundException">If entity was not found</exception>
        public virtual async Task DeleteEntityAsync(ID entityID)
        {
            ET entity=await GetEntityAsync(entityID)
                .ConfigureAwait(false);
            context.Remove(entity);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
        }

        public bool Exists(ID entityID)
        {
            return entitySet.Any(et => et.Id.Equals(entityID));
        }

        public async Task<bool> ExistsAsync(ID entityID)
        {
            return await entitySet.AnyAsync(et => et.Id.Equals(entityID))
                .ConfigureAwait(false);
        }
    }
}
