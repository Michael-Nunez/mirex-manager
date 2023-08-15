using Microsoft.AspNetCore.Mvc;

namespace MirexManager.Web.Controllers
{
    public class CompaniesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
