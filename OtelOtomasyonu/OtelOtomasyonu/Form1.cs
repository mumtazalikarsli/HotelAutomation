using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int selected;

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriKayitFormu musteriKayitFormu = new MusteriKayitFormu();
            musteriKayitFormu.Show();
        }

        private void hareketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriHareketFormu musteriHareketFormu = new MusteriHareketFormu();
            musteriHareketFormu.Show();
        }

        private void mesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesajlarDataGridForm mesajlarDataGridForm = new MesajlarDataGridForm();
            mesajlarDataGridForm.Show();
        }

        private void kayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaKayitDataGridForm odaKayitDataGridForm = new OdaKayitDataGridForm();
            odaKayitDataGridForm.Show();
        }

        private void durumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaDurumFormu odaDurumFormu = new OdaDurumFormu();
            odaDurumFormu.Show();
        }

        private void bosaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaBosaltForm odaBosaltForm = new OdaBosaltForm();
            odaBosaltForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgw_musteriler.SelectedCells[0].RowIndex;
            MusteriDüzenleSilForm duzenlesilform = new MusteriDüzenleSilForm();
            duzenlesilform.tc = dgw_musteriler.Rows[selected].Cells[0].Value.ToString();
            duzenlesilform.ad = dgw_musteriler.Rows[selected].Cells[1].Value.ToString();
            duzenlesilform.soyad = dgw_musteriler.Rows[selected].Cells[2].Value.ToString();
            duzenlesilform.yas = dgw_musteriler.Rows[selected].Cells[4].Value.ToString();
            duzenlesilform.telefon = dgw_musteriler.Rows[selected].Cells[5].Value.ToString();
            duzenlesilform.cinsiyet = dgw_musteriler.Rows[selected].Cells[3].Value.ToString();
            duzenlesilform.adres = dgw_musteriler.Rows[selected].Cells[6].Value.ToString();
            duzenlesilform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaGuncelleDataGridForm odaGuncelleDataGridForm = new OdaGuncelleDataGridForm();
            odaGuncelleDataGridForm.Show();
        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesajlarSelectDataGridForm mesajlarSelectDataGridForm = new MesajlarSelectDataGridForm();
            mesajlarSelectDataGridForm.Show();
        }
    }
}
