using System;
using System.Collections.Generic;
using App.Domain;

namespace App.Report
{
    public class ResultProvider
    {
        public Dictionary<string, Result> GetIssueResults(List<Issue> issues)
        {
            var results = new Dictionary<string, Result>();

            foreach (var issue in issues)
            {
                results.Add(issue.Id, new Result()
                {
                    IssueId = issue.Id,
                    LastUpdated = DateTime.Today.ToString(),
                    VotedAbstain = 123,
                    VotedNo = 9999,
                    VotedYes = 1
                });
            }

            return results;
        }
    }
}
