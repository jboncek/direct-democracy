namespace App.Domain
{
    public class Result
    {
        public string IssueId { get; set; }

        public int VotedYes { get; set; }

        public int VotedNo { get; set; }

        public int VotedAbstain { get; set; }

        public string LastUpdated { get; set; }
    }
}
