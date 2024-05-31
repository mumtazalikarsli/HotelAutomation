namespace OtelOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hareketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bosaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.odalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.hareketToolStripMenuItem,
            this.mesajlarToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            this.kayıtToolStripMenuItem.Click += new System.EventHandler(this.kayıtToolStripMenuItem_Click);
            // 
            // hareketToolStripMenuItem
            // 
            this.hareketToolStripMenuItem.Name = "hareketToolStripMenuItem";
            this.hareketToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hareketToolStripMenuItem.Text = "Hareket";
            this.hareketToolStripMenuItem.Click += new System.EventHandler(this.hareketToolStripMenuItem_Click);
            // 
            // mesajlarToolStripMenuItem
            // 
            this.mesajlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listelemeToolStripMenuItem});
            this.mesajlarToolStripMenuItem.Name = "mesajlarToolStripMenuItem";
            this.mesajlarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mesajlarToolStripMenuItem.Text = "Mesajlar";
            this.mesajlarToolStripMenuItem.Click += new System.EventHandler(this.mesajlarToolStripMenuItem_Click);
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayitToolStripMenuItem,
            this.durumToolStripMenuItem,
            this.bosaltToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.odalarToolStripMenuItem.Text = "Odalar";
            // 
            // kayitToolStripMenuItem
            // 
            this.kayitToolStripMenuItem.Name = "kayitToolStripMenuItem";
            this.kayitToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.kayitToolStripMenuItem.Text = "Kayit";
            this.kayitToolStripMenuItem.Click += new System.EventHandler(this.kayitToolStripMenuItem_Click);
            // 
            // durumToolStripMenuItem
            // 
            this.durumToolStripMenuItem.Name = "durumToolStripMenuItem";
            this.durumToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.durumToolStripMenuItem.Text = "Durum";
            this.durumToolStripMenuItem.Click += new System.EventHandler(this.durumToolStripMenuItem_Click);
            // 
            // bosaltToolStripMenuItem
            // 
            this.bosaltToolStripMenuItem.Name = "bosaltToolStripMenuItem";
            this.bosaltToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.bosaltToolStripMenuItem.Text = "Bosalt";
            this.bosaltToolStripMenuItem.Click += new System.EventHandler(this.bosaltToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
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
            this.dgw_musteriler.Location = new System.Drawing.Point(0, 30);
            this.dgw_musteriler.Name = "dgw_musteriler";
            this.dgw_musteriler.ReadOnly = true;
            this.dgw_musteriler.RowHeadersWidth = 51;
            this.dgw_musteriler.RowTemplate.Height = 24;
            this.dgw_musteriler.Size = new System.Drawing.Size(928, 638);
            this.dgw_musteriler.TabIndex = 1;
            this.dgw_musteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            this.listelemeToolStripMenuItem.Click += new System.EventHandler(this.listelemeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 668);
            this.Controls.Add(this.dgw_musteriler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hareketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bosaltToolStripMenuItem;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
    }
}

