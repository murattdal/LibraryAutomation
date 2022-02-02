namespace LibraryOtomation
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.AdGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreGiristxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giriskapatmabutonu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdGiristxt
            // 
            this.AdGiristxt.Location = new System.Drawing.Point(173, 208);
            this.AdGiristxt.Name = "AdGiristxt";
            this.AdGiristxt.Size = new System.Drawing.Size(123, 20);
            this.AdGiristxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı ";
            // 
            // SifreGiristxt
            // 
            this.SifreGiristxt.Location = new System.Drawing.Point(173, 274);
            this.SifreGiristxt.Name = "SifreGiristxt";
            this.SifreGiristxt.Size = new System.Drawing.Size(123, 20);
            this.SifreGiristxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Şifre";
            // 
            // PersonelGirisBtn
            // 
            this.PersonelGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PersonelGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonelGirisBtn.Location = new System.Drawing.Point(173, 322);
            this.PersonelGirisBtn.Name = "PersonelGirisBtn";
            this.PersonelGirisBtn.Size = new System.Drawing.Size(123, 40);
            this.PersonelGirisBtn.TabIndex = 4;
            this.PersonelGirisBtn.Text = "Giriş";
            this.PersonelGirisBtn.UseVisualStyleBackColor = false;
            this.PersonelGirisBtn.Click += new System.EventHandler(this.PersonelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // giriskapatmabutonu
            // 
            this.giriskapatmabutonu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.giriskapatmabutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giriskapatmabutonu.Location = new System.Drawing.Point(338, 427);
            this.giriskapatmabutonu.Name = "giriskapatmabutonu";
            this.giriskapatmabutonu.Size = new System.Drawing.Size(92, 31);
            this.giriskapatmabutonu.TabIndex = 6;
            this.giriskapatmabutonu.Text = "Programı Kapat";
            this.giriskapatmabutonu.UseVisualStyleBackColor = false;
            this.giriskapatmabutonu.Click += new System.EventHandler(this.giriskapatmabutonu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(108, 29);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(231, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "KÜTÜPHANE SİSTEMİNE HOŞ GELDİNİZ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(173, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Admin Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1
            // 
            this.AcceptButton = this.PersonelGirisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(442, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giriskapatmabutonu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PersonelGirisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreGiristxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SifreGiristxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PersonelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button giriskapatmabutonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

