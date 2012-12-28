using System.Web.Mvc;

namespace AspNet.Mvc.Dotless.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}