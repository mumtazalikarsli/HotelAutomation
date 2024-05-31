using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class OdaKayitFormu : Form
    {
        
        sqlbaglanti baglanti = new sqlbaglanti();
        public OdaKayitFormu()
        {
            InitializeComponent();
        }
        public string tc;

        private void OdaKayitFormu_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select OdaID from OdaDurum where OdaDurum != 1", baglanti.Baglanti());
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                cmb_oda.Items.Add(oku[0].ToString());
            }
            baglanti.Baglanti().Close();
            m_txt_tc.Text = tc;
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            DateTime startDate = date_giris.Value;
            DateTime endDate = date_cikis.Value;

            TimeSpan fark = endDate - startDate;

            try
            {
                if (date_cikis.Value > date_giris.Value) 
                {
                    SqlCommand cmd = new SqlCommand("insert into Odalar(OdaID,OdaGirisTarihi,OdaCikisTarihi,OdaYemekDahil,MusteriTC) values (@p1,@p2,@p3,@p4,@p5)", baglanti.Baglanti());
                    cmd.Parameters.AddWithValue("@p1", cmb_oda.Text);
                    cmd.Parameters.AddWithValue("@p2", date_giris.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p3", date_cikis.Value.ToString("yyyy-MM-dd"));
                    if (check_yemek.Checked)
                    {
                        cmd.Parameters.AddWithValue("@p4", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p4", false);
                    }
                    cmd.Parameters.AddWithValue("@p5", m_txt_tc.Text);


                    cmd.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    // --------------------------------------------


                    SqlCommand cmd2 = new SqlCommand("insert into MusteriHareket(MusteriTC,OdaID,GirisTarihi,CikisTarihi,ToplamTutar) values (@p1,@p2,@p3,@p4,@p5)", baglanti.Baglanti());
                    cmd2.Parameters.AddWithValue("@p1", m_txt_tc.Text);
                    cmd2.Parameters.AddWithValue("@p2", cmb_oda.Text);
                    cmd2.Parameters.AddWithValue("@p3", date_giris.Value.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("@p4", date_cikis.Value.ToString("yyyy-MM-dd"));
                    if (check_yemek.Checked)
                    {
                        cmd2.Parameters.AddWithValue("@p5", (fark.Days + 1) * 1250);
                    }
                    else
                    {
                        cmd2.Parameters.AddWithValue("@p5", (fark.Days + 1) * 1000);
                    }

                    cmd2.ExecuteNonQuery();
                    baglanti.Baglanti().Close();


                    SqlCommand cmd3 = new SqlCommand("update OdaDurum set OdaDurum = 1 where OdaID = @p1", baglanti.Baglanti());
                    cmd3.Parameters.AddWithValue("@p1", cmb_oda.Text);
                    cmd3.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    MessageBox.Show("Müşteri Kaydı eklendi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Çıkış tarihi giriş tarihinden büyük olmalı.");
                }
            }
            catch
            {
                MessageBox.Show("hata mesajı");
            }
        }
    }
}
