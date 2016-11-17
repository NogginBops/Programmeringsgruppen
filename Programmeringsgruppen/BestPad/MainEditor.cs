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

namespace BestPad
{
    public partial class MainEditor : Form
    {
        public MainEditor()
        {
            InitializeComponent();
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            MainText.Text = "";
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            ApplyDefaultDialogSettings(fileDialog);

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                MainText.Text = File.ReadAllText(fileDialog.FileName);
            }
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();

            ApplyDefaultDialogSettings(fileDialog);
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = fileDialog.OpenFile())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(MainText.Text);
                    }
                }
            }
        }

        private void ApplyDefaultDialogSettings(FileDialog fileDialog)
        {
            fileDialog.AddExtension = true;

            fileDialog.DefaultExt = "txt";

            fileDialog.Title = "Save a text file! :D";

            fileDialog.Filter = "Text|*.txt";
        }
        
        private void MainText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainText_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MainText.Text = File.ReadAllText(files[0]);
        }
    }
}
