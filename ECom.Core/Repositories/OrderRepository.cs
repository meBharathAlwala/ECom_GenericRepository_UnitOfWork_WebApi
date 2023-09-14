using ECom.Domain.Entities;
using ECom.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Core.Repositories
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        public OrderRepository(EcomDbContext ecomDbContext):base(ecomDbContext)
        {
                
        }
    }
}
