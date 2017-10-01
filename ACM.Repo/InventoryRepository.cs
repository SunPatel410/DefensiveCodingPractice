using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.Repo
{
    public class InventoryRepository : IInventRepository
    {
        public void OrderItems(Order order, bool allowSplitOrders)
        {
            throw new NotImplementedException();
        }
    }

    public interface IInventRepository
    {
        void OrderItems(Order order, bool allowSplitOrders);
    }
}
