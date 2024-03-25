using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form2 : Form
    {
        string Filesave;
        DownloadFile file;
        public Form2(Form1 fmn)
        {
            InitializeComponent();
            fMain = fmn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtURL.Text)|| string.IsNullOrEmpty(txtPath.Text))
            { 
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Properties.Settings.Default.Url = txtURL.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog saveDia = new FolderBrowserDialog())
                if (saveDia.ShowDialog() == DialogResult.OK)
                {
                    Filesave = saveDia.SelectedPath;
                    txtPath.Text = Filesave;
                    Properties.Settings.Default.Path = txtPath.Text;
                    Properties.Settings.Default.Save();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    
     
        private Form1 fMain;

        private void Form2_Load(object sender, EventArgs e)
        {
        }
       

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
