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
    public partial class OdaGuncelleForm : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public string tc, oda, giris, cikis, yemek;

        private void OdaGuncelleForm_Load(object sender, EventArgs e)
        {
            m_txt_tc.Text = tc;
            cmb_oda.Text = oda;
            date_giris.Text = giris;
            date_cikis.Text = cikis;
            if(yemek == "True")
            {
                check_yemek.Checked = true;
            }
            else
            {
                check_yemek.Checked = false;
            }
            SqlCommand command = new SqlCommand("select OdaID from OdaDurum where OdaDurum != 1", baglanti.Baglanti());
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                cmb_oda.Items.Add(oku[0].ToString());
            }
            baglanti.Baglanti().Close();
        }

        public OdaGuncelleForm()
        {
            InitializeComponent();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_cikis.Value > date_giris.Value)
                {
                    DateTime startDate = date_giris.Value;
                    DateTime endDate = date_cikis.Value;

                    TimeSpan fark = endDate - startDate;


                    SqlCommand cmd = new SqlCommand("Update OdaDurum set OdaDurum = 0 where OdaID = @p1", baglanti.Baglanti());
                    cmd.Parameters.AddWithValue("@p1", oda);
                    cmd.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    SqlCommand cmd2 = new SqlCommand("Update OdaDurum set OdaDurum = 1 where OdaID = @p2", baglanti.Baglanti());
                    cmd2.Parameters.AddWithValue("@p2", cmb_oda.Text);
                    cmd2.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    SqlCommand cmd3 = new SqlCommand("Update Odalar set OdaID = @p3,OdaGirisTarihi = @p4, OdaCikisTarihi = @p5, OdaYemekDahil = @p6 where OdaID = @p7", baglanti.Baglanti());
                    cmd3.Parameters.AddWithValue("@p3", cmb_oda.Text);
                    cmd3.Parameters.AddWithValue("@p4", date_giris.Value.ToString("yyyy-MM-dd"));
                    cmd3.Parameters.AddWithValue("@p5", date_cikis.Value.ToString("yyyy-MM-dd"));
                    if (check_yemek.Checked)
                    {
                        cmd3.Parameters.AddWithValue("@p6", "True");
                    }
                    else
                    {
                        cmd3.Parameters.AddWithValue("@p6", "False");
                    }
                    cmd3.Parameters.AddWithValue("@p7", oda);
                    cmd3.ExecuteNonQuery();
                    baglanti.Baglanti().Close();


                    SqlCommand cmd4 = new SqlCommand("delete from MusteriHareket where OdaID = @p1", baglanti.Baglanti());
                    cmd4.Parameters.AddWithValue("@p1", oda);
                    cmd4.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    SqlCommand cmd5 = new SqlCommand("insert into MusteriHareket(MusteriTC,OdaID,GirisTarihi,CikisTarihi,ToplamTutar) values (@p1,@p2,@p3,@p4,@p5)", baglanti.Baglanti());
                    cmd5.Parameters.AddWithValue("@p1", m_txt_tc.Text);
                    cmd5.Parameters.AddWithValue("@p2", cmb_oda.Text);
                    cmd5.Parameters.AddWithValue("@p3", date_giris.Value.ToString("yyyy-MM-dd"));
                    cmd5.Parameters.AddWithValue("@p4", date_cikis.Value.ToString("yyyy-MM-dd"));
                    if (check_yemek.Checked)
                    {
                        cmd5.Parameters.AddWithValue("@p5", fark.Days * 1250);
                    }
                    else
                    {
                        cmd5.Parameters.AddWithValue("@p5", fark.Days * 1000);
                    }
                    cmd5.ExecuteNonQuery();
                    baglanti.Baglanti().Close();
                    MessageBox.Show("Oda kaydı başarıyla Güncellenmiştir");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Çıkış tarihiniz Giriş tarihinizden Erken olamaz");
                }
            }
            catch
            {
                MessageBox.Show("Hay aksi! bir hata ile karşılaştık.");
            }
        }
    }
}
