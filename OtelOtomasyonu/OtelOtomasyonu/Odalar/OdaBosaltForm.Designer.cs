namespace OtelOtomasyonu
{
    partial class OdaBosaltForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaBosaltForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_odeme = new System.Windows.Forms.ComboBox();
            this.btn_bosalt = new System.Windows.Forms.Button();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_musteritc = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.cmb_odanum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oda Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödeme Yöntemi:";
            // 
            // cmb_odeme
            // 
            this.cmb_odeme.FormattingEnabled = true;
            this.cmb_odeme.Location = new System.Drawing.Point(317, 365);
            this.cmb_odeme.Name = "cmb_odeme";
            this.cmb_odeme.Size = new System.Drawing.Size(234, 27);
            this.cmb_odeme.TabIndex = 10;
            // 
            // btn_bosalt
            // 
            this.btn_bosalt.Location = new System.Drawing.Point(460, 446);
            this.btn_bosalt.Name = "btn_bosalt";
            this.btn_bosalt.Size = new System.Drawing.Size(91, 61);
            this.btn_bosalt.TabIndex = 13;
            this.btn_bosalt.Text = "Odayı Boşalt";
            this.btn_bosalt.UseVisualStyleBackColor = true;
            this.btn_bosalt.Click += new System.EventHandler(this.btn_bosalt_Click);
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(460, 181);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(91, 43);
            this.btn_kontrol.TabIndex = 14;
            this.btn_kontrol.Text = "Kontrol";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Toplam Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Müşteri TC:";
            // 
            // lbl_musteritc
            // 
            this.lbl_musteritc.AutoSize = true;
            this.lbl_musteritc.Location = new System.Drawing.Point(313, 263);
            this.lbl_musteritc.Name = "lbl_musteritc";
            this.lbl_musteritc.Size = new System.Drawing.Size(18, 19);
            this.lbl_musteritc.TabIndex = 17;
            this.lbl_musteritc.Text = "*";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(313, 304);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(18, 19);
            this.lbl_tutar.TabIndex = 18;
            this.lbl_tutar.Text = "*";
            // 
            // cmb_odanum
            // 
            this.cmb_odanum.FormattingEnabled = true;
            this.cmb_odanum.Location = new System.Drawing.Point(317, 133);
            this.cmb_odanum.Name = "cmb_odanum";
            this.cmb_odanum.Size = new System.Drawing.Size(234, 27);
            this.cmb_odanum.TabIndex = 21;
            // 
            // OdaBosaltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 668);
            this.Controls.Add(this.cmb_odanum);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.lbl_musteritc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.btn_bosalt);
            this.Controls.Add(this.cmb_odeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaBosaltForm";
            this.Text = "Oda Boşalt Form";
            this.Load += new System.EventHandler(this.OdaBosaltForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_odeme;
        private System.Windows.Forms.Button btn_bosalt;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_musteritc;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.ComboBox cmb_odanum;
    }
}