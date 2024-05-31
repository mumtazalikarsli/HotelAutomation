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
    public partial class MesajlarSelectDataGridForm : Form
    {
        public MesajlarSelectDataGridForm()
        {
            InitializeComponent();
        }

        private void MesajlarSelectDataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Mesajlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesajlarTableAdapter.Fill(this.otelDataSet.Mesajlar);

        }
    }
}
