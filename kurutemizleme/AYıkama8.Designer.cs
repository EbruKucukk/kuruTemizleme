namespace kurutemizleme
{
    partial class AYıkama8
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
            this.alınanSaat8 = new System.Windows.Forms.Label();
            this.islemButonu8 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A8dataGridView = new System.Windows.Forms.DataGridView();
            this.alınanMakine8 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.alınmaTarihi8 = new System.Windows.Forms.DateTimePicker();
            this.secimAdSoyad8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secimTC8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A8dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alınanSaat8
            // 
            this.alınanSaat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanSaat8.Location = new System.Drawing.Point(486, 69);
            this.alınanSaat8.Name = "alınanSaat8";
            this.alınanSaat8.Size = new System.Drawing.Size(100, 34);
            this.alınanSaat8.TabIndex = 62;
            this.alınanSaat8.Text = "14 : 30";
            // 
            // islemButonu8
            // 
            this.islemButonu8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu8.FlatAppearance.BorderSize = 0;
            this.islemButonu8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu8.ForeColor = System.Drawing.Color.White;
            this.islemButonu8.Location = new System.Drawing.Point(246, 232);
            this.islemButonu8.Name = "islemButonu8";
            this.islemButonu8.Size = new System.Drawing.Size(137, 50);
            this.islemButonu8.TabIndex = 61;
            this.islemButonu8.Text = "İşlemi Bitir";
            this.islemButonu8.UseVisualStyleBackColor = false;
            this.islemButonu8.Click += new System.EventHandler(this.islemButonu8_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A8dataGridView);
            this.panel15.Location = new System.Drawing.Point(435, 116);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 60;
            // 
            // A8dataGridView
            // 
            this.A8dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A8dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A8dataGridView.Name = "A8dataGridView";
            this.A8dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A8dataGridView.TabIndex = 0;
            // 
            // alınanMakine8
            // 
            this.alınanMakine8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine8.FormattingEnabled = true;
            this.alınanMakine8.Location = new System.Drawing.Point(217, 172);
            this.alınanMakine8.Name = "alınanMakine8";
            this.alınanMakine8.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine8.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Makine Seç  :";
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(11, 270);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 57;
            this.uyarıYazisi2.Text = "Gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(11, 104);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 56;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            // 
            // alınmaTarihi8
            // 
            this.alınmaTarihi8.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi8.Location = new System.Drawing.Point(406, 24);
            this.alınmaTarihi8.Name = "alınmaTarihi8";
            this.alınmaTarihi8.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi8.TabIndex = 55;
            // 
            // secimAdSoyad8
            // 
            this.secimAdSoyad8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad8.Location = new System.Drawing.Point(165, 59);
            this.secimAdSoyad8.Name = "secimAdSoyad8";
            this.secimAdSoyad8.ReadOnly = true;
            this.secimAdSoyad8.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad8.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimTC8
            // 
            this.secimTC8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC8.Location = new System.Drawing.Point(165, 22);
            this.secimTC8.Name = "secimTC8";
            this.secimTC8.Size = new System.Drawing.Size(205, 26);
            this.secimTC8.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // AYıkama8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınanSaat8);
            this.Controls.Add(this.islemButonu8);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.Controls.Add(this.alınmaTarihi8);
            this.Controls.Add(this.secimAdSoyad8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secimTC8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama8";
            this.Load += new System.EventHandler(this.AYıkama8_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A8dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alınanSaat8;
        private Resources.yuvarlakbuton islemButonu8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A8dataGridView;
        private System.Windows.Forms.ComboBox alınanMakine8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.DateTimePicker alınmaTarihi8;
        private System.Windows.Forms.TextBox secimAdSoyad8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimTC8;
        private System.Windows.Forms.Label label1;
    }
}