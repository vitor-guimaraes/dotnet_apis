using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekQuiz.Controllers
{
    [Authorize]
    //The Authorize filter checks to see if the user is authenticated. If the user is not authenticated,
    //it returns HTTP status code 401 (Unauthorized) without invoking the action. You can apply the filter globally,
    //at the controller level, or at the level of individual actions.
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
    }
}