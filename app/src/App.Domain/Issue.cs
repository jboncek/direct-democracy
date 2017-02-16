using System;

namespace App.Domain
{
    public class Issue
    {
        public string Id { get; set; }

        public DateTime ScheduledVoteDate { get; set; }

        public string ShortName { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string DocumentLink { get; set; }

        public string Code { get; set; }
    }
}
