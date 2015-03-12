using System;
using System.Text;
using System.Web.Mvc;

namespace EmptyWebForAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var sb = new StringBuilder();
            sb.Append("Azure test created at 10:20 12/03/2015 by huanhvhd@gmail.com");
            sb.Append("<br>");
            sb.Append("Time on server is " + DateTime.Now);
            sb.Append("<br>");
            sb.Append("The env - OSVersion: " + Environment.OSVersion);
            sb.Append("<br>");
            sb.Append("Repository is available at https://github.com/hoangvanhuanvn/sample-webapp-azure");

            return new ContentResult()
                {
                    Content = sb.ToString()
                };
        }
    }
}
