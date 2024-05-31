namespace OtelOtomasyonu
{
    partial class OdaDurumFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaDurumFormu));
            this.dgw_odadurum = new System.Windows.Forms.DataGridView();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.odaDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.odaDurumTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.OdaDurumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_odadurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_odadurum
            // 
            this.dgw_odadurum.AllowUserToAddRows = false;
            this.dgw_odadurum.AllowUserToDeleteRows = false;
            this.dgw_odadurum.AllowUserToResizeColumns = false;
            this.dgw_odadurum.AllowUserToResizeRows = false;
            this.dgw_odadurum.AutoGenerateColumns = false;
            this.dgw_odadurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_odadurum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIDDataGridViewTextBoxColumn,
            this.odaDurumDataGridViewCheckBoxColumn});
            this.dgw_odadurum.DataSource = this.odaDurumBindingSource;
            this.dgw_odadurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_odadurum.Location = new System.Drawing.Point(0, 0);
            this.dgw_odadurum.Name = "dgw_odadurum";
            this.dgw_odadurum.ReadOnly = true;
            this.dgw_odadurum.RowHeadersWidth = 51;
            this.dgw_odadurum.RowTemplate.Height = 24;
            this.dgw_odadurum.Size = new System.Drawing.Size(303, 668);
            this.dgw_odadurum.TabIndex = 0;
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
            // odaDurumDataGridViewCheckBoxColumn
            // 
            this.odaDurumDataGridViewCheckBoxColumn.DataPropertyName = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.HeaderText = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odaDurumDataGridViewCheckBoxColumn.Name = "odaDurumDataGridViewCheckBoxColumn";
            this.odaDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            this.odaDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // odaDurumBindingSource
            // 
            this.odaDurumBindingSource.DataMember = "OdaDurum";
            this.odaDurumBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaDurumTableAdapter
            // 
            this.odaDurumTableAdapter.ClearBeforeFill = true;
            // 
            // OdaDurumFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(303, 668);
            this.Controls.Add(this.dgw_odadurum);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaDurumFormu";
            this.Text = "Oda Durum Formu";
            this.Load += new System.EventHandler(this.OdaDurumFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_odadurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_odadurum;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource odaDurumBindingSource;
        private OtelDataSetTableAdapters.OdaDurumTableAdapter odaDurumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odaDurumDataGridViewCheckBoxColumn;
    }
}