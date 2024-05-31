namespace OtelOtomasyonu
{
    partial class OdaKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaKayitFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_yemek = new System.Windows.Forms.CheckBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.m_txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.date_cikis = new System.Windows.Forms.DateTimePicker();
            this.date_giris = new System.Windows.Forms.DateTimePicker();
            this.cmb_oda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Oda Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Müsteri TC:";
            // 
            // check_yemek
            // 
            this.check_yemek.AutoSize = true;
            this.check_yemek.Location = new System.Drawing.Point(435, 399);
            this.check_yemek.Name = "check_yemek";
            this.check_yemek.Size = new System.Drawing.Size(124, 23);
            this.check_yemek.TabIndex = 13;
            this.check_yemek.Text = "Yemek Dahil";
            this.check_yemek.UseVisualStyleBackColor = true;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(468, 455);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(91, 43);
            this.btn_kayit.TabIndex = 14;
            this.btn_kayit.Text = "Kayit";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // m_txt_tc
            // 
            this.m_txt_tc.Enabled = false;
            this.m_txt_tc.Location = new System.Drawing.Point(325, 145);
            this.m_txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_tc.Mask = "00000000000";
            this.m_txt_tc.Name = "m_txt_tc";
            this.m_txt_tc.Size = new System.Drawing.Size(234, 27);
            this.m_txt_tc.TabIndex = 15;
            this.m_txt_tc.ValidatingType = typeof(int);
            // 
            // date_cikis
            // 
            this.date_cikis.Location = new System.Drawing.Point(325, 341);
            this.date_cikis.Name = "date_cikis";
            this.date_cikis.Size = new System.Drawing.Size(234, 27);
            this.date_cikis.TabIndex = 10;
            // 
            // date_giris
            // 
            this.date_giris.Location = new System.Drawing.Point(325, 272);
            this.date_giris.Name = "date_giris";
            this.date_giris.Size = new System.Drawing.Size(234, 27);
            this.date_giris.TabIndex = 7;
            // 
            // cmb_oda
            // 
            this.cmb_oda.FormattingEnabled = true;
            this.cmb_oda.Location = new System.Drawing.Point(325, 204);
            this.cmb_oda.Name = "cmb_oda";
            this.cmb_oda.Size = new System.Drawing.Size(234, 27);
            this.cmb_oda.TabIndex = 16;
            // 
            // OdaKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 668);
            this.Controls.Add(this.cmb_oda);
            this.Controls.Add(this.m_txt_tc);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.check_yemek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_giris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaKayitFormu";
            this.Text = "Oda Kayıt Formu";
            this.Load += new System.EventHandler(this.OdaKayitFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_yemek;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.MaskedTextBox m_txt_tc;
        private System.Windows.Forms.DateTimePicker date_cikis;
        private System.Windows.Forms.DateTimePicker date_giris;
        private System.Windows.Forms.ComboBox cmb_oda;
    }
}