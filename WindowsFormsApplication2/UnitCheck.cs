using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class UnitCheck
    {
        public bool Result { get; set; }

        public string Check { get; set; }

        public UnitCheck(string Check, bool Result)
        {
            this.Check = Check;
            this.Result = Result;
        }
 
    }
}
