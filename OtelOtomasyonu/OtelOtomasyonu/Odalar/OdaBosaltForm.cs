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
    public partial class OdaBosaltForm : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public OdaBosaltForm()
        {
            InitializeComponent();
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_odanum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen oda seçiniz");
                }
                else
                {
                    string musteriTC = "";
                    string toplamTutar = "";

                    using (SqlCommand cmd = new SqlCommand("SELECT MusteriTC FROM MusteriHareket WHERE OdaID = @p1", baglanti.Baglanti()))
                    {
                        cmd.Parameters.AddWithValue("@p1", cmb_odanum.Text);
                        musteriTC = cmd.ExecuteScalar()?.ToString();
                    }

                    using (SqlCommand cmd2 = new SqlCommand("SELECT ToplamTutar FROM MusteriHareket WHERE OdaID = @p2", baglanti.Baglanti()))
                    {
                        cmd2.Parameters.AddWithValue("@p2", cmb_odanum.Text);
                        toplamTutar = cmd2.ExecuteScalar()?.ToString();
                    }

                    lbl_musteritc.Text = musteriTC;
                    lbl_tutar.Text = toplamTutar;

                    baglanti.Baglanti().Close();

                    MessageBox.Show("Kontrol işlemi başarılı");
                    cmb_odeme.Items.Add("Kart");
                    cmb_odeme.Items.Add("Nakit");

                }
            }
            catch
            {
                MessageBox.Show("Kontrol işlemi hatası");
            }
        }
        private void OdaBosaltForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select OdaID from OdaDurum where OdaDurum = 1", baglanti.Baglanti());
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {
                    cmb_odanum.Items.Add(oku[0].ToString());
                }
                baglanti.Baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Odalar çekilemedi");
            }
        }
        private void btn_bosalt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_odeme.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen ödeme yönetimini seçiniz");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Odalar WHERE OdaID = @p1", baglanti.Baglanti());
                    cmd.Parameters.AddWithValue("@p1", cmb_odanum.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    SqlCommand cmd2 = new SqlCommand("UPDATE OdaDurum set OdaDurum = 0 where OdaID = @p2", baglanti.Baglanti());
                    cmd2.Parameters.AddWithValue("@p2", cmb_odanum.Text);
                    cmd2.ExecuteNonQuery();
                    baglanti.Baglanti().Close();

                    MessageBox.Show("Oda Boşaltıldı. Ödeme yönteminiz = "+cmb_odeme.Text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Oda boşaltma işleminde hata oluştu.");
            }
        }
    }
}
