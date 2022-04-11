using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore4
{
    public class CustomerCatalog
    {

        public List<Customer> customerList = new List<Customer>();

        public void Customers()
        {
            Customer customer1 = new Customer("Anders", "4100", 25);
            Customer customer2 = new Customer("Jørgen", "4300", 29);
            Customer customer3 = new Customer("Hans", "4440", 35);

            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);



        }


        public void PrintCustomerList()
        {

            foreach (Customer customer in customerList)
            {

                Console.WriteLine($"No. {customer._navn} - Navn : {customer._alder} - Tilbehør - {customer._addresse}");
                Console.WriteLine("_______________________________________________________________________________________________________");
            }

        }
    }
}
