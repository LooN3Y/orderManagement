using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderManagement.Classes
{
    class DataManipulation
    {
        public static string FilePath { get; set; }

        public DataManipulation(string path)
        {
            FilePath = path;
        }

        /*
         *  Public method that returns the data of customers file. 
         */
        public List<Customer> CustomersFetch()
        {
            List<Customer> dataList = new List<Customer>();
            StreamReader sr = new StreamReader(FilePath);
            string[] aLine;

            do
            {
                aLine = sr.ReadLine().Split('.');
                dataList.Add(new Customer( int.Parse(aLine[0]), aLine[1], long.Parse(aLine[2]), aLine[3] ));
            } while (sr.Peek() != -1);

            sr.Close();
            return dataList;
        }

        /*
         *  Public method that returns the data of orders file. 
         */
        public List<Order> OrdersFetch()
        {
            List<Order> dataList = new List<Order>();
            StreamReader sr = new StreamReader(FilePath);
            string[] aLine;

            do
            {
                aLine = sr.ReadLine().Split('.');
                dataList.Add(new Order(int.Parse(aLine[0]), int.Parse(aLine[1]), aLine[2]));
            } while (sr.Peek() != -1);

            sr.Close();
            return dataList;
        }

        public string errorReturn(Exception error)
        {
            string errMessage = error.GetType() + "\n" + error.Message + "\n" + error.StackTrace + "\n";
            return errMessage;
        }

        /*
         * Function that Creates and adds a new customer to the customer file
         */
        public void CustomerCreate(Customer newCustomer)
        {
            string line = newCustomer.ID + "." + newCustomer.Name + "." + newCustomer.Phone + "." + newCustomer.Address;
            StreamWriter w = File.AppendText(FilePath);
            w.WriteLine(line);
            w.Close();
        }

        /*
         * Func that takes a customer ID as input, searches for and returns the customer with that id
         */
        public Customer CustomerFind(int cID)
        {
            Customer customer = null;
            
            foreach (Customer cust in this.CustomersFetch())
            {
                if (cust.ID == cID)
                    return cust;
            }

            return customer;
        }

        /*
         * Boolean func that takes a customer ID as input, and deletes the customer from the file.
         * Returns True for successfull deletion.
         */
        public bool CustomerDelete(int cID)
        {
            Customer customer = this.CustomerFind(cID);
            if (customer != null)
            {
                string emptyline = null;
                string[] aLine;
                // Customer exists, delete!

                StreamReader sReader = new StreamReader(FilePath);
                StreamWriter sWriter = new StreamWriter(FilePath);

                // read a line from file
                while (sReader.Peek() != -1)
                {
                    // break line
                    aLine = sReader.ReadLine().Split('.');
                    // check ID
                    if (int.Parse(aLine[0]) == cID)
                    {
                        sWriter.WriteLine(emptyline);
                        return true;
                    }   
                }
            }
            return false;
        }

        /*
         * Boolean func that updates the data of a customer.
         *  Input: A customer object with the new data.
         */
        public bool CustomerUpdate(Customer newCustomer)
        {
            // Check if customer exists:
            
                // Update, return true

                // Else return false
            return false;
        }
    }
}
