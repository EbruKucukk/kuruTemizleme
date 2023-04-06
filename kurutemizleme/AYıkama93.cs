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
    public partial class AYıkama93 : Form
    {
        public AYıkama93()
        {
            InitializeComponent();
        }

        private void AYıkama93_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
            this.TransparencyKey = Color.PaleVioletRed;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT makineSayısı1 AS  'Kişiler' FROM yıkamamakinesi";
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    alınanMakine10.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
            string alınmasaati = alınanSaat2.Text;
            String alımtarihi = alınmaTarihi10.Text;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();
            cmd2.CommandText = "SELECT secimAdSoyad AS  'Kişiler' FROM seciliYıkamaMakinesi WHERE alınmaSaati = '" + alınmasaati + "'AND alınmaTarihi = '" + alımtarihi + "' ";
            SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
            DataSet DS2 = new DataSet();
            DA2.Fill(DS2);

            A10dataGridView.DataSource = DS2.Tables[0];
            A10dataGridView.AllowUserToAddRows = false;
            con.Close();
        }
        int count;
        int count2;

        private void islemButonu10_Click(object sender, EventArgs e)
        {
            if (secimTC10.Text != "")
            {
                String secimtc = secimTC10.Text;
                String alımtarihi = alınmaTarihi10.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from users where tc = '" + secimtc + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = con;
                    cmd3.CommandText = "select count(secimTC) from seciliYıkamaMakinesi where secimTC = '" + secimtc + "' AND alınmaTarihi = '" + alımtarihi + "'";
                    SqlDataAdapter DA3 = new SqlDataAdapter(cmd3);
                    DataSet DS3 = new DataSet();
                    DA3.Fill(DS3);

                    count2 = int.Parse(DS3.Tables[0].Rows[0][0].ToString());

                    secimAdSoyad10.Text = DS.Tables[0].Rows[0][4].ToString();
                    if (count2 <= 0)
                    {
                        string alınmasaati = alınanSaat2.Text;
                        string alınanmakine = alınanMakine10.Text;
                        String alınmatarihi = alınmaTarihi10.Text;

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.CommandText = "select count(seciliMakineSayisi1) from seciliYıkamaMakinesi where seciliMakineSayisi1 = '" + alınanmakine + "' AND alınmaSaati = '" + alınmasaati + "' AND alınmaTarihi = '" + alınmatarihi + "'";
                        SqlDataAdapter DA1 = new SqlDataAdapter(cmd2);
                        DataSet DS1 = new DataSet();
                        DA1.Fill(DS1);

                        count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                        if (alınanMakine10.SelectedIndex != -1 && count <= 0)
                        {
                            String tc2 = secimTC10.Text;
                            String adsoyad2 = secimAdSoyad10.Text;

                            SqlConnection con2 = new SqlConnection();
                            con2.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=kuru.temizleme;Integrated Security=True";
                            SqlCommand cmd4 = new SqlCommand();
                            cmd4.Connection = con2;
                            con2.Open();
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
                    secimTC10.Clear();
                    secimAdSoyad10.Clear();
                    messagebox3 msg3 = new messagebox3();
                    msg3.Show();
                }
            }
        }
    }
}
