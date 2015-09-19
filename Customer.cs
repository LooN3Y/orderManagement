using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    class Customer
    {
        private int _id { get; set; }
        private int _phone { get; set; }
        private string _name { get; set; }
        private string _address { get; set; }

        public Customer(int customerID, string customerName, int customerPhone, string customerAddress)
        {
            this._id = customerID;
            this._name = customerName;
            this._phone = customerPhone;
            this._address = customerAddress;
        }

        /*
         * Method that creates a new customer and adds his entry to the customers file.
         */
        public static bool CreatCustomer(int customerID, string customerName, int customerPhone, string customerAddress)
        {
            // TODO ===
            return false;
        }

        /*
         * Method that updates the info of an existing customer.
         */
        public static bool UpdateCustomer(int customerID, string customerName, int customerPhone, string customerAddress)
        {
            // TODO ===
            return false;
        }

        /*
         * Method that deletes the entry of an existing customer.
         */
        public static bool DeleteCustomer(int customerID)
        {
            // TODO ===
            return false;
        }

        /*
         * Method that reads the info of an existing customer.
         */
        public static Customer ReadCustomer(int customerID)
        {
            Customer c = null;
            // TODO ===
            return c;
        }
    }
}
