using Microsoft.AspNetCore.Mvc;

namespace SitePiranhaCMS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}