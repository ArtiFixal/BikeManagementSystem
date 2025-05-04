using BikeManagementSystem;
using BikeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected BikeManagementDbContext context;

        protected CrudService(BikeManagementDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retreives entity from DB.
        /// </summary>
        /// 
        /// <exception cref="BikeManagementSystemLib.Exceptions.EntityNotFoundException">If entity was not found</exception>
        /// <returns>Entity from DB</returns>
        public abstract ET GetEntity(ID entityID);
        public virtual ID AddEntity(ET entity)
        {
            return context.Add(entity).Entity.Id;
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
