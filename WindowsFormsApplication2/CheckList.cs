using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class CheckList
    {
        List<UnitCheck> checkList { get; set; }

        public CheckList(List<UnitCheck> checkList)
        {
           this.checkList = checkList;
        }

        public List<UnitCheck> AddUnitCheck(List<UnitCheck> checkList, string name, bool result)
        {
            checkList.Add(new UnitCheck(name, result));
            return checkList;
        }



    }
}
