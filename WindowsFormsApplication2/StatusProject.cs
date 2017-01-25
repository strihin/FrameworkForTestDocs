using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class StatusProject
    {

        List<Suit> Suits { get; set; }
        public int CountOfCase { get; set; }
        public int CountTestedCases { get; set; }
        public int PercentFailedCases { get; set; }
        public int CountOfBugReport { get; set; }
        public int CountOfCheckedBugReport { get; set; }
        public CheckList Checklist { get; set; }
        public List<BugReport> Bugreport { get; set; }


        public StatusProject(List<Suit> suits, CheckList Checklist, List<BugReport> Bugreport)
        {
            Suits = suits;
            this.Checklist = Checklist;
            this.Bugreport = Bugreport;
        }


    }
}
