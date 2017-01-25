using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Suit
    {
        public string SuitName { get; set; }
        public List<Case> SuitList { get; set; }

        public Suit(List<Case> suit, string SuitName)
        {
            this.SuitList = suit;
            this.SuitName = SuitName;
        }
        public List<Case> AddCaseToSuit(Case UnitCase)
        {
            SuitList.Add(UnitCase);
            return SuitList;
        }

        public List<Case> RemoveCaseFromSuit(int index)
        {
            SuitList.RemoveAt(index);
            return SuitList;
        }

    }
}
