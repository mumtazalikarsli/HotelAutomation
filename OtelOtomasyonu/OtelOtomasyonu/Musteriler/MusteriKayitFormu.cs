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

namespace OtelOtomasyonu
{
    public partial class MusteriKayitFormu : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        
        public MusteriKayitFormu()
        {
            InitializeComponent();
        }
        
        
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Musteriler (MusteriTC,MusteriAdi,MusteriSoyadi,MusteriCinsiyet,MusteriYas,MusteriTelefon,MusteriAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti.Baglanti());
                cmd.Parameters.AddWithValue("@p1", m_txt_tc.Text);
                cmd.Parameters.AddWithValue("@p2", txt_ad.Text);
                cmd.Parameters.AddWithValue("@p3", txt_soyad.Text);
                if(radio_erkek.Checked)
                {
                    cmd.Parameters.AddWithValue("@p4", radio_erkek.Text);
                }
                else if (radio_kadın.Checked)
                {
                    cmd.Parameters.AddWithValue("@p4", radio_kadın.Text);
                }
                cmd.Parameters.AddWithValue("@p5", num_yas.Value.ToString());
                cmd.Parameters.AddWithValue("@p6", m_txt_telefon.Text);
                cmd.Parameters.AddWithValue("@p7", r_txt_adres.Text);

                cmd.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                MessageBox.Show("Müşteri Kaydı eklendi.");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Bir hata ile karşılaşıldı"); 
            }
        }

        private void MusteriKayitFormu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
