using MathHub.Core.Infrastructure.Interfaces.Repository;
using MathHub.Core.Infrastructure.Repository;
using MathHub.Entity.Entity;
using MathHub.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly MathHubModelContainer _ctx;
        private IDbSet<T> _entities;

        /// <summary>
        /// Constructor. 
        /// Using Dependency Inejection here
        /// </summary>
        /// <param name="context">Object context</param>
        public GenericRepository(IMathHubDbContext MathHubDbContext)
        {
            _ctx = MathHubDbContext.GetDbContext();

        }

        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public virtual bool Insert(T entity)
        {
            //try
            //{
            //    if (entity == null)
            //        throw new ArgumentNullException("insert should not be null");

            //    this.Entities.Add(entity);
            //    return true;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    var msg = string.Empty;

            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //            msg += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;

            //    var fail = new Exception(msg, dbEx);
            //    throw fail;
            //    return false;
            //}

            _ctx.Entry(entity).State = System.Data.EntityState.Added;
            _ctx.Set<T>().Add(entity);
            return Save();
        }

        public virtual bool Update(T entity)
        {
            //try
            //{
            //    if (entity == null)
            //    {
            //        throw new ArgumentNullException("entity");
            //    }

            //    // Find Currently Entity Entry in Context
            //    DbEntityEntry entry = _ctx.Entry<T>(entity);

            //    // if does not attatch yet.
            //    if (entry.State == EntityState.Detached)
            //    {
            //        int id = (int) ReflectionUtils.GetPropertyValue(entity, "Id");
            //        T attachedEntity = _ctx.Set<T>().Find(entity);
            //        if (attachedEntity != null)
            //        {
            //            // get curently DBEntityEntry with AttachedProblem
            //            DbEntityEntry attachtedEntry = _ctx.Entry(attachedEntity);
            //            attachtedEntry.CurrentValues.SetValues(entity);
            //            attachtedEntry.State = EntityState.Modified;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        // this entity has been attached to current context
            //        entry.CurrentValues.SetValues(entity);
            //        entry.State = EntityState.Modified;
            //    }
            //    return true;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    var msg = string.Empty;

            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //            msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);

            //    var fail = new Exception(msg, dbEx);
            //    //Debug.WriteLine(fail.Message, fail);
            //    throw fail;
            //    return false;
            //}

            _ctx.Entry(entity).State = System.Data.EntityState.Modified;
            return Save();
        }

        public virtual bool Delete(T entity)
        {
            //try
            //{
            //    if (entity == null)
            //        throw new ArgumentNullException("entity");

            //    this.Entities.Remove(entity);

            //    this._ctx.SaveChanges();
            //    return true;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    var msg = string.Empty;

            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //            msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);

            //    var fail = new Exception(msg, dbEx);
            //    //Debug.WriteLine(fail.Message, fail);
            //    throw fail;
            //    return false;
            //}
            _ctx.Entry(entity).State = System.Data.EntityState.Deleted;
            return Save();
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _ctx.Set<T>();
                return _entities;
            }
        }

        private bool Save()
        {
            return _ctx.SaveChanges() > 0;
        }

    }
}
