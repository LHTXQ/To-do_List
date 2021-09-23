using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class aboutwindow : Form
    {
        public aboutwindow()
        {
            InitializeComponent();
            Versionlabel.Text= "版本号：" + To_do_List.MainWindow.Version;
            int now = 2021;
            if(DateTime.Now.Year > now)
            {
                now = DateTime.Now.Year;
            }
            this.aboutlabel.Text = "刘汉涛   版权所有  2021 - " + now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
                this.Close();
                this.Dispose();
            }
            catch
            {

            }
        }
    }
}
