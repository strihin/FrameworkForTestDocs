using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Case
    {
        public string caseName { get; set; }
        public string ExpectedResult { get; set; }
        public List<string> StepsForImplementation;

        public Case()
        {
            StepsForImplementation = new List<string>();
        }

        public void AddCase(string caseName, string ExpectedResult, List<string>  Steps)
        {
            this.caseName = caseName;
            this.ExpectedResult = ExpectedResult;
            StepsForImplementation = Steps;
        }
    }
}
