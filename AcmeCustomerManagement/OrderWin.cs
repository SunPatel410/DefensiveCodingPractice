using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;
using ACM.Repo;
using ACM.Repo.Controllers;
using Core.Common;

namespace AcmeCustomerManagement
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                button.Text = "Processing ...";
            }

            PlaceOrder();
        }

        private static void PlaceOrder()
        {
            var customer = new Customer();

            var order = new Order();

            var payment = new Payment();

            try
            {
                var orderController = new OrderController();
                orderController.PlaceOrder(customer, order, payment, allowSplitOrders: false, emailReceipt: true);
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show("The order was not successful");
            }
           
        }
    }
}
