using System;
using System.Drawing;
using System.Windows.Forms;

namespace filesystemwatcher
{
    public partial class FormMain : Form
    {
        readonly Color defaultColor;

        void checkInput()
        {
            fileSystemWatcher.EnableRaisingEvents = false;
            comboBoxDirectory.ForeColor = defaultColor;

            try
            {
                fileSystemWatcher.Path = comboBoxDirectory.Text;
                fileSystemWatcher.EnableRaisingEvents = checkBoxEnabled.Checked;
            }
            catch
            {
                if (checkBoxEnabled.Checked)
                {
                    comboBoxDirectory.ForeColor = Color.Red;
                }
            }
        }

        void fileSystemWatcher_Modified(object sender, System.IO.FileSystemEventArgs e)
        {
            putLog(DateTime.Now.ToString() + " " + e.ChangeType.ToString() + ":" + e.FullPath);
        }

        void putLog(string text)
        {
            if (checkBoxDesc.Checked)
            {
                textBoxLogs.Text = text + "\r\n" + textBoxLogs.Text;
                textBoxLogs.Select(0, 0);
            }
            else
            {
                textBoxLogs.Text = (textBoxLogs.Text + text + "\r\n");
                textBoxLogs.Select((textBoxLogs.Text.Length - 1), 0);
            }
        }

        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            defaultColor = comboBoxDirectory.ForeColor;
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            string[] lines = textBoxLogs.Lines;

            if (lines.Length < 1)
            {
                return;
            }

            var newLines = new string[lines.Length];

            if (lines.Length > 1)
            {
                Array.Copy(lines, 0, newLines, 1, (lines.Length - 1));
            }

            Array.Copy(lines, (lines.Length - 1), newLines, 0, 1);
            Array.Reverse(newLines);
            textBoxLogs.Lines = newLines;
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void checkBoxSubDirectory_CheckedChanged(object sender, EventArgs e)
        {
            fileSystemWatcher.IncludeSubdirectories = checkBoxSubDirectory.Checked;
        }

        private void comboBoxDirectory_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            fileSystemWatcher_Modified(sender, e);
        }
    }
}
