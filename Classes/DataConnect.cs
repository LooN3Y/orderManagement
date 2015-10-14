using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using orderManagement.Classes;

namespace orderManagement.Classes
{
    class DataConnect
    {
        public DataConnect()
        {
            DataManipulation CustomerDataConnection = new DataManipulation("customers.txt");
            DataManipulation OrdersDataConnection = new DataManipulation("orders.txt");
        }
    }
}
