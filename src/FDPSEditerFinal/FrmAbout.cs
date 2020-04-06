using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void richTextBoxThanks_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            GlobalSpecs.DeveloperMagicCount = 1;
        }
    }
}
