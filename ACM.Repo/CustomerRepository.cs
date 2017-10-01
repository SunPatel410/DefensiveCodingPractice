using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.Repo
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update();
    }
}
