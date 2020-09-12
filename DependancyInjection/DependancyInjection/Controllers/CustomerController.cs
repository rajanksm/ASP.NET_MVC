using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace DependancyInjection.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        public ActionResult GetCustomers()
        {
            return Json(_iCustomerService.GetCustomers(), JsonRequestBehavior.AllowGet);
        }

        // GET: Customer
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}