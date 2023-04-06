namespace kurutemizleme
{
    partial class AYıkama2
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
            this.label1 = new System.Windows.Forms.Label();
            this.secimTC2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimAdSoyad2 = new System.Windows.Forms.TextBox();
            this.alınmaTarihi2 = new System.Windows.Forms.DateTimePicker();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alınanMakine2 = new System.Windows.Forms.ComboBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A2dataGridView = new System.Windows.Forms.DataGridView();
            this.islemButonu2 = new kurutemizleme.Resources.yuvarlakbuton();
            this.alınanSaat2 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A2dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // secimTC2
            // 
            this.secimTC2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC2.Location = new System.Drawing.Point(166, 26);
            this.secimTC2.Name = "secimTC2";
            this.secimTC2.Size = new System.Drawing.Size(205, 26);
            this.secimTC2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimAdSoyad2
            // 
            this.secimAdSoyad2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad2.Location = new System.Drawing.Point(166, 63);
            this.secimAdSoyad2.Name = "secimAdSoyad2";
            this.secimAdSoyad2.ReadOnly = true;
            this.secimAdSoyad2.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad2.TabIndex = 42;
            // 
            // alınmaTarihi2
            // 
            this.alınmaTarihi2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi2.Location = new System.Drawing.Point(407, 28);
            this.alınmaTarihi2.Name = "alınmaTarihi2";
            this.alınmaTarihi2.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi2.TabIndex = 43;
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(12, 108);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 44;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(12, 274);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 45;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Makine Seç  :";
            // 
            // alınanMakine2
            // 
            this.alınanMakine2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine2.FormattingEnabled = true;
            this.alınanMakine2.Location = new System.Drawing.Point(218, 176);
            this.alınanMakine2.Name = "alınanMakine2";
            this.alınanMakine2.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine2.TabIndex = 47;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A2dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 120);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 48;
            // 
            // A2dataGridView
            // 
            this.A2dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A2dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A2dataGridView.Name = "A2dataGridView";
            this.A2dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A2dataGridView.TabIndex = 0;
            // 
            // islemButonu2
            // 
            this.islemButonu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu2.FlatAppearance.BorderSize = 0;
            this.islemButonu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu2.ForeColor = System.Drawing.Color.White;
            this.islemButonu2.Location = new System.Drawing.Point(247, 236);
            this.islemButonu2.Name = "islemButonu2";
            this.islemButonu2.Size = new System.Drawing.Size(137, 50);
            this.islemButonu2.TabIndex = 49;
            this.islemButonu2.Text = "İşlemi Bitir";
            this.islemButonu2.UseVisualStyleBackColor = false;
            this.islemButonu2.Click += new System.EventHandler(this.islemButonu2_Click);
            // 
            // alınanSaat2
            // 
            this.alınanSaat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat2.Location = new System.Drawing.Point(487, 73);
            this.alınanSaat2.Name = "alınanSaat2";
            this.alınanSaat2.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat2.TabIndex = 50;
            this.alınanSaat2.Text = "9 : 20";
            // 
            // AYıkama2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat2);
            this.Controls.Add(this.islemButonu2);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi2);
            this.Controls.Add(this.secimAdSoyad2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama2";
            this.Load += new System.EventHandler(this.AYıkama2_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A2dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secimTC2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimAdSoyad2;
        private System.Windows.Forms.DateTimePicker alınmaTarihi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox alınanMakine2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A2dataGridView;
        private Resources.yuvarlakbuton islemButonu2;
        private System.Windows.Forms.Label alınanSaat2;
    }
}