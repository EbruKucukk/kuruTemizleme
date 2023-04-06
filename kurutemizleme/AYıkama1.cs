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
    public partial class AYıkama1 : Form
    {
        public AYıkama1()
        {
            InitializeComponent();
        }

        private void AYıkama1_Load(object sender, EventArgs e)
        {
            alınanSaat.Visible = false;
            //Arka plan rengini görünmez yapıyor
            this.BackColor = Color.PaleVioletRed;
            this.TransparencyKey = Color.PaleVioletRed;

            //Sql Bağlantısı
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            //veritabanından seçilmiş makinelerin verisini seçen kişilerin ismiyle beraber çekiyor
            cmd.CommandText = "SELECT makineSayısı1 AS  'Kişiler' FROM yıkamamakinesi";
            SqlDataReader Sdr = cmd.ExecuteReader();

            //comboboxın içine veri aktarma
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    alınanMakine.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
            string alınmasaati = alınanSaat.Text;
            String alımtarihi = alınmaTarihi.Text;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();
            //datagriedviewun içine belirli saatte makine seçen kişilerin isimlerinin verisini atıyor 
            cmd2.CommandText = "SELECT secimAdSoyad AS  'Kişiler' FROM seciliYıkamaMakinesi WHERE alınmaSaati = '" + alınmasaati + "' AND alınmaTarihi = '"+  alımtarihi +"'";
            SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
            DataSet DS2 = new DataSet();
            DA2.Fill(DS2);

            A1dataGridView.DataSource = DS2.Tables[0];

            A1dataGridView.AllowUserToAddRows = false; //datagriedviewa kullanıcının manuel veri eklemesini engeller
            con.Close();
        }
        int count;
        int count2;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void islemButonu1_Click(object sender, EventArgs e)
        {
            //textbox içine veri girilirse kod if yapıısının içine girer
            if (secimTC.Text != "")
            {
                String secimtc = secimTC.Text;
                String alımtarihi = alınmaTarihi.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from users where tc = '" + secimtc + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                
                if (DS.Tables[0].Rows.Count != 0) //girilen tc kimlik numarası veritabanına kayıtlıysa if yapısının içine girer
                {
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = con;
                    cmd3.CommandText = "select count(secimTC) from seciliYıkamaMakinesi where secimTC = '" + secimtc + "' AND alınmaTarihi = '"+ alımtarihi +"'";
                    SqlDataAdapter DA3 = new SqlDataAdapter(cmd3);
                    DataSet DS3 = new DataSet();
                    DA3.Fill(DS3);

                    count2 = int.Parse(DS3.Tables[0].Rows[0][0].ToString());

                    secimAdSoyad.Text = DS.Tables[0].Rows[0][4].ToString();
                    
                    if (count2 <= 0)  //seçen kişi o gün içerisinde daha önce makine seçmediyse if yapısının içine girer
                    {
                        string alınmasaati = alınanSaat.Text;
                        string alınanmakine = alınanMakine.Text;
                        String alınmatarihi = alınmaTarihi.Text;

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.CommandText = "select count(seciliMakineSayisi1) from seciliYıkamaMakinesi where seciliMakineSayisi1 = '" + alınanmakine + "' AND alınmaSaati = '" + alınmasaati + "' AND alınmaTarihi = '" + alınmatarihi + "'";
                        SqlDataAdapter DA1 = new SqlDataAdapter(cmd2);
                        DataSet DS1 = new DataSet();
                        DA1.Fill(DS1);

                        count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                        if (alınanMakine.SelectedIndex != -1 && count <= 0)      //comboboxtan veri seçildiğinde bu veri daha önce seçilmemiş bir veriyse if yapısının içine girer
                        {
                            String tc2 = secimTC.Text;
                            String adsoyad2 = secimAdSoyad.Text;

                            SqlConnection con2 = new SqlConnection();
                            con2.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                            SqlCommand cmd4 = new SqlCommand();
                            cmd4.Connection = con2;
                            con2.Open();
                            //comboboxtan seçilen ve textboxlara girilen verilerle seçili makinelerin veritabanına data insertler
                            cmd4.CommandText = cmd4.CommandText = "insert into seciliYıkamaMakinesi(seciliMakineSayisi1, alınmaTarihi, secimTC, secimAdSoyad, alınmaSaati)  VALUES ( '" + alınanmakine + "', '" + alınmatarihi + "', '" + tc2 + "', '" + adsoyad2 + "', '" + alınmasaati + "')";
                            cmd4.ExecuteNonQuery();
                            con2.Close();

                            messagebox91 msg91 = new messagebox91();
                            msg91.Show();
                        }
                        else
                        {
                            messageboxx3 msg33 = new messageboxx3();
                            msg33.Show();
                        }
                    }
                    else
                    {
                        messageboxx4 msg44 = new messageboxx4();
                        msg44.Show();
                    }

                }
                else
                {
                    secimTC.Clear();
                    secimAdSoyad.Clear();
                    messagebox3 msg3 = new messagebox3();
                    msg3.Show();
                }
            
        }
    }
        private void A1dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void secimASoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyarıYazı_Click(object sender, EventArgs e)
        {

        }

        private void alınanSaat_Click(object sender, EventArgs e)
        {

        }

        private void secimTC_TextChanged(object sender, EventArgs e)
        {
            alınanSaat.Visible = true;
        }
    }
}
