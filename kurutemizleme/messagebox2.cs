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
    public partial class messagebox2 : Form
    {
        public messagebox2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Form1 fm4 = new Form1();
            fm4.Show();
            this.Hide();
            Form3 obj3 = (Form3)Application.OpenForms["Form3"]; //Bir formdan başka bir formu kapatmak için
            obj3.Close();
        }
    }
}
