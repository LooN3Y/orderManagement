using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    class Data
    {
        private static string _customersFile, _ordersFile;

        public static Data()
        {
            _customersFile = "customers.txt";
            _ordersFile = "orders.txt";
        }


        /*
         * Method that returns a Customer obj, from the customers file.
         */
        public static Customer customerFetch()
        {
            Customer c = null;

            // TODO ===

            return c;
        }

        /*
         * Method that returns a Order obj, from the orders file.
         */
        public static Order orderFetch()
        {
            Order o = null;

            // TODO ===

            return o;
        }
    }
}
