namespace OtelOtomasyonu
{
    partial class MusteriHareketFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriHareketFormu));
            this.dgw_musteri_hareket = new System.Windows.Forms.DataGridView();
            this.hareketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.musteriHareketTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.MusteriHareketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteri_hareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_musteri_hareket
            // 
            this.dgw_musteri_hareket.AllowUserToAddRows = false;
            this.dgw_musteri_hareket.AllowUserToDeleteRows = false;
            this.dgw_musteri_hareket.AutoGenerateColumns = false;
            this.dgw_musteri_hareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_musteri_hareket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketIDDataGridViewTextBoxColumn,
            this.musteriTCDataGridViewTextBoxColumn,
            this.odaIDDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn});
            this.dgw_musteri_hareket.DataSource = this.musteriHareketBindingSource;
            this.dgw_musteri_hareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_musteri_hareket.Location = new System.Drawing.Point(0, 0);
            this.dgw_musteri_hareket.Name = "dgw_musteri_hareket";
            this.dgw_musteri_hareket.ReadOnly = true;
            this.dgw_musteri_hareket.RowHeadersWidth = 51;
            this.dgw_musteri_hareket.RowTemplate.Height = 24;
            this.dgw_musteri_hareket.Size = new System.Drawing.Size(805, 668);
            this.dgw_musteri_hareket.TabIndex = 0;
            // 
            // hareketIDDataGridViewTextBoxColumn
            // 
            this.hareketIDDataGridViewTextBoxColumn.DataPropertyName = "HareketID";
            this.hareketIDDataGridViewTextBoxColumn.HeaderText = "HareketID";
            this.hareketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hareketIDDataGridViewTextBoxColumn.Name = "hareketIDDataGridViewTextBoxColumn";
            this.hareketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketIDDataGridViewTextBoxColumn.Width = 125;
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
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            this.odaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            this.girisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.girisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            this.cikisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.ReadOnly = true;
            this.toplamTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriHareketBindingSource
            // 
            this.musteriHareketBindingSource.DataMember = "MusteriHareket";
            this.musteriHareketBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriHareketTableAdapter
            // 
            this.musteriHareketTableAdapter.ClearBeforeFill = true;
            // 
            // MusteriHareketFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(805, 668);
            this.Controls.Add(this.dgw_musteri_hareket);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriHareketFormu";
            this.Text = "Müşteri Hareket Formu";
            this.Load += new System.EventHandler(this.MusteriHareketFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteri_hareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_musteri_hareket;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource musteriHareketBindingSource;
        private OtelDataSetTableAdapters.MusteriHareketTableAdapter musteriHareketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
    }
}