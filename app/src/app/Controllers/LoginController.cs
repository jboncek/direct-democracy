using app.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            var model = new LoginViewModel();

            return View(model);
        }
    }
}
