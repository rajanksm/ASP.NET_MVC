using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;

        public CustomerService()
        {

        }

        /*[InjectionConstructor]//used when we have multiple constructors
        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }*/

        /*[Dependency]
        public ICustomerRepository _iCustomerRepository { get; set; }
        */
        [InjectionMethod]
        public void InjMethod(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }
    }
}
