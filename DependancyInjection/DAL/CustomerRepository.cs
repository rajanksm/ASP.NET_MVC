using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public   class CustomerRepository: ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>(){
                new Customer { CustomerId = 1, City = "Visakhapatnam", CustomerName = "Tulasi" },
                new Customer { CustomerId = 2, City = "Hyderabad", CustomerName = "Ramana" },
                new Customer { CustomerId = 3, City = "Bangalore", CustomerName = "Bablu" },
                new Customer { CustomerId = 4, City = "Chennai", CustomerName = "Brammaji" },
            };
        }

        public List<Customer> GetCustomerInfo()
        {
            return new List<Customer>(){
                new Customer { CustomerId = 1, City = "Visakhapatnam", CustomerName = "Tulasi" },
                new Customer { CustomerId = 2, City = "Hyderabad", CustomerName = "Ramana" },
                new Customer { CustomerId = 3, City = "Bangalore", CustomerName = "Bablu" },
                new Customer { CustomerId = 4, City = "Chennai", CustomerName = "Brammaji" },
            };
        }
    }
}
