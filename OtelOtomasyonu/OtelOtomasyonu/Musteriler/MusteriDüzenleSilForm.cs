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

namespace OtelOtomasyonu
{
    public partial class MusteriDüzenleSilForm : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public MusteriDüzenleSilForm()
        {
            InitializeComponent();
        }
        public string tc, ad, soyad, yas, telefon, cinsiyet, adres;

        private void btn_düzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Musteriler set MusteriAdi = @p1,MusteriSoyadi = @p2,MusteriCinsiyet = @p3,MusteriYas = @p4,MusteriTelefon = @p5,MusteriAdres = @p6 Where MusteriTC = @p7", baglanti.Baglanti());
                cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
                cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
                if (radio_erkek.Checked)
                {
                    cmd.Parameters.AddWithValue("@p3", "E");
                }
                else if (radio_kadın.Checked)
                {
                    cmd.Parameters.AddWithValue("@p3", "K");
                }
                cmd.Parameters.AddWithValue("@p4", num_yas.Text);
                cmd.Parameters.AddWithValue("@p5", m_txt_telefon.Text);
                cmd.Parameters.AddWithValue("@p6", r_txt_adres.Text);
                cmd.Parameters.AddWithValue("@p7", m_txt_tc.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri bilgileri başarıyla düzenlendi.");
                baglanti.Baglanti().Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Müşteri bilgileri düzenlenirken bir hatayla karşılaşılı.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string odasayisi;
            SqlCommand cmd0 = new SqlCommand("select COUNT(OdaID) from Odalar Where MusteriTC =@p0",baglanti.Baglanti());
            cmd0.Parameters.AddWithValue("@p0", m_txt_tc.Text);
            odasayisi = cmd0.ExecuteScalar()?.ToString();
            baglanti.Baglanti().Close();

            if ( Convert.ToInt32(odasayisi) > 0)
            {
                MessageBox.Show("Oda kaydı olan müşteriye silme işlemi uygulayamazsınız");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from MusteriHareket where MusteriTC = @p1", baglanti.Baglanti());
                    cmd.Parameters.AddWithValue("@p1", m_txt_tc.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    // ----------

                    SqlCommand cmd2 = new SqlCommand("delete from Mesajlar where MusteriTC = @p2", baglanti.Baglanti());
                    cmd2.Parameters.AddWithValue("@p2", m_txt_tc.Text);
                    cmd2.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    // ----------


                    SqlCommand cmd3 = new SqlCommand("delete from Odalar where MusteriTC = @p3", baglanti.Baglanti());
                    cmd3.Parameters.AddWithValue("@p3", m_txt_tc.Text);
                    cmd3.ExecuteNonQuery();
                    baglanti.Baglanti().Close();


                    // ----------


                    SqlCommand cmd4 = new SqlCommand("delete from Musteriler Where MusteriTC = @p4", baglanti.Baglanti());
                    cmd4.Parameters.AddWithValue("@p4", m_txt_tc.Text);
                    cmd4.ExecuteNonQuery();
                    baglanti.Baglanti().Close();




                    MessageBox.Show("Müşteri başarıyla kaldırılmıştır.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("İşlem sırasında bir hata oldu.");
                }
            }
        }

        private void MusteriDüzenleSilForm_Load(object sender, EventArgs e)
        {
            try
            {
                m_txt_tc.Text = tc;
                txt_ad.Text = ad;
                txt_soyad.Text = soyad;
                num_yas.Text = yas; 
                m_txt_telefon.Text = telefon;
                if (cinsiyet == "E")
                {
                    radio_erkek.Checked = true;
                }
                else if (cinsiyet == "K")
                {
                    radio_kadın.Checked = true;
                }
                r_txt_adres.Text = adres;
            }
            catch 
            {
                MessageBox.Show("Bir hata oldu");
            }

        }
    }
}
