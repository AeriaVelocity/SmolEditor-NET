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

namespace SmolEditor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            editorBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, editorBox.Text);
        }

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (darkMode.Checked)
            {
                this.BackColor = ColorTranslator.FromHtml("#555555");
                MainLabel.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
                editorBox.BackColor = ColorTranslator.FromHtml("#222222");
                editorBox.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
                writeButton.BackColor = ColorTranslator.FromHtml("#333333");
                writeButton.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
                visitButton.BackColor = ColorTranslator.FromHtml("#333333");
                visitButton.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
                darkMode.BackColor = ColorTranslator.FromHtml("#333333");
                darkMode.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
                closeButton.BackColor = ColorTranslator.FromHtml("#333333");
                closeButton.ForeColor = ColorTranslator.FromHtml("#EEEEEE");
            }
            else
            {
                this.BackColor = SystemColors.Control;
                MainLabel.ForeColor = SystemColors.ControlText;
                editorBox.BackColor = SystemColors.Window;
                editorBox.ForeColor = SystemColors.WindowText;
                writeButton.BackColor = SystemColors.Control;
                writeButton.ForeColor = SystemColors.ControlText;
                visitButton.BackColor = SystemColors.Control;
                visitButton.ForeColor = SystemColors.ControlText;
                darkMode.BackColor = SystemColors.Control;
                darkMode.ForeColor = SystemColors.ControlText;
                closeButton.BackColor = SystemColors.Control;
                closeButton.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
