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
    public partial class personelGirisi : Form
    {
        public personelGirisi()
        {
            InitializeComponent();
            personelSifresi.PasswordChar = '*';
            personelSifresi.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void personelSifresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Veritabanında şifresi ile kayıtlı kişinin giriş yapabilmesi için gerekli sql sorgusu
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM personelGirisi where personelPassword = '" + personelSifresi.Text + " '";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0) //veritabanında bu şifre bir personele kayıtlıysa if yapısının içine girer
            {
                Form3 form33 = new Form3();
                form33.Show();
                this.Hide();
                Form1 objj1 = (Form1)Application.OpenForms["Form1"]; //Bir formdan başka bir formu kapatmak için
                objj1.Hide();
            }
            else
            {
                messagebox8 msg8 = new messagebox8();
                msg8.Show();
            }
        }

        private void personelGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
