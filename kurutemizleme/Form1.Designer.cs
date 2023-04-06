namespace kurutemizleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnadataGridView = new System.Windows.Forms.DataGridView();
            this.yuvarlakbuton2 = new kurutemizleme.Resources.yuvarlakbuton();
            this.yuvarlakbuton1 = new kurutemizleme.Resources.yuvarlakbuton();
            this.label4 = new System.Windows.Forms.Label();
            this.saatArama = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::kurutemizleme.Properties.Resources.kjnkl;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(764, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 651);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 651);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::kurutemizleme.Properties.Resources.lmk;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gunTarihi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 651);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.panel3.Location = new System.Drawing.Point(286, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 651);
            this.panel3.TabIndex = 9;
            // 
            // gunTarihi
            // 
            this.gunTarihi.Enabled = false;
            this.gunTarihi.Location = new System.Drawing.Point(35, 16);
            this.gunTarihi.Name = "gunTarihi";
            this.gunTarihi.Size = new System.Drawing.Size(200, 20);
            this.gunTarihi.TabIndex = 11;
            this.gunTarihi.ValueChanged += new System.EventHandler(this.gunTarihi_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(289, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "FATMA ANA KYK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(269, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 83);
            this.label2.TabIndex = 3;
            this.label2.Text = "KURU TEMİZLEME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.panel5.Location = new System.Drawing.Point(401, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.panel6.Location = new System.Drawing.Point(346, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(361, 1);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "GSB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnadataGridView
            // 
            this.AnadataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.AnadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(125)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AnadataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.AnadataGridView.Location = new System.Drawing.Point(389, 242);
            this.AnadataGridView.Name = "AnadataGridView";
            this.AnadataGridView.Size = new System.Drawing.Size(271, 195);
            this.AnadataGridView.TabIndex = 10;
            this.AnadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnadataGridView_CellContentClick);
            // 
            // yuvarlakbuton2
            // 
            this.yuvarlakbuton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(125)))), ((int)(((byte)(136)))));
            this.yuvarlakbuton2.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.yuvarlakbuton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvarlakbuton2.ForeColor = System.Drawing.Color.White;
            this.yuvarlakbuton2.Location = new System.Drawing.Point(472, 499);
            this.yuvarlakbuton2.Name = "yuvarlakbuton2";
            this.yuvarlakbuton2.Size = new System.Drawing.Size(124, 53);
            this.yuvarlakbuton2.TabIndex = 5;
            this.yuvarlakbuton2.Text = "Kaydol";
            this.yuvarlakbuton2.UseVisualStyleBackColor = false;
            this.yuvarlakbuton2.Click += new System.EventHandler(this.yuvarlakbuton2_Click);
            // 
            // yuvarlakbuton1
            // 
            this.yuvarlakbuton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(125)))), ((int)(((byte)(136)))));
            this.yuvarlakbuton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.yuvarlakbuton1.FlatAppearance.BorderSize = 0;
            this.yuvarlakbuton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.yuvarlakbuton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.yuvarlakbuton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakbuton1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvarlakbuton1.ForeColor = System.Drawing.SystemColors.Window;
            this.yuvarlakbuton1.Location = new System.Drawing.Point(472, 443);
            this.yuvarlakbuton1.Name = "yuvarlakbuton1";
            this.yuvarlakbuton1.Size = new System.Drawing.Size(124, 50);
            this.yuvarlakbuton1.TabIndex = 4;
            this.yuvarlakbuton1.Text = "Giriş Yap";
            this.yuvarlakbuton1.UseVisualStyleBackColor = false;
            this.yuvarlakbuton1.Click += new System.EventHandler(this.yuvarlakbuton1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(248)))));
            this.label4.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(383, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saat : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saatArama
            // 
            this.saatArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatArama.Location = new System.Drawing.Point(472, 200);
            this.saatArama.Name = "saatArama";
            this.saatArama.Size = new System.Drawing.Size(166, 24);
            this.saatArama.TabIndex = 12;
            this.saatArama.TextChanged += new System.EventHandler(this.saatArama_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1035, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saatArama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnadataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.yuvarlakbuton2);
            this.Controls.Add(this.yuvarlakbuton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(320, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Resources.yuvarlakbuton yuvarlakbuton1;
        private Resources.yuvarlakbuton yuvarlakbuton2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView AnadataGridView;
        private System.Windows.Forms.DateTimePicker gunTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saatArama;
    }
}

