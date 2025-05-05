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

        public long CountEntities()
        {
            return entitySet.Count();
        }

        public int GetPageCount(int pageSize)
        {
            return (int)(CountEntities() / pageSize);
        }

        /// <summary>
        /// Retreives page of entities from DB.
        /// </summary>
        /// 
        /// <param name="entitySet">From where to retreive data</param>
        /// <param name="pageNumber">Which page</param>
        /// <param name="pageSize">How many elements to get</param>
        /// <returns>Page of entities</returns>
        public virtual List<ET> GetEntityPage(int pageNumber,int pageSize)
        {
            int toSkip = (pageNumber - 1) * pageSize;
            return entitySet.Skip(toSkip)
                .Take(pageSize)
                .ToList();
        }

        public virtual List<ET> GetAllEntities()
        {
            return entitySet.ToList();
        }

        public virtual ID AddEntity(ET entity)
        {
            var toAdd=context.Add(entity);
            context.SaveChanges();
            return toAdd.Entity.Id;
        }

        public virtual ET EditEntity(ET entity)
        {
            ET updated=context.Update(entity).Entity;
            context.SaveChanges();
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
    }
}
