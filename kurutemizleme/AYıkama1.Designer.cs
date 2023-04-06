namespace kurutemizleme
{
    partial class AYıkama1
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
            this.uyarıYazı = new System.Windows.Forms.Label();
            this.uyarıYazisi2 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.A1dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.secimAdSoyad = new System.Windows.Forms.TextBox();
            this.alınmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.secimTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alınanMakine = new System.Windows.Forms.ComboBox();
            this.alınanSaat = new System.Windows.Forms.Label();
            this._kuru_temizlemeDataSet21 = new kurutemizleme._kuru_temizlemeDataSet2();
            this.islemButonu1 = new kurutemizleme.Resources.yuvarlakbuton();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A1dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._kuru_temizlemeDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // uyarıYazı
            // 
            this.uyarıYazı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazı.Location = new System.Drawing.Point(12, 108);
            this.uyarıYazı.Name = "uyarıYazı";
            this.uyarıYazı.Size = new System.Drawing.Size(200, 123);
            this.uyarıYazı.TabIndex = 30;
            this.uyarıYazı.Text = "Lütfen seçtiğiniz saatte çamaşırhaneyi kullanmaya dikkat ediniz.";
            this.uyarıYazı.Click += new System.EventHandler(this.uyarıYazı_Click);
            // 
            // uyarıYazisi2
            // 
            this.uyarıYazisi2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarıYazisi2.Location = new System.Drawing.Point(12, 272);
            this.uyarıYazisi2.Name = "uyarıYazisi2";
            this.uyarıYazisi2.Size = new System.Drawing.Size(200, 99);
            this.uyarıYazisi2.TabIndex = 31;
            this.uyarıYazisi2.Text = "3 gün içerisinde sadece bir adet işlem hakkınız bulunmaktadır.";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.panel15.Controls.Add(this.A1dataGridView);
            this.panel15.Location = new System.Drawing.Point(436, 120);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 275);
            this.panel15.TabIndex = 33;
            // 
            // A1dataGridView
            // 
            this.A1dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A1dataGridView.Location = new System.Drawing.Point(14, 12);
            this.A1dataGridView.Name = "A1dataGridView";
            this.A1dataGridView.Size = new System.Drawing.Size(166, 247);
            this.A1dataGridView.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ad Soyad:";
            // 
            // secimAdSoyad
            // 
            this.secimAdSoyad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimAdSoyad.Location = new System.Drawing.Point(166, 66);
            this.secimAdSoyad.Name = "secimAdSoyad";
            this.secimAdSoyad.ReadOnly = true;
            this.secimAdSoyad.Size = new System.Drawing.Size(205, 26);
            this.secimAdSoyad.TabIndex = 36;
            this.secimAdSoyad.TextChanged += new System.EventHandler(this.secimASoyad_TextChanged);
            // 
            // alınmaTarihi
            // 
            this.alınmaTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi.Enabled = false;
            this.alınmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınmaTarihi.Location = new System.Drawing.Point(407, 28);
            this.alınmaTarihi.Name = "alınmaTarihi";
            this.alınmaTarihi.Size = new System.Drawing.Size(285, 30);
            this.alınmaTarihi.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "T.C. Kimlik:";
            // 
            // secimTC
            // 
            this.secimTC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimTC.Location = new System.Drawing.Point(166, 26);
            this.secimTC.Name = "secimTC";
            this.secimTC.Size = new System.Drawing.Size(205, 26);
            this.secimTC.TabIndex = 39;
            this.secimTC.TextChanged += new System.EventHandler(this.secimTC_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Makine Seç  :";
            // 
            // alınanMakine
            // 
            this.alınanMakine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alınanMakine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alınanMakine.FormattingEnabled = true;
            this.alınanMakine.Location = new System.Drawing.Point(218, 176);
            this.alınanMakine.Name = "alınanMakine";
            this.alınanMakine.Size = new System.Drawing.Size(181, 26);
            this.alınanMakine.TabIndex = 48;
            // 
            // alınanSaat
            // 
            this.alınanSaat.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alınanSaat.ForeColor = System.Drawing.Color.Black;
            this.alınanSaat.Location = new System.Drawing.Point(481, 75);
            this.alınanSaat.Name = "alınanSaat";
            this.alınanSaat.Size = new System.Drawing.Size(149, 29);
            this.alınanSaat.TabIndex = 49;
            this.alınanSaat.Text = "8 : 30";
            this.alınanSaat.Click += new System.EventHandler(this.alınanSaat_Click);
            // 
            // _kuru_temizlemeDataSet21
            // 
            this._kuru_temizlemeDataSet21.DataSetName = "_kuru_temizlemeDataSet2";
            this._kuru_temizlemeDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemButonu1
            // 
            this.islemButonu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(163)))), ((int)(((byte)(154)))));
            this.islemButonu1.FlatAppearance.BorderSize = 0;
            this.islemButonu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.islemButonu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemButonu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemButonu1.ForeColor = System.Drawing.Color.White;
            this.islemButonu1.Location = new System.Drawing.Point(247, 236);
            this.islemButonu1.Name = "islemButonu1";
            this.islemButonu1.Size = new System.Drawing.Size(137, 50);
            this.islemButonu1.TabIndex = 34;
            this.islemButonu1.Text = "İşlemi Bitir";
            this.islemButonu1.UseVisualStyleBackColor = false;
            this.islemButonu1.Click += new System.EventHandler(this.islemButonu1_Click);
            // 
            // AYıkama1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.ControlBox = false;
            this.Controls.Add(this.alınmaTarihi);
            this.Controls.Add(this.alınanSaat);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.alınanMakine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secimTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secimAdSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.islemButonu1);
            this.Controls.Add(this.uyarıYazisi2);
            this.Controls.Add(this.uyarıYazı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 450);
            this.Name = "AYıkama1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYıkama1";
            this.Load += new System.EventHandler(this.AYıkama1_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A1dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._kuru_temizlemeDataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uyarıYazı;
        private System.Windows.Forms.Label uyarıYazisi2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView A1dataGridView;
        private Resources.yuvarlakbuton islemButonu1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secimAdSoyad;
        private System.Windows.Forms.DateTimePicker alınmaTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secimTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox alınanMakine;
        private System.Windows.Forms.Label alınanSaat;
        private _kuru_temizlemeDataSet2 _kuru_temizlemeDataSet21;
    }
}