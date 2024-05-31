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
    public partial class MusteriHareketFormu : Form
    {
        public MusteriHareketFormu()
        {
            InitializeComponent();
        }

        private void MusteriHareketFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.MusteriHareket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriHareketTableAdapter.Fill(this.otelDataSet.MusteriHareket);

        }
    }
}
