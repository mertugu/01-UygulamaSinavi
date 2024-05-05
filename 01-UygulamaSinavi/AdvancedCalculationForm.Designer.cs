namespace _01_UygulamaSinavi
{
    partial class AdvancedCalculationForm
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            numericUpDownKosuSaat = new NumericUpDown();
            label5 = new Label();
            txtKosuAdimSayisi = new TextBox();
            label4 = new Label();
            numericUpDownKosuDakika = new NumericUpDown();
            txtKosuAdimUzunluk = new TextBox();
            label3 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            numericUpDownDakika = new NumericUpDown();
            label9 = new Label();
            txtYurumeAdimSayisi = new TextBox();
            label10 = new Label();
            numericUpDownSaat = new NumericUpDown();
            txtYurumeAdimUzunluk = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnGelismisHesapla = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuSaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuDakika).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDakika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 29);
            label1.TabIndex = 1;
            label1.Text = "Adım";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(80, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Ölçer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownKosuSaat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtKosuAdimSayisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownKosuDakika);
            groupBox1.Controls.Add(txtKosuAdimUzunluk);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(22, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 213);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
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
            // txtKosuAdimSayisi
            // 
            txtKosuAdimSayisi.Location = new Point(394, 51);
            txtKosuAdimSayisi.Name = "txtKosuAdimSayisi";
            txtKosuAdimSayisi.Size = new Size(233, 27);
            txtKosuAdimSayisi.TabIndex = 15;
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
            // txtKosuAdimUzunluk
            // 
            txtKosuAdimUzunluk.Location = new Point(73, 51);
            txtKosuAdimUzunluk.Name = "txtKosuAdimUzunluk";
            txtKosuAdimUzunluk.Size = new Size(228, 27);
            txtKosuAdimUzunluk.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(73, 28);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 12;
            label3.Text = "Ortalama Adım Uzunluğu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label7.Location = new Point(22, 65);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 20;
            label7.Text = "KOŞU İÇİN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(numericUpDownDakika);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtYurumeAdimSayisi);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(numericUpDownSaat);
            groupBox2.Controls.Add(txtYurumeAdimUzunluk);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(22, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 208);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(333, 134);
            label8.Name = "label8";
            label8.Size = new Size(17, 28);
            label8.TabIndex = 17;
            label8.Text = ":";
            // 
            // numericUpDownDakika
            // 
            numericUpDownDakika.Location = new Point(356, 135);
            numericUpDownDakika.Name = "numericUpDownDakika";
            numericUpDownDakika.Size = new Size(185, 27);
            numericUpDownDakika.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(142, 112);
            label9.Name = "label9";
            label9.Size = new Size(392, 20);
            label9.TabIndex = 16;
            label9.Text = "Yürüme Süresi:(Önce Saat ve ardından Dakika Ör: 1:30)";
            // 
            // txtYurumeAdimSayisi
            // 
            txtYurumeAdimSayisi.Location = new Point(394, 51);
            txtYurumeAdimSayisi.Name = "txtYurumeAdimSayisi";
            txtYurumeAdimSayisi.Size = new Size(233, 27);
            txtYurumeAdimSayisi.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(394, 28);
            label10.Name = "label10";
            label10.Size = new Size(267, 20);
            label10.TabIndex = 14;
            label10.Text = "Ortalama Adım Sayısı (1 Dakika için):";
            // 
            // numericUpDownSaat
            // 
            numericUpDownSaat.Location = new Point(142, 135);
            numericUpDownSaat.Name = "numericUpDownSaat";
            numericUpDownSaat.Size = new Size(185, 27);
            numericUpDownSaat.TabIndex = 19;
            // 
            // txtYurumeAdimUzunluk
            // 
            txtYurumeAdimUzunluk.Location = new Point(73, 51);
            txtYurumeAdimUzunluk.Name = "txtYurumeAdimUzunluk";
            txtYurumeAdimUzunluk.Size = new Size(228, 27);
            txtYurumeAdimUzunluk.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(73, 28);
            label11.Name = "label11";
            label11.Size = new Size(191, 20);
            label11.TabIndex = 12;
            label11.Text = "Ortalama Adım Uzunluğu:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label12.Location = new Point(22, 328);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 22;
            label12.Text = "YÜRÜME İÇİN";
            // 
            // btnGelismisHesapla
            // 
            btnGelismisHesapla.BackColor = Color.SteelBlue;
            btnGelismisHesapla.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGelismisHesapla.ForeColor = Color.Transparent;
            btnGelismisHesapla.Location = new Point(22, 565);
            btnGelismisHesapla.Name = "btnGelismisHesapla";
            btnGelismisHesapla.Size = new Size(148, 70);
            btnGelismisHesapla.TabIndex = 23;
            btnGelismisHesapla.Text = "Hesapla";
            btnGelismisHesapla.UseVisualStyleBackColor = false;
            btnGelismisHesapla.Click += btnGelismisHesapla_Click;
            // 
            // AdvancedCalculationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 678);
            Controls.Add(btnGelismisHesapla);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdvancedCalculationForm";
            Text = "AdvancedCalculationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuSaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosuDakika).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDakika).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private NumericUpDown numericUpDownKosuSaat;
        private Label label5;
        private TextBox txtKosuAdimSayisi;
        private Label label4;
        private NumericUpDown numericUpDownKosuDakika;
        private TextBox txtKosuAdimUzunluk;
        private Label label3;
        private Label label7;
        private GroupBox groupBox2;
        private Label label8;
        private NumericUpDown numericUpDownDakika;
        private Label label9;
        private TextBox txtYurumeAdimSayisi;
        private Label label10;
        private NumericUpDown numericUpDownSaat;
        private TextBox txtYurumeAdimUzunluk;
        private Label label11;
        private Label label12;
        private Button btnGelismisHesapla;
    }
}