using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SimpleTextEditor
{
    public partial class Form1 : Form, IDisposable
    {
        private string name;

        
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Title = "I'm saving a file!";
            openFileDialog1.InitialDirectory = @"D:\Documents";
            openFileDialog1.Filter = "Text Files (*.txt) | *.txt";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }
    }
}
