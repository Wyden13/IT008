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
using System.Threading;

namespace Bai01
{
    public partial class Form1 : Form
    {

        public string Filepath { get; set; }
        public string Filename { get; set; }
        public double Filesize { get; set; }
        public string Status { get; set; }
        public double Percentage
        {
            get; set;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DownloadFile file;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (Form2 f = new Form2(this))
            {
                if(f.ShowDialog(this)==DialogResult.OK)
                {
                    Thread thread = new Thread(new ThreadStart());
                    Filename = Properties.Settings.Default.Path;
                    Filepath = Properties.Settings.Default.Url;
                    

                }
            }
        }
        WebClient client;
        ListViewItem item;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double receive = double.Parse(e.BytesReceived.ToString());
            Filesize=double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = receive / Filesize * 100;
            lblProgress.Text=$"{string.Format("{0}", Percentage)}";
            if(Percentage == 100)
            {
                lblStatus.Text = "Completed";
            }
            else
            {
                lblStatus.Text = "Downloading";
            }
        }
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            item.SubItems.Add(Filename);
            item.SubItems.Add(Filesize.ToString());
            item.SubItems.Add(Filepath);
            item.SubItems.Add(Percentage.ToString());
            listView1.Items.Add(item);
            
        }
    }
}
