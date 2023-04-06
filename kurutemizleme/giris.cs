using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurutemizleme
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        private void giris_Load(object sender, EventArgs e)
        {
           
        }

        private void aBLOKToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void yIKAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Bu form dışındaki açık formları kapatır
            {
                if (Application.OpenForms[i].Name == "saatler2")
                    Application.OpenForms[i].Close();
            }
                saatler saatler1 = new saatler();
            saatler1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "AYıkama1")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama3")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama4")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama5")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama6")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama7")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama8")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama9")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama90")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama91")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "AYıkama2")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "saatler")
                    Application.OpenForms[i].Close();
                else if (Application.OpenForms[i].Name == "Ayıkama92")
                    Application.OpenForms[i].Close();
            }
            Form1 frm1m = new Form1(); //Başka bir forma geçiş yapmak için
            frm1m.Show();
            this.Hide();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                    Application.OpenForms[i].Close();
            }
        }

        private void bBLOKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            messagebox92 msg92 = new messagebox92();
            msg92.Show();
        }

        private void yIKAMAToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cBLOKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            messagebox92 msg92 = new messagebox92();
            msg92.Show();
        }

        private void islemButonu1_Click(object sender, EventArgs e)
        {

        }

        private void A1dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void secimASoyad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kURUTMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Bu form dışındaki açık formları kapat
            {
                if (Application.OpenForms[i].Name == "saatler")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
