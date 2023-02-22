using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
        }

        private void Facebook_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "My Facebook . Click here .";
            linkLabel1.Links.Add(13, 11, "https://www.facebook.com/huydang2805/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
