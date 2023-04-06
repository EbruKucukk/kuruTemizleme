namespace kurutemizleme
{
    partial class AYıkama6
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
            this.alınanSaat6 = new System.Windows.Forms.Label();
            this.islemButonu6 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A6dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine6 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi6 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A6dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat6
            // 
            this.alınanSaat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat6.Location = new System.Drawing.Point(487, 71);
            this.alınanSaat6.Name = "alınanSaat6";
            this.alınanSaat6.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat6.TabIndex = 62;
            this.alınanSaat6.Text = "12 : 40";
            // 
            // islemButonu6
            // 
            this.islemButonu6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu6.FlatAppearance.BorderSize = 0;
            this.islemButonu6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu6.ForeColor = System.Drawing.Color.White;
            this.islemButonu6.Location = new System.Drawing.Point(247, 234);
            this.islemButonu6.Name = "islemButonu6";
            this.islemButonu6.Size = new System.Drawing.Size(137, 50);
            this.islemButonu6.TabIndex = 61;
            this.islemButonu6.Text = "İşlemi Bitir";
            this.islemButonu6.UseVisualStyleBackColor = false;
            this.islemButonu6.Click += new System.EventHandler(this.islemButonu6_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A6dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 118);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A6dataGridView
            // 
            this.A6dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A6dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A6dataGridView.Name = "A6dataGridView";
            this.A6dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A6dataGridView.TabIndex = 0;
            // 
            // alınanMakine6
            // 
            this.alınanMakine6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine6.FormattingEnabled = true;
            this.alınanMakine6.Location = new System.Drawing.Point(218, 174);
            this.alınanMakine6.Name = "alınanMakine6";
            this.alınanMakine6.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine6.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(12, 272);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(12, 106);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi6
            // 
            this.alınmaTarihi6.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi6.Location = new System.Drawing.Point(407, 26);
            this.alınmaTarihi6.Name = "alınmaTarihi6";
            this.alınmaTarihi6.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi6.TabIndex = 55;
            // 
            // secimAdSoyad6
            // 
            this.secimAdSoyad6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad6.Location = new System.Drawing.Point(166, 61);
            this.secimAdSoyad6.Name = "secimAdSoyad6";
            this.secimAdSoyad6.ReadOnly = true;
            this.secimAdSoyad6.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad6.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC6
            // 
            this.secimTC6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC6.Location = new System.Drawing.Point(166, 24);
            this.secimTC6.Name = "secimTC6";
            this.secimTC6.Size = new System.Drawing.Size(205, 26);
            this.secimTC6.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat6);
            this.Controls.Add(this.islemButonu6);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi6);
            this.Controls.Add(this.secimAdSoyad6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama6";
            this.Load += new System.EventHandler(this.AYıkama6_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A6dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat6;
        private Resources.yuvarlakbuton islemButonu6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A6dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi6;
        private System.Windows.Forms.TextBox secimAdSoyad6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC6;
        private System.Windows.Forms.Label label1;
    }
}