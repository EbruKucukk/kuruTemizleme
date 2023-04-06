namespace kurutemizleme
{
    partial class AYıkama4
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
            this.alınanSaat3 = new System.Windows.Forms.Label();
            this.islemButonu4 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A4dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi4 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A4dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat3
            // 
            this.alınanSaat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat3.Location = new System.Drawing.Point(486, 71);
            this.alınanSaat3.Name = "alınanSaat3";
            this.alınanSaat3.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat3.TabIndex = 62;
            this.alınanSaat3.Text = "11 : 00";
            // 
            // islemButonu4
            // 
            this.islemButonu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu4.FlatAppearance.BorderSize = 0;
            this.islemButonu4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu4.ForeColor = System.Drawing.Color.White;
            this.islemButonu4.Location = new System.Drawing.Point(246, 234);
            this.islemButonu4.Name = "islemButonu4";
            this.islemButonu4.Size = new System.Drawing.Size(137, 50);
            this.islemButonu4.TabIndex = 61;
            this.islemButonu4.Text = "İşlemi Bitir";
            this.islemButonu4.UseVisualStyleBackColor = false;
            this.islemButonu4.Click += new System.EventHandler(this.islemButonu3_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A4dataGridView);
            this.panel15.Location = new System.Drawing.Point(435, 118);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A4dataGridView
            // 
            this.A4dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A4dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A4dataGridView.Name = "A4dataGridView";
            this.A4dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A4dataGridView.TabIndex = 0;
            // 
            // alınanMakine4
            // 
            this.alınanMakine4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine4.FormattingEnabled = true;
            this.alınanMakine4.Location = new System.Drawing.Point(217, 174);
            this.alınanMakine4.Name = "alınanMakine4";
            this.alınanMakine4.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine4.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(11, 272);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(11, 106);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi4
            // 
            this.alınmaTarihi4.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi4.Location = new System.Drawing.Point(406, 26);
            this.alınmaTarihi4.Name = "alınmaTarihi4";
            this.alınmaTarihi4.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi4.TabIndex = 55;
            // 
            // secimAdSoyad4
            // 
            this.secimAdSoyad4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad4.Location = new System.Drawing.Point(165, 61);
            this.secimAdSoyad4.Name = "secimAdSoyad4";
            this.secimAdSoyad4.ReadOnly = true;
            this.secimAdSoyad4.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad4.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC4
            // 
            this.secimTC4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC4.Location = new System.Drawing.Point(165, 24);
            this.secimTC4.Name = "secimTC4";
            this.secimTC4.Size = new System.Drawing.Size(205, 26);
            this.secimTC4.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat3);
            this.Controls.Add(this.islemButonu4);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi4);
            this.Controls.Add(this.secimAdSoyad4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama4";
            this.Load += new System.EventHandler(this.AYıkama4_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A4dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat3;
        private Resources.yuvarlakbuton islemButonu4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A4dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi4;
        private System.Windows.Forms.TextBox secimAdSoyad4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC4;
        private System.Windows.Forms.Label label1;
    }
}