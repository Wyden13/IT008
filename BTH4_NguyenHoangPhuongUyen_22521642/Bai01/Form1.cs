using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Nhan chuot trai o toa do (" + e.X + "," + e.Y + ")");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Nhan chuot phai (" + e.X + ", " + e.Y + ")");
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Nhan chuot giua (" + e.X + "," + e.Y + ")");
            }
        }
        /*protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MessageBox.Show("Ban vua nhan chuot " + e.Button+ " o toa do ("+e.X+","+e.Y+")");
        }*/
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            MessageBox.Show(e.KeyCode.ToString());
        }
    }
}
