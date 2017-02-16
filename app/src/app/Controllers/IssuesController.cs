using app.Infrastructure;
using App.Issue;
using App.Report;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class IssuesController : Controller
    {
        private readonly IssueProvider _issueProvider;

        private readonly ResultProvider _resultsProvider;

        private readonly IssuesViewModelFactory _factory;

        public IssuesController(
            IssueProvider issueProvider, 
            ResultProvider resultsProvider, 
            IssuesViewModelFactory factory)
        {
            _issueProvider = issueProvider;
            _resultsProvider = resultsProvider;
            _factory = factory;
        }

        public IActionResult Index()
        {
            var issues = _issueProvider.GetUpcoming();

            var results = _resultsProvider.GetIssueResults(issues);

            var model = _factory.Get(issues, results);

            return View(model);
        }
    }
}
