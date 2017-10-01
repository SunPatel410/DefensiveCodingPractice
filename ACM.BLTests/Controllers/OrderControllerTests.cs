using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Repo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.Repo.Controllers.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //arrange
            var orderController = new OrderController();
            var customer = new Customer {EmailAddress = "sunny.patel@hotmail.com"};
            var order = new Order();
            var payment = new Payment {PaymentType = 1};

            //act
            var op = orderController.PlaceOrder(customer, order, payment, 
                                                allowSplitOrders: true,  emailReceipt:true);
            //assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestNullCustomer()
        {
            //arrange
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment { PaymentType = 1 };

            //act
            var op = orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: true, emailReceipt: true);

            //assert

        }

        [TestMethod()]
        public void PlaceOrderTestInvalidEmail()
        {
            //arrange
            var orderController = new OrderController();
            var customer = new Customer { EmailAddress = "" };
            var order = new Order();
            var payment = new Payment { PaymentType = 1 };

            //act
            var op = orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: true, emailReceipt: true);

            //assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(1, op.MessageList.Count);
            Assert.AreEqual("Email Address is null", op.MessageList[0]);

        }
    }
}