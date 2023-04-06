namespace kurutemizleme
{
    partial class AYıkama91
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
            this.alınanSaat11 = new System.Windows.Forms.Label();
            this.islemButonu11 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A11dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine11 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi11 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A11dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat11
            // 
            this.alınanSaat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat11.Location = new System.Drawing.Point(487, 69);
            this.alınanSaat11.Name = "alınanSaat11";
            this.alınanSaat11.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat11.TabIndex = 62;
            this.alınanSaat11.Text = "17 : 00";
            // 
            // islemButonu11
            // 
            this.islemButonu11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu11.FlatAppearance.BorderSize = 0;
            this.islemButonu11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu11.ForeColor = System.Drawing.Color.White;
            this.islemButonu11.Location = new System.Drawing.Point(247, 232);
            this.islemButonu11.Name = "islemButonu11";
            this.islemButonu11.Size = new System.Drawing.Size(137, 50);
            this.islemButonu11.TabIndex = 61;
            this.islemButonu11.Text = "İşlemi Bitir";
            this.islemButonu11.UseVisualStyleBackColor = false;
            this.islemButonu11.Click += new System.EventHandler(this.islemButonu11_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A11dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 116);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A11dataGridView
            // 
            this.A11dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A11dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A11dataGridView.Name = "A11dataGridView";
            this.A11dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A11dataGridView.TabIndex = 0;
            // 
            // alınanMakine11
            // 
            this.alınanMakine11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine11.FormattingEnabled = true;
            this.alınanMakine11.Location = new System.Drawing.Point(218, 172);
            this.alınanMakine11.Name = "alınanMakine11";
            this.alınanMakine11.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine11.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(12, 270);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(12, 104);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi11
            // 
            this.alınmaTarihi11.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi11.Location = new System.Drawing.Point(407, 24);
            this.alınmaTarihi11.Name = "alınmaTarihi11";
            this.alınmaTarihi11.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi11.TabIndex = 55;
            // 
            // secimAdSoyad11
            // 
            this.secimAdSoyad11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad11.Location = new System.Drawing.Point(166, 59);
            this.secimAdSoyad11.Name = "secimAdSoyad11";
            this.secimAdSoyad11.ReadOnly = true;
            this.secimAdSoyad11.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad11.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC11
            // 
            this.secimTC11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC11.Location = new System.Drawing.Point(166, 22);
            this.secimTC11.Name = "secimTC11";
            this.secimTC11.Size = new System.Drawing.Size(205, 26);
            this.secimTC11.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama91
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat11);
            this.Controls.Add(this.islemButonu11);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi11);
            this.Controls.Add(this.secimAdSoyad11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama91";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama10";
            this.Load += new System.EventHandler(this.AYıkama91_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A11dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat11;
        private Resources.yuvarlakbuton islemButonu11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A11dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi11;
        private System.Windows.Forms.TextBox secimAdSoyad11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC11;
        private System.Windows.Forms.Label label1;
    }
}