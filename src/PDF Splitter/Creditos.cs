using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Splitter
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void LLAleph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLAleph.LinkVisited = true;
            System.Diagnostics.Process.Start("https://go.alephsub0.org/acerca-de");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alephsub0/PDF-Splitter/blob/main/LICENSE");
        }
    }
}
