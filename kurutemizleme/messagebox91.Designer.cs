namespace kurutemizleme
{
    partial class messagebox91
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messagebox91));
            this.panel1 = new System.Windows.Forms.Panel();
            this.baslikuyari = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.uyarı = new System.Windows.Forms.Label();
            this.mesajIconu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajIconu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.baslikuyari);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 36);
            this.panel1.TabIndex = 15;
            // 
            // baslikuyari
            // 
            this.baslikuyari.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikuyari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslikuyari.Location = new System.Drawing.Point(105, 0);
            this.baslikuyari.Name = "baslikuyari";
            this.baslikuyari.Size = new System.Drawing.Size(159, 36);
            this.baslikuyari.TabIndex = 0;
            this.baslikuyari.Text = "Onay";
            this.baslikuyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(167, 109);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 31);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // uyarı
            // 
            this.uyarı.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyarı.Location = new System.Drawing.Point(56, 56);
            this.uyarı.Name = "uyarı";
            this.uyarı.Size = new System.Drawing.Size(304, 50);
            this.uyarı.TabIndex = 12;
            this.uyarı.Text = "İşlem Başarılı!";
            this.uyarı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mesajIconu
            // 
            this.mesajIconu.Image = ((System.Drawing.Image)(resources.GetObject("mesajIconu.Image")));
            this.mesajIconu.Location = new System.Drawing.Point(28, 56);
            this.mesajIconu.Name = "mesajIconu";
            this.mesajIconu.Size = new System.Drawing.Size(71, 69);
            this.mesajIconu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesajIconu.TabIndex = 14;
            this.mesajIconu.TabStop = false;
            // 
            // messagebox91
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 165);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.mesajIconu);
            this.Controls.Add(this.uyarı);
            this.Location = new System.Drawing.Point(665, 415);
            this.Name = "messagebox91";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Onay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mesajIconu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label baslikuyari;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox mesajIconu;
        private System.Windows.Forms.Label uyarı;
    }
}