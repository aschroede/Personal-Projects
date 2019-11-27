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

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        private string selectedFolder  = "";
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dateTimePicker1.Value;
            folderBrowserDialog1.SelectedPath = @"D:\Documents\Business\C_Sharp_Projects\Chapter 9\ExcuseManager\Excuses";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                excuseTextBox.Text = currentExcuse.Description;
                resultsTextBox.Text = currentExcuse.Results;
                dateTimePicker1.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDateLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excuseTextBox.Text) || string.IsNullOrEmpty(resultsTextBox.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.FileName = excuseTextBox.Text + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {            
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse Written");
            }
        }
        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.FileName = excuseTextBox.Text + ".txt";

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                Random.Enabled = true;
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return false;              
            }
            return true;
        }
        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = resultsTextBox.Text;
            UpdateForm(true);
        }

        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuseTextBox.Text;
            UpdateForm(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePicker1.Value;
            UpdateForm(true);
        }
    }
}
