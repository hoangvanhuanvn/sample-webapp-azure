using System;
using System.Web.Mvc;

namespace EmptyWebForAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new ContentResult()
                {
                    Content = "Hello, time on server is " + DateTime.Now
                };
        }
    }
}
