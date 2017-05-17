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

namespace ISeeYou
{
    public partial class Form1 : Form
    {
        List<string> filenames = new List<string>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void rightEyeButton_Click(object sender, EventArgs e)
        {

        }
        private void leftEyeButton_Click(object sender, EventArgs e)
        {

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
                pictureBox.Image = Image.FromFile(filenames[index]);
            }
        }
#pragma region Navigation Button
        private void previousButton_Click(object sender, EventArgs e)
        {
            index = (index == 0 ? filenames.Count-1 : index-1);
            try
            {
                pictureBox.Image = Image.FromFile(filenames[index]);
            }
            catch(OutOfMemoryException ignored)
            {
            }
        }

    
        private void nextButton_Click(object sender, EventArgs e)
        {
            index = (index == filenames.Count - 1 ? 0 : index+1);
            try
            {
                pictureBox.Image = Image.FromFile(filenames[index]);
            }
            catch (OutOfMemoryException ignored)
            {
            }
        }
#pragma endregion
#pragma region Phase Button
        private void phaseOneButton_Click(object sender, EventArgs e)
        {

        }

        private void phaseTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void phaseThreeButton_Click(object sender, EventArgs e)
        {

        }

        private void phaseFourButton_Click(object sender, EventArgs e)
        {

        }

        private void phaseFiveButton_Click(object sender, EventArgs e)
        {

        }


#pragma endregion

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

    }
}
