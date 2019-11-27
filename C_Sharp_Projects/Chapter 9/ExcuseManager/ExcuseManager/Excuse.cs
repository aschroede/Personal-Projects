using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExcuseManager
{
    class Excuse
    {
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        public string Description { get ; set; }
        public string Results { get; set ; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string fileToOpen)
        {
            OpenFile(fileToOpen);
        }

        public Excuse(Random random, string folder)
        {
            string[] files = Directory.GetFiles(folder, "*.txt");

            if (files.Length != 0)            
                OpenFile(files[random.Next(files.Length)]);            
            else
            {
                MessageBox.Show("There are no excuse files yet, please create one before selecting random.", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        public void OpenFile(string fileToOPen)
        {
            ExcusePath = fileToOPen;
            using (StreamReader file = new StreamReader(fileToOPen))
            {
                Description = file.ReadLine();
                Results = file.ReadLine();
                LastUsed = Convert.ToDateTime(file.ReadLine());
            }
        }

        public void Save(string fileToSave)
        {          
            using (StreamWriter file = new StreamWriter(fileToSave))
            {
                file.WriteLine(Description);
                file.WriteLine(Results);
                file.WriteLine(LastUsed);              
            }
        }
    }
}
