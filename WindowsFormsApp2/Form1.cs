using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
               Process.Start("https://www.naver.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = (label1.BackColor == Color.Blue) ?
                Color.Azure : Color.Blue;
        }
    }
}

