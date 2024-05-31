using Microsoft.Win32;
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
    public partial class MesajlarDataGridForm : Form
    {
        public int selected;
        public MesajlarDataGridForm()
        {
            InitializeComponent();
        }

        private void MesajlarDataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelDataSet.Musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);

        }

        private void dgw_Musteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgw_musteriler.SelectedCells[0].RowIndex;
            MesajlarFormu msjform = new MesajlarFormu();
            msjform.tc = dgw_musteriler.Rows[selected].Cells[0].Value.ToString();
            msjform.Show();
            this.Close();
        }
    }
}
