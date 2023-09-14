using ECom.Core.Repositories;
using ECom.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly EcomDbContext ecomDbContext;
        public UnitOfWork(EcomDbContext ecomDbContext)
        {
            this.ecomDbContext = ecomDbContext;
            productRepository = new ProductRepository(this.ecomDbContext);
            orderRepository = new OrderRepository(this.ecomDbContext);
        }

       public IProductRepository productRepository { get;private set; }

      public  IOrderRepository orderRepository { get;private set; }

      

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnitOfWork.Complete()
        {
            return this.ecomDbContext.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            this.ecomDbContext.Dispose();
        }
    }
}
