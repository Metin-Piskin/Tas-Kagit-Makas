namespace Taş_Kağıt_Makas
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.TurTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxOyuncu = new System.Windows.Forms.PictureBox();
            this.pictureBoxBilgisayar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaşB = new System.Windows.Forms.Button();
            this.KağıtB = new System.Windows.Forms.Button();
            this.MakasB = new System.Windows.Forms.Button();
            this.YBaşlatB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BilgisayarSkorL = new System.Windows.Forms.Label();
            this.OyuncuSkorL = new System.Windows.Forms.Label();
            this.BaşlatB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBilgisayar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç Tur Oynayacaksınız :";
            // 
            // TurTextBox
            // 
            this.TurTextBox.Location = new System.Drawing.Point(319, 24);
            this.TurTextBox.Name = "TurTextBox";
            this.TurTextBox.Size = new System.Drawing.Size(220, 32);
            this.TurTextBox.TabIndex = 1;
            // 
            // pictureBoxOyuncu
            // 
            this.pictureBoxOyuncu.Location = new System.Drawing.Point(94, 168);
            this.pictureBoxOyuncu.Name = "pictureBoxOyuncu";
            this.pictureBoxOyuncu.Size = new System.Drawing.Size(136, 156);
            this.pictureBoxOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOyuncu.TabIndex = 2;
            this.pictureBoxOyuncu.TabStop = false;
            this.pictureBoxOyuncu.Visible = false;
            // 
            // pictureBoxBilgisayar
            // 
            this.pictureBoxBilgisayar.Location = new System.Drawing.Point(402, 168);
            this.pictureBoxBilgisayar.Name = "pictureBoxBilgisayar";
            this.pictureBoxBilgisayar.Size = new System.Drawing.Size(136, 156);
            this.pictureBoxBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBilgisayar.TabIndex = 3;
            this.pictureBoxBilgisayar.TabStop = false;
            this.pictureBoxBilgisayar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oyuncu";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bilgisayar";
            this.label3.Visible = false;
            // 
            // TaşB
            // 
            this.TaşB.Location = new System.Drawing.Point(28, 363);
            this.TaşB.Name = "TaşB";
            this.TaşB.Size = new System.Drawing.Size(79, 79);
            this.TaşB.TabIndex = 6;
            this.TaşB.Text = "Taş";
            this.TaşB.UseVisualStyleBackColor = true;
            this.TaşB.Visible = false;
            this.TaşB.Click += new System.EventHandler(this.TaşB_Click);
            // 
            // KağıtB
            // 
            this.KağıtB.Location = new System.Drawing.Point(113, 363);
            this.KağıtB.Name = "KağıtB";
            this.KağıtB.Size = new System.Drawing.Size(79, 79);
            this.KağıtB.TabIndex = 7;
            this.KağıtB.Text = "Kağıt";
            this.KağıtB.UseVisualStyleBackColor = true;
            this.KağıtB.Visible = false;
            this.KağıtB.Click += new System.EventHandler(this.KağıtB_Click);
            // 
            // MakasB
            // 
            this.MakasB.Location = new System.Drawing.Point(198, 363);
            this.MakasB.Name = "MakasB";
            this.MakasB.Size = new System.Drawing.Size(79, 79);
            this.MakasB.TabIndex = 8;
            this.MakasB.Text = "Makas";
            this.MakasB.UseVisualStyleBackColor = true;
            this.MakasB.Visible = false;
            this.MakasB.Click += new System.EventHandler(this.MakasB_Click);
            // 
            // YBaşlatB
            // 
            this.YBaşlatB.Location = new System.Drawing.Point(12, 495);
            this.YBaşlatB.Name = "YBaşlatB";
            this.YBaşlatB.Size = new System.Drawing.Size(580, 59);
            this.YBaşlatB.TabIndex = 9;
            this.YBaşlatB.Text = "Yeniden Başlat";
            this.YBaşlatB.UseVisualStyleBackColor = true;
            this.YBaşlatB.Visible = false;
            this.YBaşlatB.Click += new System.EventHandler(this.YBaşlatB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Skor";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bilgisayar :";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Oyuncu :";
            this.label6.Visible = false;
            // 
            // BilgisayarSkorL
            // 
            this.BilgisayarSkorL.AutoSize = true;
            this.BilgisayarSkorL.Location = new System.Drawing.Point(504, 390);
            this.BilgisayarSkorL.Name = "BilgisayarSkorL";
            this.BilgisayarSkorL.Size = new System.Drawing.Size(21, 24);
            this.BilgisayarSkorL.TabIndex = 13;
            this.BilgisayarSkorL.Text = "0";
            this.BilgisayarSkorL.Visible = false;
            // 
            // OyuncuSkorL
            // 
            this.OyuncuSkorL.AutoSize = true;
            this.OyuncuSkorL.Location = new System.Drawing.Point(495, 425);
            this.OyuncuSkorL.Name = "OyuncuSkorL";
            this.OyuncuSkorL.Size = new System.Drawing.Size(21, 24);
            this.OyuncuSkorL.TabIndex = 14;
            this.OyuncuSkorL.Text = "0";
            this.OyuncuSkorL.Visible = false;
            // 
            // BaşlatB
            // 
            this.BaşlatB.Location = new System.Drawing.Point(12, 63);
            this.BaşlatB.Name = "BaşlatB";
            this.BaşlatB.Size = new System.Drawing.Size(580, 58);
            this.BaşlatB.TabIndex = 15;
            this.BaşlatB.Text = "Başlat";
            this.BaşlatB.UseVisualStyleBackColor = true;
            this.BaşlatB.Click += new System.EventHandler(this.BaşlatB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(604, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BaşlatB);
            this.Controls.Add(this.OyuncuSkorL);
            this.Controls.Add(this.BilgisayarSkorL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YBaşlatB);
            this.Controls.Add(this.MakasB);
            this.Controls.Add(this.KağıtB);
            this.Controls.Add(this.TaşB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxBilgisayar);
            this.Controls.Add(this.pictureBoxOyuncu);
            this.Controls.Add(this.TurTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş/Kağıt/Makas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBilgisayar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TurTextBox;
        private System.Windows.Forms.PictureBox pictureBoxOyuncu;
        private System.Windows.Forms.PictureBox pictureBoxBilgisayar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TaşB;
        private System.Windows.Forms.Button KağıtB;
        private System.Windows.Forms.Button MakasB;
        private System.Windows.Forms.Button YBaşlatB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BilgisayarSkorL;
        private System.Windows.Forms.Label OyuncuSkorL;
        private System.Windows.Forms.Button BaşlatB;
        private System.Windows.Forms.Label label7;
    }
}

