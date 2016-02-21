using System;
using System.Drawing;
using System.Windows.Forms;

namespace filesystemwatcher
{
    public partial class FormMain : Form
    {
        readonly Color defaultColor;
        const string newLineCode = "\r\n";

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
            bool desc = checkBoxDesc.Checked;
            string newText;
            string newLine = text + newLineCode;

            if (desc)
            {
                newText = newLine + textBoxLogs.Text;
            }
            else
            {
                newText = textBoxLogs.Text + text + newLineCode;
            }

            int newLength = newText.Length;
            int maxLength = textBoxLogs.MaxLength;

            if (newLength > maxLength)
            {
                int line;
                string[] lines = textBoxLogs.Lines;

                if (desc)
                {
                    for (line = lines.Length - 1; line >= 0 && (newLength > maxLength); newLength -= (lines[line].Length + newLineCode.Length), --line)
                    {
                    }

                    newText = newText.Substring(0, newLength);
                }
                else
                {
                    for (line = 0; line < lines.Length && (newLength > maxLength); newLength -= (lines[line].Length + newLineCode.Length), ++line)
                    {
                    }

                    newText = newText.Substring(newText.Length - newLength);
                }
            }

            textBoxLogs.Text = newText;
            int selectIndex = (desc ? 0 : (newText.Length - 1));
            textBoxLogs.Select(selectIndex, 0);
            //textBoxLogs.Focus();
            textBoxLogs.ScrollToCaret();
        }

        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = Size;
            defaultColor = comboBoxDirectory.ForeColor;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogs.Clear();
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            string[] lines = textBoxLogs.Lines;

            if (lines.Length <= 1)
            {
                return;
            }

            var newLines = new string[lines.Length];
            Array.Copy(lines, 0, newLines, 1, (lines.Length - 1));
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
