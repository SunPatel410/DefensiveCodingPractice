using ACM.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.Repo
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            throw new NotImplementedException();
        }
    }

    public interface IOrderRepository
    {
        void Add(Order order);
    }
}
