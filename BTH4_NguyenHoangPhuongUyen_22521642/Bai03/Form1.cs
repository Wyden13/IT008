using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();

            UpdateTime();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //OpenFileDialog openFileDialog1;
        string filePath;
        //string fileName;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Mp3, mp4 (*.avi *.mpeg *.wav *.midi *.mp4 *.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3| All files (*.*)|*.*";
            openFileDialog1.Title = "Open File";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = filePath;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {            
            string lb1 = DateTime.Now.ToString("dd/MM/yyyy");
            string lb2 = DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + lb1 + " - Bây giờ là " + lb2;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
