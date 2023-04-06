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
    public partial class messagebox8 : Form
    {
        public messagebox8()
        {
            InitializeComponent();
        }

        private void messagebox8_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
            this.BackColor = Color.Red;
        }
    }
}
