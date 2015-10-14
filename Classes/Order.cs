using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string Details { get; set; }

        public Order (int orderId, int customerId, string details)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Details = details;
        }

        public Order(int customerid, string details)
        {
            this.CustomerID= customerid;
            this.Details = details;
            // Find a new/unique orderID
            this.OrderID = newID();
        }

        public Order()
        {
            this.CustomerID = 0;
            this.Details = "?";
            this.OrderID = newID();
        }

        /*
         * Method that returns a new unique orderID for each new order.
         */
        private static int newID()
        {
            int newOrderID = 0;

            // TODO ===

                // Read from orders file, return an int that can be used as the new id.

            return newOrderID;
        }
    }
}
