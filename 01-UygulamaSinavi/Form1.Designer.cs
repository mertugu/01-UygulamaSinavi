namespace _01_UygulamaSinavi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnHesapla = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            numericUpDownKosuSaat = new NumericUpDown();
            label5 = new Label();
            txtAdimSayisi = new TextBox();
            label4 = new Label();
            numericUpDownKosuDakika = new NumericUpDown();
            txtAdimUzunluk = new TextBox();
            label3 = new Label();
            btnGelismisHesaplama = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuSaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuDakika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 29);
            label1.TabIndex = 0;
            label1.Text = "Adım";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(81, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Ölçer";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.SteelBlue;
            btnHesapla.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHesapla.ForeColor = Color.Transparent;
            btnHesapla.Location = new Point(39, 325);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(148, 70);
            btnHesapla.TabIndex = 12;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownKosuSaat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAdimSayisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownKosuDakika);
            groupBox1.Controls.Add(txtAdimUzunluk);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(39, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 208);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(333, 134);
            label6.Name = "label6";
            label6.Size = new Size(17, 28);
            label6.TabIndex = 17;
            label6.Text = ":";
            // 
            // numericUpDownKosuSaat
            // 
            numericUpDownKosuSaat.Location = new Point(356, 135);
            numericUpDownKosuSaat.Name = "numericUpDownKosuSaat";
            numericUpDownKosuSaat.Size = new Size(185, 27);
            numericUpDownKosuSaat.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(142, 112);
            label5.Name = "label5";
            label5.Size = new Size(373, 20);
            label5.TabIndex = 16;
            label5.Text = "Koşu Süresi:(Önce Saat ve ardından Dakika Ör: 1:30)";
            // 
            // txtAdimSayisi
            // 
            txtAdimSayisi.Location = new Point(394, 51);
            txtAdimSayisi.Name = "txtAdimSayisi";
            txtAdimSayisi.Size = new Size(233, 27);
            txtAdimSayisi.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(394, 28);
            label4.Name = "label4";
            label4.Size = new Size(267, 20);
            label4.TabIndex = 14;
            label4.Text = "Ortalama Adım Sayısı (1 Dakika için):";
            // 
            // numericUpDownKosuDakika
            // 
            numericUpDownKosuDakika.Location = new Point(142, 135);
            numericUpDownKosuDakika.Name = "numericUpDownKosuDakika";
            numericUpDownKosuDakika.Size = new Size(185, 27);
            numericUpDownKosuDakika.TabIndex = 19;
            // 
            // txtAdimUzunluk
            // 
            txtAdimUzunluk.Location = new Point(73, 51);
            txtAdimUzunluk.Name = "txtAdimUzunluk";
            txtAdimUzunluk.Size = new Size(228, 27);
            txtAdimUzunluk.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(73, 28);
            label3.Name = "label3";
            label3.Size = new Size(294, 20);
            label3.TabIndex = 12;
            label3.Text = "Ortalama Adım Uzunluğu:(cm cinsinden)";
            // 
            // btnGelismisHesaplama
            // 
            btnGelismisHesaplama.BackColor = Color.SteelBlue;
            btnGelismisHesaplama.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGelismisHesaplama.ForeColor = Color.Transparent;
            btnGelismisHesaplama.Location = new Point(39, 423);
            btnGelismisHesaplama.Name = "btnGelismisHesaplama";
            btnGelismisHesaplama.Size = new Size(148, 70);
            btnGelismisHesaplama.TabIndex = 14;
            btnGelismisHesaplama.Text = "Gelişmiş Hesaplama";
            btnGelismisHesaplama.UseVisualStyleBackColor = false;
            btnGelismisHesaplama.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 496);
            label7.Name = "label7";
            label7.Size = new Size(709, 20);
            label7.TabIndex = 15;
            label7.Text = "Gelişmiş hesaplama aracılığıyla belirli bir süre koşu belirli bir süre yürüme hızıyla hesaplama yapabilirsiniz.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(label7);
            Controls.Add(btnGelismisHesaplama);
            Controls.Add(groupBox1);
            Controls.Add(btnHesapla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuSaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuDakika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHesapla;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownKosuDakika;
        private NumericUpDown numericUpDownKosuSaat;
        private Label label6;
        private Label label5;
        private TextBox txtAdimSayisi;
        private Label label4;
        private TextBox txtAdimUzunluk;
        private Label label3;
        private Button btnGelismisHesaplama;
        private Label label7;
    }
}
