namespace kurutemizleme
{
    partial class personelGirisi
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
            this.personelUlasabilir = new System.Windows.Forms.Label();
            this.personelSifresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelUlasabilir
            // 
            this.personelUlasabilir.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelUlasabilir.Location = new System.Drawing.Point(55, 30);
            this.personelUlasabilir.Name = "personelUlasabilir";
            this.personelUlasabilir.Size = new System.Drawing.Size(429, 37);
            this.personelUlasabilir.TabIndex = 0;
            this.personelUlasabilir.Text = "Bu yetkiye sadece personel ulaşabilir.";
            // 
            // personelSifresi
            // 
            this.personelSifresi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelSifresi.Location = new System.Drawing.Point(169, 116);
            this.personelSifresi.Name = "personelSifresi";
            this.personelSifresi.Size = new System.Drawing.Size(179, 26);
            this.personelSifresi.TabIndex = 1;
            this.personelSifresi.TextChanged += new System.EventHandler(this.personelSifresi_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen parolayı giriniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(211, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // personelGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(525, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelSifresi);
            this.Controls.Add(this.personelUlasabilir);
            this.Location = new System.Drawing.Point(570, 360);
            this.Name = "personelGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "personelGirisi";
            this.Load += new System.EventHandler(this.personelGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personelUlasabilir;
        private System.Windows.Forms.TextBox personelSifresi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}