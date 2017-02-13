using System.Collections.Generic;

namespace App.Issue
{
    public class IssueProvider
    {
        public List<string> GetAll()
        {
            return new List<string>();
        }

        public List<Domain.Issue> GetUpcoming()
        {
            var issues = new List<Domain.Issue>();

            return issues;
        }
    }
}
