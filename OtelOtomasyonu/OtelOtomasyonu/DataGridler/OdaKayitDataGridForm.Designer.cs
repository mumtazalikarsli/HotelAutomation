namespace OtelOtomasyonu
{
    partial class OdaKayitDataGridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaKayitDataGridForm));
            this.dgw_musteriler = new System.Windows.Forms.DataGridView();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.musterilerTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.MusterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_musteriler
            // 
            this.dgw_musteriler.AllowUserToAddRows = false;
            this.dgw_musteriler.AllowUserToDeleteRows = false;
            this.dgw_musteriler.AutoGenerateColumns = false;
            this.dgw_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_musteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriTCDataGridViewTextBoxColumn,
            this.musteriAdiDataGridViewTextBoxColumn,
            this.musteriSoyadiDataGridViewTextBoxColumn,
            this.musteriCinsiyetDataGridViewTextBoxColumn,
            this.musteriYasDataGridViewTextBoxColumn,
            this.musteriTelefonDataGridViewTextBoxColumn,
            this.musteriAdresDataGridViewTextBoxColumn});
            this.dgw_musteriler.DataSource = this.musterilerBindingSource;
            this.dgw_musteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_musteriler.Location = new System.Drawing.Point(0, 0);
            this.dgw_musteriler.Name = "dgw_musteriler";
            this.dgw_musteriler.ReadOnly = true;
            this.dgw_musteriler.RowHeadersWidth = 51;
            this.dgw_musteriler.RowTemplate.Height = 24;
            this.dgw_musteriler.Size = new System.Drawing.Size(930, 668);
            this.dgw_musteriler.TabIndex = 0;
            this.dgw_musteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_musteriler_CellClick);
            // 
            // musteriTCDataGridViewTextBoxColumn
            // 
            this.musteriTCDataGridViewTextBoxColumn.DataPropertyName = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.HeaderText = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTCDataGridViewTextBoxColumn.Name = "musteriTCDataGridViewTextBoxColumn";
            this.musteriTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            this.musteriAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSoyadiDataGridViewTextBoxColumn
            // 
            this.musteriSoyadiDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.HeaderText = "MusteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSoyadiDataGridViewTextBoxColumn.Name = "musteriSoyadiDataGridViewTextBoxColumn";
            this.musteriSoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriSoyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriCinsiyetDataGridViewTextBoxColumn
            // 
            this.musteriCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "MusteriCinsiyet";
            this.musteriCinsiyetDataGridViewTextBoxColumn.HeaderText = "MusteriCinsiyet";
            this.musteriCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriCinsiyetDataGridViewTextBoxColumn.Name = "musteriCinsiyetDataGridViewTextBoxColumn";
            this.musteriCinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriCinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriYasDataGridViewTextBoxColumn
            // 
            this.musteriYasDataGridViewTextBoxColumn.DataPropertyName = "MusteriYas";
            this.musteriYasDataGridViewTextBoxColumn.HeaderText = "MusteriYas";
            this.musteriYasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriYasDataGridViewTextBoxColumn.Name = "musteriYasDataGridViewTextBoxColumn";
            this.musteriYasDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriYasDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            this.musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.HeaderText = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            this.musteriTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdresDataGridViewTextBoxColumn
            // 
            this.musteriAdresDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.HeaderText = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdresDataGridViewTextBoxColumn.Name = "musteriAdresDataGridViewTextBoxColumn";
            this.musteriAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // OdaKayitDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 668);
            this.Controls.Add(this.dgw_musteriler);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaKayitDataGridForm";
            this.Text = "Oda Kayıt DataGridForm";
            this.Load += new System.EventHandler(this.OdaKayitDataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_musteriler;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private OtelDataSetTableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdresDataGridViewTextBoxColumn;
    }
}