namespace kurutemizleme
{
    partial class AYıkama3
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
            this.islemButonu3 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A3dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi3 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A3dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat3
            // 
            this.alınanSaat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat3.Location = new System.Drawing.Point(486, 72);
            this.alınanSaat3.Name = "alınanSaat3";
            this.alınanSaat3.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat3.TabIndex = 62;
            this.alınanSaat3.Text = "10 : 10";
            // 
            // islemButonu3
            // 
            this.islemButonu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu3.FlatAppearance.BorderSize = 0;
            this.islemButonu3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu3.ForeColor = System.Drawing.Color.White;
            this.islemButonu3.Location = new System.Drawing.Point(246, 235);
            this.islemButonu3.Name = "islemButonu3";
            this.islemButonu3.Size = new System.Drawing.Size(137, 50);
            this.islemButonu3.TabIndex = 61;
            this.islemButonu3.Text = "İşlemi Bitir";
            this.islemButonu3.UseVisualStyleBackColor = false;
            this.islemButonu3.Click += new System.EventHandler(this.islemButonu3_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A3dataGridView);
            this.panel15.Location = new System.Drawing.Point(435, 119);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A3dataGridView
            // 
            this.A3dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A3dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A3dataGridView.Name = "A3dataGridView";
            this.A3dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A3dataGridView.TabIndex = 0;
            // 
            // alınanMakine3
            // 
            this.alınanMakine3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine3.FormattingEnabled = true;
            this.alınanMakine3.Location = new System.Drawing.Point(217, 175);
            this.alınanMakine3.Name = "alınanMakine3";
            this.alınanMakine3.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine3.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(11, 273);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(11, 107);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi3
            // 
            this.alınmaTarihi3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi3.Location = new System.Drawing.Point(406, 27);
            this.alınmaTarihi3.Name = "alınmaTarihi3";
            this.alınmaTarihi3.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi3.TabIndex = 55;
            // 
            // secimAdSoyad3
            // 
            this.secimAdSoyad3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad3.Location = new System.Drawing.Point(165, 62);
            this.secimAdSoyad3.Name = "secimAdSoyad3";
            this.secimAdSoyad3.ReadOnly = true;
            this.secimAdSoyad3.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad3.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC3
            // 
            this.secimTC3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC3.Location = new System.Drawing.Point(165, 25);
            this.secimTC3.Name = "secimTC3";
            this.secimTC3.Size = new System.Drawing.Size(205, 26);
            this.secimTC3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat3);
            this.Controls.Add(this.islemButonu3);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi3);
            this.Controls.Add(this.secimAdSoyad3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama3";
            this.Load += new System.EventHandler(this.AYıkama3_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A3dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat3;
        private Resources.yuvarlakbuton islemButonu3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A3dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi3;
        private System.Windows.Forms.TextBox secimAdSoyad3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC3;
        private System.Windows.Forms.Label label1;
    }
}