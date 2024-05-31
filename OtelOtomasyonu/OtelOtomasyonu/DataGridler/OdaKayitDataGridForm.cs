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
    public partial class OdaKayitDataGridForm : Form
    {
        public int selected;
        public OdaKayitDataGridForm()
        {
            InitializeComponent();
        }

        private void OdaKayitDataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);

        }

        private void dgw_musteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgw_musteriler.SelectedCells[0].RowIndex;
            OdaKayitFormu odaKayitFormu = new OdaKayitFormu();
            odaKayitFormu.tc = dgw_musteriler.Rows[selected].Cells[0].Value.ToString();
            odaKayitFormu.Show();
            this.Close();
        }
    }
}