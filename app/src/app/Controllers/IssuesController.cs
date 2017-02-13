using App.Issue;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class IssuesController : Controller
    {
        private readonly IssueProvider _issueProvider;

        public IssuesController(IssueProvider issueProvider)
        {
            _issueProvider = issueProvider;
        }

        public IActionResult Index()
        {
            var issues = _issueProvider.GetUpcoming();

            return View();
        }
    }
}
