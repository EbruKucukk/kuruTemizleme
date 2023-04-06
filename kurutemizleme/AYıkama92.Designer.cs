namespace kurutemizleme
{
    partial class AYıkama92
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
            this.alınanSaat12 = new System.Windows.Forms.Label();
            this.islemButonu12 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A12dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine12 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi12 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC12 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A12dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat12
            // 
            this.alınanSaat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat12.Location = new System.Drawing.Point(490, 72);
            this.alınanSaat12.Name = "alınanSaat12";
            this.alınanSaat12.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat12.TabIndex = 62;
            this.alınanSaat12.Text = "17 : 50";
            // 
            // islemButonu12
            // 
            this.islemButonu12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu12.FlatAppearance.BorderSize = 0;
            this.islemButonu12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu12.ForeColor = System.Drawing.Color.White;
            this.islemButonu12.Location = new System.Drawing.Point(250, 235);
            this.islemButonu12.Name = "islemButonu12";
            this.islemButonu12.Size = new System.Drawing.Size(137, 50);
            this.islemButonu12.TabIndex = 61;
            this.islemButonu12.Text = "İşlemi Bitir";
            this.islemButonu12.UseVisualStyleBackColor = false;
            this.islemButonu12.Click += new System.EventHandler(this.islemButonu12_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A12dataGridView);
            this.panel15.Location = new System.Drawing.Point(439, 119);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A12dataGridView
            // 
            this.A12dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A12dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A12dataGridView.Name = "A12dataGridView";
            this.A12dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A12dataGridView.TabIndex = 0;
            // 
            // alınanMakine12
            // 
            this.alınanMakine12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine12.FormattingEnabled = true;
            this.alınanMakine12.Location = new System.Drawing.Point(221, 175);
            this.alınanMakine12.Name = "alınanMakine12";
            this.alınanMakine12.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine12.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(15, 273);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(15, 107);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi12
            // 
            this.alınmaTarihi12.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi12.Location = new System.Drawing.Point(410, 27);
            this.alınmaTarihi12.Name = "alınmaTarihi12";
            this.alınmaTarihi12.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi12.TabIndex = 55;
            // 
            // secimAdSoyad12
            // 
            this.secimAdSoyad12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad12.Location = new System.Drawing.Point(169, 62);
            this.secimAdSoyad12.Name = "secimAdSoyad12";
            this.secimAdSoyad12.ReadOnly = true;
            this.secimAdSoyad12.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad12.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC12
            // 
            this.secimTC12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC12.Location = new System.Drawing.Point(169, 25);
            this.secimTC12.Name = "secimTC12";
            this.secimTC12.Size = new System.Drawing.Size(205, 26);
            this.secimTC12.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama92
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat12);
            this.Controls.Add(this.islemButonu12);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi12);
            this.Controls.Add(this.secimAdSoyad12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC12);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama92";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama93";
            this.Load += new System.EventHandler(this.AYıkama92_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A12dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat12;
        private Resources.yuvarlakbuton islemButonu12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A12dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi12;
        private System.Windows.Forms.TextBox secimAdSoyad12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC12;
        private System.Windows.Forms.Label label1;
    }
}