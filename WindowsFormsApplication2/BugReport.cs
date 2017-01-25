using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class BugReport
    {
        public string BugReportName { get; set; } 
        public string RealResult { get; set; }

        public Case caseForSteps { get; set; } 
        public BugReport(string BugReportName, string RealResult, Case caseForSteps)
        {
            this.RealResult = RealResult;
            this.caseForSteps = caseForSteps;
            this.BugReportName = BugReportName;
        }

    }
}
