using ECom.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly EcomDbContext ecomDbContext;
        public GenericRepository(EcomDbContext ecomDbContext)
        {
                this.ecomDbContext = ecomDbContext;
        }
        void IGenericRepository<T>.Add(T entity)
        {
            this.ecomDbContext.Set<T>().Add(entity);
        }

        void IGenericRepository<T>.AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            return this.ecomDbContext.Set<T>().ToList();
        }

        T IGenericRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
