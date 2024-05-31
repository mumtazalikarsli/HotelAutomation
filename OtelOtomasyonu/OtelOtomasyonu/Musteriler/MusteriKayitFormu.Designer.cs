namespace OtelOtomasyonu
{
    partial class MusteriKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKayitFormu));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.m_txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.num_yas = new System.Windows.Forms.NumericUpDown();
            this.m_txt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.r_txt_adres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadın = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.num_yas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(281, 95);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(234, 27);
            this.txt_ad.TabIndex = 0;
            // 
            // m_txt_tc
            // 
            this.m_txt_tc.Location = new System.Drawing.Point(281, 35);
            this.m_txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_tc.Mask = "00000000000";
            this.m_txt_tc.Name = "m_txt_tc";
            this.m_txt_tc.Size = new System.Drawing.Size(234, 27);
            this.m_txt_tc.TabIndex = 1;
            this.m_txt_tc.ValidatingType = typeof(int);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(281, 154);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(234, 27);
            this.txt_soyad.TabIndex = 2;
            // 
            // num_yas
            // 
            this.num_yas.Location = new System.Drawing.Point(281, 214);
            this.num_yas.Name = "num_yas";
            this.num_yas.Size = new System.Drawing.Size(234, 27);
            this.num_yas.TabIndex = 3;
            // 
            // m_txt_telefon
            // 
            this.m_txt_telefon.Location = new System.Drawing.Point(281, 269);
            this.m_txt_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_telefon.Mask = "(999) 000-0000";
            this.m_txt_telefon.Name = "m_txt_telefon";
            this.m_txt_telefon.Size = new System.Drawing.Size(234, 27);
            this.m_txt_telefon.TabIndex = 4;
            // 
            // r_txt_adres
            // 
            this.r_txt_adres.Location = new System.Drawing.Point(281, 404);
            this.r_txt_adres.Name = "r_txt_adres";
            this.r_txt_adres.Size = new System.Drawing.Size(234, 169);
            this.r_txt_adres.TabIndex = 5;
            this.r_txt_adres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC Kimlik Numarasi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Numarasi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adresi:";
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(424, 603);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(91, 43);
            this.btn_kayit.TabIndex = 12;
            this.btn_kayit.Text = "Kayit";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cinsiyet:";
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(281, 336);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(41, 23);
            this.radio_erkek.TabIndex = 14;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "E";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadın
            // 
            this.radio_kadın.AutoSize = true;
            this.radio_kadın.Location = new System.Drawing.Point(441, 338);
            this.radio_kadın.Name = "radio_kadın";
            this.radio_kadın.Size = new System.Drawing.Size(42, 23);
            this.radio_kadın.TabIndex = 15;
            this.radio_kadın.TabStop = true;
            this.radio_kadın.Text = "K";
            this.radio_kadın.UseVisualStyleBackColor = true;
            // 
            // MusteriKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 668);
            this.Controls.Add(this.radio_kadın);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r_txt_adres);
            this.Controls.Add(this.m_txt_telefon);
            this.Controls.Add(this.num_yas);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.m_txt_tc);
            this.Controls.Add(this.txt_ad);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriKayitFormu";
            this.Text = "Musteri Kayit Formu";
            this.Load += new System.EventHandler(this.MusteriKayitFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_yas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox m_txt_tc;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.NumericUpDown num_yas;
        private System.Windows.Forms.MaskedTextBox m_txt_telefon;
        private System.Windows.Forms.RichTextBox r_txt_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadın;
    }
}