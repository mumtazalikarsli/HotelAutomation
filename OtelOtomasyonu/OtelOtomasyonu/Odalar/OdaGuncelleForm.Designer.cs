namespace OtelOtomasyonu
{
    partial class OdaGuncelleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaGuncelleForm));
            this.cmb_oda = new System.Windows.Forms.ComboBox();
            this.m_txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.check_yemek = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_cikis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_giris = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_oda
            // 
            this.cmb_oda.FormattingEnabled = true;
            this.cmb_oda.Location = new System.Drawing.Point(318, 212);
            this.cmb_oda.Name = "cmb_oda";
            this.cmb_oda.Size = new System.Drawing.Size(234, 27);
            this.cmb_oda.TabIndex = 26;
            // 
            // m_txt_tc
            // 
            this.m_txt_tc.Enabled = false;
            this.m_txt_tc.Location = new System.Drawing.Point(318, 150);
            this.m_txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_tc.Mask = "00000000000";
            this.m_txt_tc.Name = "m_txt_tc";
            this.m_txt_tc.Size = new System.Drawing.Size(234, 27);
            this.m_txt_tc.TabIndex = 25;
            this.m_txt_tc.ValidatingType = typeof(int);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(461, 463);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(91, 43);
            this.btn_guncelle.TabIndex = 24;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // check_yemek
            // 
            this.check_yemek.AutoSize = true;
            this.check_yemek.Location = new System.Drawing.Point(428, 407);
            this.check_yemek.Name = "check_yemek";
            this.check_yemek.Size = new System.Drawing.Size(124, 23);
            this.check_yemek.TabIndex = 23;
            this.check_yemek.Text = "Yemek Dahil";
            this.check_yemek.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Müsteri TC:";
            // 
            // date_cikis
            // 
            this.date_cikis.Location = new System.Drawing.Point(318, 349);
            this.date_cikis.Name = "date_cikis";
            this.date_cikis.Size = new System.Drawing.Size(234, 27);
            this.date_cikis.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Oda Çıkış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Oda Giriş Tarihi:";
            // 
            // date_giris
            // 
            this.date_giris.Location = new System.Drawing.Point(318, 280);
            this.date_giris.Name = "date_giris";
            this.date_giris.Size = new System.Drawing.Size(234, 27);
            this.date_giris.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Oda Numarası:";
            // 
            // OdaGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 668);
            this.Controls.Add(this.cmb_oda);
            this.Controls.Add(this.m_txt_tc);
            this.Controls.Add(this.btn_guncelle);
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
            this.Name = "OdaGuncelleForm";
            this.Text = "Oda Güncelle Formu";
            this.Load += new System.EventHandler(this.OdaGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_oda;
        private System.Windows.Forms.MaskedTextBox m_txt_tc;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.CheckBox check_yemek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_cikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_giris;
        private System.Windows.Forms.Label label1;
    }
}