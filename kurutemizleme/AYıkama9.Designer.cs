namespace kurutemizleme
{
    partial class AYıkama9
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
            this.alınanSaat9 = new System.Windows.Forms.Label();
            this.islemButonu9 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A9dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine9 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi9 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A9dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat9
            // 
            this.alınanSaat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat9.Location = new System.Drawing.Point(487, 69);
            this.alınanSaat9.Name = "alınanSaat9";
            this.alınanSaat9.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat9.TabIndex = 62;
            this.alınanSaat9.Text = "15 : 20";
            // 
            // islemButonu9
            // 
            this.islemButonu9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu9.FlatAppearance.BorderSize = 0;
            this.islemButonu9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu9.ForeColor = System.Drawing.Color.White;
            this.islemButonu9.Location = new System.Drawing.Point(247, 232);
            this.islemButonu9.Name = "islemButonu9";
            this.islemButonu9.Size = new System.Drawing.Size(137, 50);
            this.islemButonu9.TabIndex = 61;
            this.islemButonu9.Text = "İşlemi Bitir";
            this.islemButonu9.UseVisualStyleBackColor = false;
            this.islemButonu9.Click += new System.EventHandler(this.islemButonu9_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A9dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 116);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A9dataGridView
            // 
            this.A9dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A9dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A9dataGridView.Name = "A9dataGridView";
            this.A9dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A9dataGridView.TabIndex = 0;
            // 
            // alınanMakine9
            // 
            this.alınanMakine9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine9.FormattingEnabled = true;
            this.alınanMakine9.Location = new System.Drawing.Point(218, 172);
            this.alınanMakine9.Name = "alınanMakine9";
            this.alınanMakine9.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine9.TabIndex = 59;
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
            // alınmaTarihi9
            // 
            this.alınmaTarihi9.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi9.Location = new System.Drawing.Point(407, 24);
            this.alınmaTarihi9.Name = "alınmaTarihi9";
            this.alınmaTarihi9.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi9.TabIndex = 55;
            // 
            // secimAdSoyad9
            // 
            this.secimAdSoyad9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad9.Location = new System.Drawing.Point(166, 59);
            this.secimAdSoyad9.Name = "secimAdSoyad9";
            this.secimAdSoyad9.ReadOnly = true;
            this.secimAdSoyad9.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad9.TabIndex = 54;
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
            // secimTC9
            // 
            this.secimTC9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC9.Location = new System.Drawing.Point(166, 22);
            this.secimTC9.Name = "secimTC9";
            this.secimTC9.Size = new System.Drawing.Size(205, 26);
            this.secimTC9.TabIndex = 52;
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
            // AYıkama9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat9);
            this.Controls.Add(this.islemButonu9);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi9);
            this.Controls.Add(this.secimAdSoyad9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama9";
            this.Load += new System.EventHandler(this.AYıkama9_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A9dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat9;
        private Resources.yuvarlakbuton islemButonu9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A9dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi9;
        private System.Windows.Forms.TextBox secimAdSoyad9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC9;
        private System.Windows.Forms.Label label1;
    }
}