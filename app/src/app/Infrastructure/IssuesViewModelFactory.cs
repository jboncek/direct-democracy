using System.Collections.Generic;
using app.ViewModels;
using App.Domain;

namespace app.Infrastructure
{
    public class IssuesViewModelFactory
    {
        public IssuesViewModel Get(List<Issue> issues, Dictionary<string, Result> results)
        {
            var model = new IssuesViewModel();

            foreach (var issue in issues)
            {
                var issueViewModel = new IssueViewModel();

                issueViewModel.IssueDetails = issue;

                issueViewModel.Results = results[issue.Id];

                model.Issues.Add(issueViewModel);
            }

            //sort issues by data
            return model;
        }
    }
}
