using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
            List<UnitCheck> unitCheck = new List<UnitCheck>();
            CheckList ckeckList = new CheckList(unitCheck);

            List<Case> suit = new List<Case>();
            List<Suit> suitList = new List<Suit>();

            List<BugReport> bugReport = new List <BugReport>();
            StatusProject Project = new StatusProject(suitList, ckeckList, bugReport);


            suit.Add(new Case());

            //add steps to case
            List<string> steps = new List<string>();
         
            for(int i=0; i< 10; i++)
               steps.Add(i.ToString());

            suit[0].AddCase("Expected result", steps);
            suit.Add(new Case() {ExpectedResult = "Expected result", StepsForImplementation = steps });
            */
            




        }
    }
}
