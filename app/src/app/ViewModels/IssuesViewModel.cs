using System.Collections;
using System.Collections.Generic;
using System.Linq;
using App.Domain;

namespace app.ViewModels
{
    public class IssuesViewModel
    {
        public IssuesViewModel()
        {
            Issues = new List<IssueViewModel>();
        }

        public List<IssueViewModel> Issues { get; set; }
    }
}
