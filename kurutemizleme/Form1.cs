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

using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace kurutemizleme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        DateTime dt = DateTime.Now;

        public void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string alımtarihi = gunTarihi.Text;
            gunTarihi.Visible = false; //datetimepicker'ı kullanıcı için görünmez yapar
            //Sql bağlantısı
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            cmd3.CommandText = "SELECT secimAdSoyad AS 'Kişiler', alınmaSaati AS 'Saat' FROM seciliYıkamaMakinesi WHERE alınmaTarihi= '" + alımtarihi + "' ";
            SqlDataAdapter DA3 = new SqlDataAdapter(cmd3);
            DataSet DS3 = new DataSet();
            DA3.Fill(DS3);

            AnadataGridView.DataSource = DS3.Tables[0]; //datagriedviewun içine veri atar
            AnadataGridView.AllowUserToAddRows = false; //datagriedviewa kullanıcının manuel veri eklemesini engeller
        }

        private void yuvarlakbuton1_Click(object sender, EventArgs e)
        {
            Form2 frm22 = new Form2();
            frm22.Show();
            this.Hide();
        }

        private void yuvarlakbuton2_Click(object sender, EventArgs e)
        {
            personelGirisi pGiris = new personelGirisi();
            pGiris.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsb.gov.tr/anasayfa.html");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saatArama_TextChanged(object sender, EventArgs e)
        {
            string alımtarihi = gunTarihi.Text;
            if (saatArama.Text != "")
                { //saat textboxında kelime girişi olursa if yapısının içine girer
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT secimAdSoyad AS 'Kişiler', alınmaSaati AS 'Saat' FROM seciliYıkamaMakinesi where alınmatarihi = '" + alımtarihi + "' AND alınmaSaati LIKE '" + saatArama.Text + "%'  ";  //girilen değerle eş ya da o değerle başlayan verileri sıralar
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    AnadataGridView.DataSource = DS.Tables[0];
                    AnadataGridView.AllowUserToAddRows = false;
            }
            else
            {
                SqlConnection con5 = new SqlConnection();
                con5.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                SqlCommand cmd5 = new SqlCommand();
                cmd5.Connection = con5;

                cmd5.CommandText = "SELECT secimAdSoyad AS 'Kişiler', alınmaSaati AS 'Saat' FROM seciliYıkamaMakinesi where alınmatarihi = '" + alımtarihi + "' ";
                SqlDataAdapter DA5 = new SqlDataAdapter(cmd5);
                DataSet DS5 = new DataSet();
                DA5.Fill(DS5);

                AnadataGridView.DataSource = DS5.Tables[0];
                AnadataGridView.AllowUserToAddRows = false;
            }
            
        }

        private void gunTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string alımtarihi = gunTarihi.Text;
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch == 8)
            {
                SqlConnection con5 = new SqlConnection();
                con5.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                SqlCommand cmd5 = new SqlCommand();
                cmd5.Connection = con5;

                cmd5.CommandText = "SELECT secimAdSoyad AS 'Kişiler', alınmaSaati AS 'Saat' FROM seciliYıkamaMakinesi where alınmatarihi = '" + alımtarihi + "' ";
                SqlDataAdapter DA5 = new SqlDataAdapter(cmd5);
                DataSet DS5 = new DataSet();
                DA5.Fill(DS5);

                AnadataGridView.DataSource = DS5.Tables[0];
                AnadataGridView.AllowUserToAddRows = false;
            }
        }
    }
}
