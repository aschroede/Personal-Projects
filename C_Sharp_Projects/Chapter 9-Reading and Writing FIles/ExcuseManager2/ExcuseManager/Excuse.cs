using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

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
            OpenFile(files[random.Next(files.Length)]);
        }
        public void OpenFile(string fileToOPen)
        {
            try
            {
                using (Stream input = File.OpenRead(fileToOPen))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Excuse temporaryExcuse = (Excuse)bf.Deserialize(input);
                    Description = temporaryExcuse.Description;
                    Results = temporaryExcuse.Results;
                    LastUsed = temporaryExcuse.LastUsed;
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to read " + fileToOPen);
                LastUsed = DateTime.Now;
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
