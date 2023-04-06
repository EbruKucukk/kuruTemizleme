using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurutemizleme
{
    public partial class messageboxx2 : Form
    {
        public messageboxx2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://giris.turkiye.gov.tr/Giris/"); 
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
