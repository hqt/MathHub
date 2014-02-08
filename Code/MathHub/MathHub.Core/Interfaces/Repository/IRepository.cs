using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Infrastructure.Interfaces.Repository
{
    /// <summary>
    /// Repository Pattern 
    /// include some simple operators
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IQueryable<T> Table { get; }
    }
}