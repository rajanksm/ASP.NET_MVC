using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using DAL;
using Services;
using Unity.Injection;

namespace DependancyInjection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            //IOC step 2 resolve
            var container = new UnityContainer();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();
            //ICustomerService constructorObj = container.Resolve<ICustomerService>();// is resolved by below code automatically
            //constructorObj.GetCustomers();

            //container.RegisterType<ICustomerRepository, CustomerRepository>("custRepo");

            //Property Injection
            //container.RegisterType<ICustomerService>(new InjectionProperty("custRepo", new CustomerService()));
            //var propertyObj = container.Resolve<CustomerService>();
            //propertyObj.GetCustomers();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}