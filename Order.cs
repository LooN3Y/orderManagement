using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    class Order
    {
        private int _orderID { get; set; }
        private int _customerID { get; set; }
        private string _details { get; set; }

        public void Order(int customerid, string details)
        {
            this._customerID= customerid;
            this._details = details;
            // Find a new/unique orderID
            this._orderID = newID();
        }

        /*
         * Method that returns a new unique orderID for each new order.
         */
        private static int newID()
        {
            int newOrderID = 0;

            // TODO ===

                // Read from orders file

            return newOrderID;
        }

        /*
         * Method that creates a new order and adds his entry to the orders file.
         */
        public static bool CreateOrder()
        {
            // TODO ===
            return false;
        }

        /*
         * Method that updates the info of an existing order.
         */
        public static bool UpdateOrder()
        {
            // TODO ===
            return false;
        }

        /*
         * Method that deletes the entry of an existing order.
         */
        public static bool DeleteOrder()
        {
            // TODO ===
            return false;
        }

        /*
         * Method that reads the info of an existing order.
         */
        public static Order ReadOrder(int orderID)
        {
            Order o = null;
            // TODO ===
            return o;
        }
    }
}
