using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication2
{
    class Controller
    {
          List<UnitCheck> unitCheck { get; set; }
          CheckList ckeckList { get; set; }
          List<Case> suit { get; set; }
          List<Suit> suitList { get; set; }
          List<BugReport> bugReport { get; set; }
            [XmlIgnore]
          StatusProject Project { get; set; }


        public Controller()
        {
            unitCheck = new List<UnitCheck>();
            ckeckList = new CheckList(unitCheck);
            suit = new List<Case>();
            suitList = new List<Suit>();
            bugReport = new List<BugReport>();
            Project = new StatusProject(suitList, ckeckList, bugReport);

        }

        public Controller(List<UnitCheck> unitCheck,
                          CheckList checkList,
                          List<Case> suit,
                          List<Suit> suits,
                          List<BugReport> bugreportList,
                          StatusProject statusProject)
        {
            this.unitCheck = unitCheck;
            this.ckeckList =checkList;
            this.suit = suit;
            this.suitList = suits;
            this.bugReport = bugreportList;
            this.Project = statusProject;

        }
        public void DoIt(RichTextBox notePad)
        {
            //add steps to case
            List<string> steps = new List<string>();

            for (int i = 0; i < 10; i++)
                steps.Add(i.ToString());

           // suit[0].AddCase("Test Case", "Expected result", steps);
            suit.Add(new Case() {ExpectedResult = "Expected result", StepsForImplementation = steps});
            notePad.Text = steps.ToString();
        }
        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Controller));
                XML.Serialize(stream, this);

            }
        }
        public static Controller LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Controller));
                return (Controller)XML.Deserialize(stream);
            }
        }
    }
}
