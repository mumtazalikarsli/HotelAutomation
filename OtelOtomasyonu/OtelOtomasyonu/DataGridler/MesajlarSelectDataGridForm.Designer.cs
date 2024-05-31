namespace OtelOtomasyonu
{
    partial class MesajlarSelectDataGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajlarSelectDataGridForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mesajIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new OtelOtomasyonu.OtelDataSet();
            this.mesajlarTableAdapter = new OtelOtomasyonu.OtelDataSetTableAdapters.MesajlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesajIDDataGridViewTextBoxColumn,
            this.musteriTCDataGridViewTextBoxColumn,
            this.mesajDataGridViewTextBoxColumn,
            this.mesajTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mesajlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 655);
            this.dataGridView1.TabIndex = 0;
            // 
            // mesajIDDataGridViewTextBoxColumn
            // 
            this.mesajIDDataGridViewTextBoxColumn.DataPropertyName = "MesajID";
            this.mesajIDDataGridViewTextBoxColumn.HeaderText = "MesajID";
            this.mesajIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajIDDataGridViewTextBoxColumn.Name = "mesajIDDataGridViewTextBoxColumn";
            this.mesajIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesajIDDataGridViewTextBoxColumn.Width = 125;
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
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            this.mesajDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesajDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajTarihDataGridViewTextBoxColumn
            // 
            this.mesajTarihDataGridViewTextBoxColumn.DataPropertyName = "MesajTarih";
            this.mesajTarihDataGridViewTextBoxColumn.HeaderText = "MesajTarih";
            this.mesajTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajTarihDataGridViewTextBoxColumn.Name = "mesajTarihDataGridViewTextBoxColumn";
            this.mesajTarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesajTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajlarBindingSource
            // 
            this.mesajlarBindingSource.DataMember = "Mesajlar";
            this.mesajlarBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "OtelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajlarTableAdapter
            // 
            this.mesajlarTableAdapter.ClearBeforeFill = true;
            // 
            // MesajlarSelectDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 655);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MesajlarSelectDataGridForm";
            this.Text = "Mesajlar SelectDataGridForm";
            this.Load += new System.EventHandler(this.MesajlarSelectDataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource mesajlarBindingSource;
        private OtelDataSetTableAdapters.MesajlarTableAdapter mesajlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajTarihDataGridViewTextBoxColumn;
    }
}