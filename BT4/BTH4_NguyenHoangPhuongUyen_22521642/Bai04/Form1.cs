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
namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FontFamily[] ff = FontFamily.Families;

            for (int i = 0; i < ff.Length; i++)

            {

                ComboBoxFonts.Items.Add(ff[i].Name);

            }
            for (int i = 8; i <= 72; i++)

            {

                ComboBoxSizes.Items.Add(i);
            }
        }
        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color= richTextBox1.ForeColor;  
            if(fontDialog1.ShowDialog()== DialogResult.OK ) {
                richTextBox1.SelectionColor = fontDialog1.Color;
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "file text (*.txt;*.rtf)|*.txt;*.rtf| All files (*.*)|*.*";
            openFileDialog1.Title = "Open File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
