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
    public partial class messagebox1 : Form
    {
        public messagebox1()
        {
            InitializeComponent();
        }
        public Image MesajIconu
        {
            get { return mesajIconu.Image; }
            set { mesajIconu.Image = value; }
        }
        public string Mesaj
        {
            get { return uyarı.Text; }
            set { uyarı.Text = value; }

        }

        private void uyarı_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mesajIconu_Click(object sender, EventArgs e)
        {

        }
    }
}
