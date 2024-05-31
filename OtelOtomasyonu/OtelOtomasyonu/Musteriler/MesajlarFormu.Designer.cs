namespace OtelOtomasyonu
{
    partial class MesajlarFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajlarFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.r_txt_mesaj = new System.Windows.Forms.RichTextBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Musteri TC:";
            // 
            // m_txt_tc
            // 
            this.m_txt_tc.Enabled = false;
            this.m_txt_tc.Location = new System.Drawing.Point(308, 85);
            this.m_txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_tc.Mask = "00000000000";
            this.m_txt_tc.Name = "m_txt_tc";
            this.m_txt_tc.Size = new System.Drawing.Size(234, 27);
            this.m_txt_tc.TabIndex = 3;
            this.m_txt_tc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesaj:";
            // 
            // r_txt_mesaj
            // 
            this.r_txt_mesaj.Location = new System.Drawing.Point(308, 169);
            this.r_txt_mesaj.Name = "r_txt_mesaj";
            this.r_txt_mesaj.Size = new System.Drawing.Size(234, 356);
            this.r_txt_mesaj.TabIndex = 5;
            this.r_txt_mesaj.Text = "";
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(451, 561);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(91, 43);
            this.btn_Gonder.TabIndex = 13;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // MesajlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 668);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.r_txt_mesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_tc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MesajlarFormu";
            this.Text = "Mesajlar Formu";
            this.Load += new System.EventHandler(this.MesajlarFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox m_txt_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox r_txt_mesaj;
        private System.Windows.Forms.Button btn_Gonder;
    }
}