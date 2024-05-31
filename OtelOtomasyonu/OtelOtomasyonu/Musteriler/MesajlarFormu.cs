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
    public partial class MesajlarFormu : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public MesajlarFormu()
        {
            InitializeComponent();
        }
        public string tc;

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Mesajlar(MusteriTC,Mesaj,MesajTarih) values (@p2,@p3,@p4)", baglanti.Baglanti());
                cmd.Parameters.AddWithValue("@p2", m_txt_tc.Text);
                cmd.Parameters.AddWithValue("@p3", r_txt_mesaj.Text);
                DateTime value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                cmd.Parameters.AddWithValue("@p4", value);

                cmd.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                MessageBox.Show("Müşteri Mesaj Kaydı eklendi.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Bir hata ile karşılaşıldı");
            }
        }

        private void MesajlarFormu_Load(object sender, EventArgs e)
        {
            m_txt_tc.Text = tc;
        }
    }
}
