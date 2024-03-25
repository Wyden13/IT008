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

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AboutForm frm=new AboutForm())
            {
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var drive in System.IO.DriveInfo.GetDrives())
            {
                toolStripComboBox1.Items.Add(drive.Name);
            }

        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            txtPath.Text = toolStripComboBox1.Text.Trim();
          
                DirectoryInfo dir=new DirectoryInfo(txtPath.Text);
                FileSystemInfo[] allElements = dir.GetFileSystemInfos();
                foreach(FileSystemInfo file in allElements)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    if (File.Exists(file.FullName))
                    {
                        long length= new FileInfo(file.FullName).Length;
                        string type = new FileInfo(file.FullName).Extension;
                        item.SubItems.Add(type);
                        item.SubItems.Add(length.ToString());
                    }
                    
                    if (Directory.Exists(file.FullName))
                    {
                        item.SubItems.Add("<DIR>");
                        item.SubItems.Add("");
                    }
                    var lastModified = System.IO.File.GetLastWriteTime(file.FullName);
                    item.SubItems.Add(lastModified.ToString("dd/MM/yyyy hh:mm:ss tt"));
                    listView1.Items.Add(item);
                }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)

        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem items = info.Item;
            if (items != null)
            {

                var item = listView1.SelectedItems[0].ToString();
                //string item = listView1.SelectedItems.ToString();
                if (System.IO.File.Exists(item))
                {
                    System.IO.FileInfo myfile = new System.IO.FileInfo(listView1.SelectedItems.ToString());
                    System.IO.TextReader mydata = myfile.OpenText();

                }
                else if (System.IO.Directory.Exists(item))
                {
                    listView1.Items.Clear();
                    txtPath.Text = item;
                    DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
                    FileSystemInfo[] allElements = dir.GetFileSystemInfos();
                    foreach (FileSystemInfo file in allElements)
                    {
                        items = new ListViewItem(file.Name);
                        if (File.Exists(file.FullName))
                        {
                            long length = new FileInfo(file.FullName).Length;
                            string type = new FileInfo(file.FullName).Extension;
                            items.SubItems.Add(type);
                            items.SubItems.Add(length.ToString());
                        }

                        if (Directory.Exists(file.FullName))
                        {
                            items.SubItems.Add("<DIR>");
                            items.SubItems.Add("");
                        }
                        var lastModified = System.IO.File.GetLastWriteTime(file.FullName);
                        items.SubItems.Add(lastModified.ToString("dd/MM/yyyy hh:mm:ss tt"));
                        listView1.Items.Add(item);
                    }

                }
            }
            else
            {
                this.listView1.SelectedItems.Clear();
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if (item == null)
            {
                this.listView1.SelectedItems.Clear();
            }
           
        }
    }
}
