using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mista_Ukraine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
            

        private void граToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 f2 = new Form2();
           f2.Show();
           this.Hide();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2),
                (ScreenHeight / 2) - (this.Height / 2));
        
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Навчально ігрова програма 'Міста України' 2013");
        }
    }
}
