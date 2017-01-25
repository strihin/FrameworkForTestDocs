using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Если существует папка, то присвоить treeNode дерево его имени
 * Если не существует, то записать в treeNode имя и
 */
namespace WindowsFormsApplication2
{
    internal class FileReaderWriter
    {
        public string PathToFolderOfProject { get; set; }
            
        public FileReaderWriter(string PathToFolderOfProject)
        {
            this.PathToFolderOfProject = PathToFolderOfProject;
        }

        public List<string> ReadToNotePad(RichTextBox notePad, string[] getFiles, string pathToProjects)
        {
            var list = new List<string>();
           // var m = Directory.GetCurrentDirectory() + "\\data\\Projects";
           // getFiles.SelectedPath = m;

         //  var getFiles = Directory.GetFiles(@m);
            foreach (var fileInFolder  in getFiles)
            {
             //   StreamReader sr0 = new StreamReader(File.OpenText(fileInFolder), Encoding.UTF8);
                using (StreamReader sr = File.OpenText(fileInFolder))
                {
                    string s = String.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        notePad.Text += s;
                    }
                }
            }
            return list;
        }
        public void WriteToTreeView()
        {
            
        }
    }
}
