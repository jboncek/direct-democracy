using app.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            var model = new RegisterViewModel();

            return View(model);
        }
    }
}
