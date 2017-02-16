using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
