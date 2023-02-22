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
    public partial class Instagram : Form
    {
        public Instagram()
        {
            InitializeComponent();
        }

        private void Instagram_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "My Ins . Click here .";
            linkLabel1.Links.Add(9, 10, "https://www.instagram.com/_emoghl/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
