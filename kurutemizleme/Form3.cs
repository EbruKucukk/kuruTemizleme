using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kurutemizleme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            kayıtSifre.PasswordChar = '*'; //şifre girdisini * ile saklar
            kayıtSifre.MaxLength = 20;
            kayitSifre2.PasswordChar = '*';
            kayitSifre2.MaxLength = 20;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void yuvarlakbuton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 13)
            {
                e.Handled = true;
                messagebox1 m = new messagebox1();
                m.Show();
            }
        }

        private void kayitSifre2_TextChanged(object sender, EventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kayıtTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                if (kayıtTC.TextLength != 11)
                {
                    messagebox4 mssg4 = new messagebox4();
                    mssg4.Show();
                }
            }
        }
        private void kayıtEposta_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void kayıtSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void kayitSifre2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kayıtTC_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void kayıtEposta_TextChanged(object sender, EventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void kayıtTC_MouseLeave(object sender, EventArgs e)
        {

        }

        private void kayıtEposta_Click(object sender, EventArgs e)
        {

        }

        private void kayıtEposta_MouseClick(object sender, MouseEventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void kayıtSifre_MouseClick(object sender, MouseEventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void yuvarlakbuton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsb.gov.tr/anasayfa.html");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 frm4 = new Form1();
            frm4.Show();
            this.Hide();
        }

        private void kayıtAdSoyad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                if (kayıtTC.TextLength != 11)
                {
                    messagebox4 mssg4 = new messagebox4();
                    mssg4.Show();
                }
            }
        }

        private void kayıtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (kayıtTC.TextLength != 11)
            {
                messagebox4 mssg4 = new messagebox4();
                mssg4.Show();
            }
        }

        private void kayıtButonu_Click(object sender, EventArgs e)
        {
            if (kayıtSifre.Text != kayitSifre2.Text)
            {
                messagebox7 msg7 = new messagebox7();
                msg7.Show();
            }
            else
            {
                if (kayıtTC.Text == "" || kayıtAdSoyad.Text == "" || kayıtEposta.Text == "" || kayıtSifre.Text == "") //textboxlardan herhangi biri boşsa hata mesajı verir
                {
                    messagebox6 msg6 = new messagebox6();
                    msg6.Show();
                }
                else
                {
                    Int64 tc = Int64.Parse(kayıtTC.Text);
                    String eposta = kayıtEposta.Text;
                    String passwrd = kayıtSifre.Text;
                    String adSoyad = kayıtAdSoyad.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                    con.Open();
                    SqlCommand tekrarKayıt = new SqlCommand("SELECT tc FROM users WHERE tc= '" + kayıtTC.Text + "'", con);
                    SqlDataAdapter sd = new SqlDataAdapter(tekrarKayıt);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    if (dt.Rows.Count > 0)  //girilen kimlik  numarası sisteme zaten kayıtlıysa hata mesajı verir
                    {
                        messagebox9 msg9 = new messagebox9();
                        msg9.Show();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO users(tc, eposta, passwrd, adSoyad) VALUES ('" + kayıtTC.Text + "', '" + kayıtEposta.Text + "','" + kayıtSifre.Text + "','" + kayıtAdSoyad.Text + "')"; //veritabanına veri ekler
                        cmd.ExecuteNonQuery();
                        messagebox2 msgmsg2 = new messagebox2();
                        msgmsg2.Show();
                    }
                    con.Close();
                }
            }
        }
    }
}