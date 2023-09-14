using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Domain.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository productRepository { get; }
        IOrderRepository orderRepository { get; }
        int Complete();
    }
}
