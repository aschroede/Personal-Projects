using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcuseManager2
{
    [Serializable]
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
            string[] files = Directory.GetFiles(folder, "*.excuse");

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
            using(Stream input = File.OpenRead(fileToOPen))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Excuse temporaryExcuse = (Excuse)bf.Deserialize(input);
                Description = temporaryExcuse.Description;
                Results = temporaryExcuse.Results;
                LastUsed = temporaryExcuse.LastUsed;
            }
        }

        public void Save(string fileToSave)
        {          
            using (Stream output = File.Create(fileToSave))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
        }
    }
}
