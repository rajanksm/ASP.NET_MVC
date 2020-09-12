using MVC_ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ErrorHandling.Controllers
{
    // [MyExceptionHandler]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error()
        {
            ViewBag.Message = "Your Error page.";

            return View();
        }

        //Type# 1. try catch (..Home/TryCatchException)
        public ActionResult TryCatchException()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = 0;

                c = a / b; //it would cause exception.  

                return View();
            }
            catch (Exception exp)
            {
                return View(new ErrorMessage { ExceptionFrom = string.Format("Action: {1}", this.ControllerContext.RouteData.Values["controller"].ToString(), this.ControllerContext.RouteData.Values["action"].ToString()), ExceptionMessage = exp.Message });
            }
        }

        //Type# 2. Overriding “OnException” method, applies at controller level (..Home/OnExceptionHandling)
        public ActionResult OnExceptionHandling()
        {
            int a = 1;
            int b = 0;
            int c = 0;

            c = a / b; //it would cause exception.  

            return View();
        }
        //OnException is not available in .NET core
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    Exception exp = filterContext.Exception;
        //    filterContext.ExceptionHandled = true;
        //    string action = filterContext.RouteData.Values["action"].ToString();
        //    string controller = filterContext.RouteData.Values["controller"].ToString();
        //    ErrorMessage model = new ErrorMessage { ExceptionFrom = string.Format("Action: {1}", controller, action), ExceptionMessage = exp.Message };

        //    filterContext.Result = new ViewResult()
        //    {
        //        ViewName = "TryCatchException", //reusing TryCatchException view
        //        ViewData = new ViewDataDictionary(model)
        //    };
        //}


        //Type# 3. Using “[HandleError]” attribute (..Home/HandleErrorException)
        [HandleError()]
       [HandleError(View = "Error")]
        public ActionResult HandleErrorException()
        {
            int a = 1;
            int b = 0;
            int c = 0;

            c = a / b; //it would cause exception.  

            return View();
        }

        //Type# 4. Inheriting from “HandleErrorAttribute” (..Home/InheritHandleErrorException)
       // [MyExceptionHandler]
        public ActionResult InheritHandleErrorException()
        {
            int a = 1;
            int b = 0;
            int c = 0;

            c = a / b; //it would cause exception.  

            return View();
        }
    }

    //public class MyExceptionHandler : HandleErrorAttribute
    //{
    //    public override void OnException(ExceptionContext filterContext)
    //    {
    //        Exception exp = filterContext.Exception;
    //        filterContext.ExceptionHandled = true;
    //        string action = filterContext.RouteData.Values["action"].ToString();
    //        ErrorMessage model = new ErrorMessage { ExceptionFrom = string.Format("Action: {1}", filterContext.RouteData.Values["controller"].ToString(), action), ExceptionMessage = exp.Message };

    //        filterContext.Result = new ViewResult()
    //        {
    //            ViewName = "TryCatchException", //reusing TryCatchException view
    //            ViewData = new ViewDataDictionary(model)
    //        };
    //    }
    //}
}