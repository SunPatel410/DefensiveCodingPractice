using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using ACM.BL;
using Core.Common;

namespace ACM.Repo.Controllers
{
    public class OrderController
    {

        private CustomerRepository _customerRepository;
        private OrderRepository _orderRepository;
        private InventoryRepository _inventoryRepository;
        private EmailLibrary _emailLibrary;

        public OrderController()
        {
            _inventoryRepository = new InventoryRepository();
            _orderRepository = new OrderRepository();
            _customerRepository =  new CustomerRepository();
            _emailLibrary = new EmailLibrary();
        }

        public OperationResult PlaceOrder(Customer customer, 
                                      Order order, 
                                      Payment payment, 
                                      bool allowSplitOrders, bool emailReceipt)
        {
            //Assertions - only used when debugging the application
            Debug.Assert(_customerRepository != null, "Missing customer repository instance");
            Debug.Assert(_orderRepository != null, "Missing order repository instance");
            Debug.Assert(_inventoryRepository != null, "Missing inventory repository instance");
            Debug.Assert(_emailLibrary != null, "Missing email library instance");

            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            if (order == null)
                throw new ArgumentNullException(nameof(order));

            if (payment == null)
                throw new ArgumentNullException(nameof(payment));

            var op = new OperationResult();

            _customerRepository.Add(customer);
            _orderRepository.Add(order);
            _inventoryRepository.OrderItems(order, allowSplitOrders);
            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();

                if (result.Success)
                {
                    _customerRepository.Update();

                    _emailLibrary.SendEmail(customer.EmailAddress,
                        "Here is your reciept");
                }
                else
                {
                    // log the messages
                    if (result.MessageList.Any())
                    {
                        op.AddMessage(result.MessageList[0]);
                    }
                }
            }

            return op;
        }
    }
}
