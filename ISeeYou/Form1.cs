using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ISeeYou
{
    public partial class Form1 : Form
    {
        List<string> filenames = new List<string>();
        List<Entry> entries = new List<Entry>();
        Entry currentEntry;
        int index;
        StreamWriter sw = File.AppendText("outout.json");
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentEntry.side = "u";
        }
        private void rightEyeButton_Click(object sender, EventArgs e)
        {
            currentEntry.side = "p";
        }
        private void leftEyeButton_Click(object sender, EventArgs e)
        {
            currentEntry.side = "l";
        }


        private void openFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                filenames.Clear();
                index = 0;
                foreach (string file in Directory.EnumerateFiles(folderBrowser.SelectedPath, "*.*", SearchOption.AllDirectories))
                {
                    filenames.Add(file);
                }
                
                pictureBox.Image = readFile(filenames[index]);



            }
        }
        
        private Image readFile(string path)
        {
            currentEntry = new Entry();
            currentEntry.dir = Path.GetDirectoryName(path);
            currentEntry.name = Path.GetFileName(path);
            Image image = Image.FromFile(path);
            currentEntry.size = image.Size;
            return image;
        }

#pragma region Navigation Button
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.side != null && currentEntry.phase != null)
            {
                entries.Add(currentEntry);
                appendJson();
                index = (index == 0 ? filenames.Count - 1 : index - 1);
                try
                {
                    pictureBox.Image = readFile(filenames[index]);

                }
                catch (OutOfMemoryException ignored)
                {
                }
            }
        }

    
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.side != null && currentEntry.phase != null)
            {
                entries.Add(currentEntry);
                appendJson();
                index = (index == filenames.Count - 1 ? 0 : index + 1);
                try
                {
                    pictureBox.Image = readFile(filenames[index]);
                }
                catch (OutOfMemoryException ignored)
                {
                }
            }
        }
#pragma endregion
#pragma region Phase Button

        private void setPhase_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentEntry.phase = button.Text;
        }


#pragma endregion

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void appendJson()
        {
            var json = new JavaScriptSerializer().Serialize(currentEntry);
            sw.WriteLine(json);
        }

    }
}
