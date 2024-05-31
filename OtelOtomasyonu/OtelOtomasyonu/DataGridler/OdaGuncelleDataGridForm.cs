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
    public partial class OdaGuncelleDataGridForm : Form
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        public int selected;
        public OdaGuncelleDataGridForm()
        {
            InitializeComponent();
        }

        private void OdaGuncelleDataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odalarTableAdapter.Fill(this.otelDataSet.Odalar);

        }

        private void dgv_odalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgv_odalar.SelectedCells[0].RowIndex;
            OdaGuncelleForm odaguncelleform = new OdaGuncelleForm();
            odaguncelleform.oda = dgv_odalar.Rows[selected].Cells[0].Value.ToString();
            odaguncelleform.giris = dgv_odalar.Rows[selected].Cells[1].Value.ToString();
            odaguncelleform.cikis = dgv_odalar.Rows[selected].Cells[2].Value.ToString();
            odaguncelleform.yemek = dgv_odalar.Rows[selected].Cells[3].Value.ToString();
            odaguncelleform.tc = dgv_odalar.Rows[selected].Cells[4].Value.ToString();
            odaguncelleform.Show();
            this.Close();

        }
    }
}
