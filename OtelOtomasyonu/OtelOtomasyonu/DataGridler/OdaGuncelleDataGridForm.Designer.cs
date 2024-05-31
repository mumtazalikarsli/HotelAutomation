namespace OtelOtomasyonu
{
    partial class OdaGuncelleDataGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaGuncelleDataGridForm));
            this.dgv_odalar = new System.Windows.Forms.DataGridView();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaGirisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaCikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaYemekDahilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.odalarTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.OdalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_odalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_odalar
            // 
            this.dgv_odalar.AllowUserToAddRows = false;
            this.dgv_odalar.AllowUserToDeleteRows = false;
            this.dgv_odalar.AutoGenerateColumns = false;
            this.dgv_odalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_odalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIDDataGridViewTextBoxColumn,
            this.odaGirisTarihiDataGridViewTextBoxColumn,
            this.odaCikisTarihiDataGridViewTextBoxColumn,
            this.odaYemekDahilDataGridViewCheckBoxColumn,
            this.musteriTCDataGridViewTextBoxColumn});
            this.dgv_odalar.DataSource = this.odalarBindingSource;
            this.dgv_odalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_odalar.Location = new System.Drawing.Point(0, 0);
            this.dgv_odalar.Name = "dgv_odalar";
            this.dgv_odalar.ReadOnly = true;
            this.dgv_odalar.RowHeadersWidth = 51;
            this.dgv_odalar.RowTemplate.Height = 24;
            this.dgv_odalar.Size = new System.Drawing.Size(678, 668);
            this.dgv_odalar.TabIndex = 0;
            this.dgv_odalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_odalar_CellClick);
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
            // odaGirisTarihiDataGridViewTextBoxColumn
            // 
            this.odaGirisTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdaGirisTarihi";
            this.odaGirisTarihiDataGridViewTextBoxColumn.HeaderText = "OdaGirisTarihi";
            this.odaGirisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaGirisTarihiDataGridViewTextBoxColumn.Name = "odaGirisTarihiDataGridViewTextBoxColumn";
            this.odaGirisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaGirisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaCikisTarihiDataGridViewTextBoxColumn
            // 
            this.odaCikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdaCikisTarihi";
            this.odaCikisTarihiDataGridViewTextBoxColumn.HeaderText = "OdaCikisTarihi";
            this.odaCikisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaCikisTarihiDataGridViewTextBoxColumn.Name = "odaCikisTarihiDataGridViewTextBoxColumn";
            this.odaCikisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaCikisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaYemekDahilDataGridViewCheckBoxColumn
            // 
            this.odaYemekDahilDataGridViewCheckBoxColumn.DataPropertyName = "OdaYemekDahil";
            this.odaYemekDahilDataGridViewCheckBoxColumn.HeaderText = "OdaYemekDahil";
            this.odaYemekDahilDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odaYemekDahilDataGridViewCheckBoxColumn.Name = "odaYemekDahilDataGridViewCheckBoxColumn";
            this.odaYemekDahilDataGridViewCheckBoxColumn.ReadOnly = true;
            this.odaYemekDahilDataGridViewCheckBoxColumn.Width = 125;
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
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // OdaGuncelleDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 668);
            this.Controls.Add(this.dgv_odalar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaGuncelleDataGridForm";
            this.Text = "Oda Güncelle DataGridForm";
            this.Load += new System.EventHandler(this.OdaGuncelleDataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_odalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_odalar;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OtelDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaGirisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaCikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odaYemekDahilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
    }
}