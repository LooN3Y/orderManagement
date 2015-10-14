using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    class Customer
    {
        public int ID { get; set; }
        public long Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(int customerID, string customerName, long customerPhone, string customerAddress)
        {
            this.ID = customerID;
            this.Name = customerName;
            this.Phone = customerPhone;
            this.Address = customerAddress;
        }
        public Customer()
        {
            this.ID = 0;
            this.Name = "?";
            this.Phone = 0;
            this.Address = "?";
        }
    }
}
