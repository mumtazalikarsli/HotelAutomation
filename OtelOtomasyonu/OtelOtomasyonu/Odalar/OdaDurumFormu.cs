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
    public partial class OdaDurumFormu : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public OdaDurumFormu()
        {
            InitializeComponent();
        }

        private void OdaDurumFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.OdaDurum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odaDurumTableAdapter.Fill(this.otelDataSet.OdaDurum);
        }
    }
}
