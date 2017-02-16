using System;
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
            var issues = new List<Domain.Issue>()
            {
                new Domain.Issue()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = "EO.1",
                    ShortName = "The Wall",
                    Title = "Trumps next big idea",
                    ScheduledVoteDate = DateTime.Today.AddDays(7),
                    DocumentLink = "https://tinyurl.com",
                    Summary =
                        "We're going to build a wall and mexico will pay for it and it will cost 21 billion dollars and it will also pay for itself many many times over"
                },
                new Domain.Issue()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = "EO.2",
                    ShortName = "The Ban",
                    Title = "Trumps next big idea",
                    ScheduledVoteDate = DateTime.Today.AddDays(6),
                    DocumentLink = "https://tinyurl.com",
                    Summary = "Ban anyone I don't like"
                }
            };

            return issues;
        }
    }
}
