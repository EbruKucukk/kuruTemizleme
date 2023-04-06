namespace kurutemizleme
{
    partial class AYıkama5
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
            this.alınanSaat5 = new System.Windows.Forms.Label();
            this.islemButonu5 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A5dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi5 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A5dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat5
            // 
            this.alınanSaat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat5.Location = new System.Drawing.Point(487, 73);
            this.alınanSaat5.Name = "alınanSaat5";
            this.alınanSaat5.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat5.TabIndex = 62;
            this.alınanSaat5.Text = "11 : 50";
            // 
            // islemButonu5
            // 
            this.islemButonu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu5.FlatAppearance.BorderSize = 0;
            this.islemButonu5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu5.ForeColor = System.Drawing.Color.White;
            this.islemButonu5.Location = new System.Drawing.Point(247, 236);
            this.islemButonu5.Name = "islemButonu5";
            this.islemButonu5.Size = new System.Drawing.Size(137, 50);
            this.islemButonu5.TabIndex = 61;
            this.islemButonu5.Text = "İşlemi Bitir";
            this.islemButonu5.UseVisualStyleBackColor = false;
            this.islemButonu5.Click += new System.EventHandler(this.islemButonu5_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A5dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 120);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A5dataGridView
            // 
            this.A5dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A5dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A5dataGridView.Name = "A5dataGridView";
            this.A5dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A5dataGridView.TabIndex = 0;
            // 
            // alınanMakine5
            // 
            this.alınanMakine5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine5.FormattingEnabled = true;
            this.alınanMakine5.Location = new System.Drawing.Point(218, 176);
            this.alınanMakine5.Name = "alınanMakine5";
            this.alınanMakine5.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine5.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(12, 274);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(12, 108);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi5
            // 
            this.alınmaTarihi5.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi5.Location = new System.Drawing.Point(407, 28);
            this.alınmaTarihi5.Name = "alınmaTarihi5";
            this.alınmaTarihi5.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi5.TabIndex = 55;
            // 
            // secimAdSoyad5
            // 
            this.secimAdSoyad5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad5.Location = new System.Drawing.Point(166, 63);
            this.secimAdSoyad5.Name = "secimAdSoyad5";
            this.secimAdSoyad5.ReadOnly = true;
            this.secimAdSoyad5.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad5.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC5
            // 
            this.secimTC5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC5.Location = new System.Drawing.Point(166, 26);
            this.secimTC5.Name = "secimTC5";
            this.secimTC5.Size = new System.Drawing.Size(205, 26);
            this.secimTC5.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat5);
            this.Controls.Add(this.islemButonu5);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi5);
            this.Controls.Add(this.secimAdSoyad5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama5";
            this.Load += new System.EventHandler(this.AYıkama5_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A5dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat5;
        private Resources.yuvarlakbuton islemButonu5;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A5dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi5;
        private System.Windows.Forms.TextBox secimAdSoyad5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC5;
        private System.Windows.Forms.Label label1;
    }
}