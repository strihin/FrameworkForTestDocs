using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * XVIII.XI Plan :
 * 1. Add checkunit to checklist.
 * 2. Add case tu suit.
 * 3. Add suit to suit case.
 * 4. Add bugreport
 * 
 * Read test doc from files:
 * 1. Read folder name in current catalog = name of project
 * 2. Read checklist of project and write it to CheckList obj.
 * 3. Read suit of project and write it to Suit
 * 4. Read bugreport of project and write it to BugReport.
 * 5. 
 * Create folder with name project
 * Step of Case has img - src
 * Тестовая документация располагается последовательно
 * 
 * Выбрать существующий проект \ Создать новый
 * Choose existing project or create new project
 * For choosing of project - see overall project in folder data
 * After selecting one of existing project see in treeview overall existing data of this project
 * After click to one of them  on treeView notePad sees to users information about it unit test doc
 * 
 */ 

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            elementsOfProject.Nodes.Add(new TreeNode("Checklist"));
            //elementsOfProject.Nodes.Add(new TreeNode() { Nodes = { "Checklist" } });

            //SUITS
            List<TreeNode> suits= new List<TreeNode>();
        //    TreeNode[] array = new TreeNode[] { new TreeNode("TestCase #"), };
        //    List<TreeNode> list = new List<TreeNode>();

            for (int i = 0; i < 10; i++)
            {
                suits.Add(new TreeNode("Test suite # : " + i));
                var j = 0;
                foreach (var suit in suits)
                {
                    j++;
                    suit.Nodes.Add(new TreeNode("Case # : " + j));
                }
            }

            var suitList = new TreeNode("Test suites: ", suits.ToArray());
            elementsOfProject.Nodes.Add(suitList);

            List<TreeNode> bugReports = new List<TreeNode>();
            for (int i = 0; i < 10; i++)
            {
                bugReports.Add(new TreeNode("Bug report# : " + i));
            }
            var bugReportList= new TreeNode("Bug reports: ", bugReports.ToArray());
            elementsOfProject.Nodes.Add(bugReportList);
            elementsOfProject.Nodes.Add(new TreeNode("Requiments to project"));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<UnitCheck> unitCheck = new List<UnitCheck>();
            CheckList ckeckList = new CheckList(unitCheck);

            List<Case> suit = new List<Case>();
            List<Suit> suitList = new List<Suit>();

            List<BugReport> bugReport = new List<BugReport>();
            StatusProject Project = new StatusProject(suitList, ckeckList, bugReport);


            suit.Add(new Case());

            //add steps to case
            List<string> steps = new List<string>();

            for (int i = 0; i < 10; i++)
                steps.Add(i.ToString());

            suit[0].AddCase("Test Case","Expected result", steps);
            suit.Add(new Case() { ExpectedResult = "Expected result", StepsForImplementation = steps });
                notePad.Text = steps.ToString();
        }

        private void elementsOfProject_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            lblProjectName.Text ="Project name : " + notePad.Text;
            var path = Directory.GetCurrentDirectory()+ "\\data\\Projects" + notePad.Text;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            // string subpath = @"Suits\Suit # 1";
            //dirInfo.CreateSubdirectory(subpath);

              Directory.GetDirectories(@path);
              
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblProjectName.Text = "Project name : ";
            notePad.Text = "";

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
          //  openExistingProject.ShowDialog();
            var folderDialog = new FolderBrowserDialog();
            
            var m = Directory.GetCurrentDirectory() + "\\data\\Projects\\test00\\suites";
            var filesInFolder = Directory.GetFiles(m);

            foreach (var fileInFolder in filesInFolder)
            {
                folderDialog.SelectedPath = m;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    FileReaderWriter fileStream = new FileReaderWriter(fileInFolder);
                    fileStream.ReadToNotePad(notePad, filesInFolder, m);

                    // folderDialog.SelectedPath -- your result
                }
            }

        }

        private void openExistingProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller ctrl = new Controller();
            ctrl.DoIt(notePad);
         //   openExistingProject.OpenFile();

            var folderDialog = new FolderBrowserDialog();
            var pathToProjects = Directory.GetCurrentDirectory() + "\\data\\Projects\\";

           var filesInFolder= Directory.GetFiles(pathToProjects);
           var folders = Directory.GetDirectories(pathToProjects);
          
            folderDialog.SelectedPath = pathToProjects;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
               
                FileReaderWriter fileStream = new FileReaderWriter(pathToProjects);
                fileStream.ReadToNotePad(notePad, filesInFolder, pathToProjects);//pathToProjects

                foreach (var d in folders)
                {
                    elementsOfProject.Nodes.Clear();
                    elementsOfProject.Nodes.Add(new TreeNode(d));

                    FileInfo[] subFiles = null;
                    DirectoryInfo[] subDir = null;

                    bool isThereAnError = false;

                    try
                    {
                     //   subFiles = d.GetFiles();
                     //   subDir = d.GetDirectories();

                    }
                    catch
                    {
                        isThereAnError = true;
                    }

                }
                fileStream.WriteToTreeView();
            }

        }
        
        private void emptyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller ctrl = new Controller();
            ctrl.DoIt(notePad);
            
        }

       private void button4_Click_1(object sender, EventArgs e)
        {
         //  Controller ctrl = new Controller()
        }

       private void withPatternTestDocToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Controller ctrl = new Controller();
          // ctrl.

       }
    }
}
