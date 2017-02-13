using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
