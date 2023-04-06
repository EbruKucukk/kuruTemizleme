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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            girisSifre.PasswordChar = '*';
            girisSifre.MaxLength = 20;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int count;
        private void yuvarlakbuton1_Click(object sender, EventArgs e)
        {
            //Veritabanında kayıtlı kişinin giriş yapabilmesi için gerekli sql sorgusu
            if (girisTC.Text == "" || girisSifre.Text == "") //textboxlar boşsa if yapısının içine girer
            {
                messagebox6 msg6 = new messagebox6();
                msg6.Show();
            }
            else //textboxlara veri girildiyse else yapısının içine girer
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //textboxlara girilen verilerle veri çekme işlemi yapar
                cmd.CommandText = "SELECT * FROM users where tc ='" + girisTC.Text + "'and passwrd ='" + girisSifre.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    giris Kp = new giris();
                    Kp.Show();
                }
                else
                {
                    messagebox3 msg3 = new messagebox3();
                    msg3.Show();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void yuvarlakbuton3_Click(object sender, EventArgs e)
        {
            Form1 frmmmm1 = new Form1(); //Başka forma geçiş
            frmmmm1.Show();
            this.Hide();
        }

        private void parola1_TextChanged(object sender, EventArgs e)
        {
            //TC kimlik numarası 11 haneden fazla olursa uyarı verilmesi için kod blogu
                if (girisTC.TextLength != 11)
                {
                    messagebox4 mssg4 = new messagebox4();
                    mssg4.Show();
                }
    }

        private void KullanıcıTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void KullanıcıTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tc kimlik girdisinde sadece enter ve geri tuşuna izin verir
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 13)
            {
                e.Handled = true;
                messagebox1 m = new messagebox1();
                m.Show();
            }
        }

        private void girisTC_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}"); //boşluk tuşuna basıldığında bir alt öğeye iner

                if (girisTC.TextLength != 11) //girdi 11 haneli değilse hata mesajı gelir
                {
                    messagebox4 mssg4 = new messagebox4();
                    mssg4.Show();
                }
            }
        }

        private void girisTC_MouseEnter(object sender, EventArgs e)
        {

        }

        private void girisTC_MouseClick(object sender, MouseEventArgs e)
        {
            if (girisTC.Text == "T.C. Kimlik Numarası")
            {
                girisTC.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsb.gov.tr/anasayfa.html");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 frm111 = new Form1();
            frm111.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void yuvarlakbuton2_Click(object sender, EventArgs e)
        {
            messageboxx2 msgbxx = new messageboxx2();
            msgbxx.Show();
        }
    }
}