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
    public partial class Twistter : Form
    {
        public Twistter()
        {
            InitializeComponent();
        }

        private void Twistter_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "My Twistter . Click here .";
            linkLabel1.Links.Add(13, 11, "https://twitter.com/Zen_Habuto");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
