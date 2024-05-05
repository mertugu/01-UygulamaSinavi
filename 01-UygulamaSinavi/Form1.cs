namespace _01_UygulamaSinavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool GirdiKontrol(string input)
        {
            //kullan�c� bo� b�rakt� m� kontrol� yapt�k
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Ortalama ad�m say�s� bo� b�rak�lamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // kullan�c� tamsay� girdi mi girmedi mi kontrol ediyoruz
            if (!int.TryParse(input, out int stepCount))
            {
                MessageBox.Show("Ortalama ad�m say�s� i�in ge�erli bir tam say� giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 'txtAdimSayisi' giri�ini kontrol et
            if (!GirdiKontrol(txtAdimSayisi.Text))
            {
                return; // E�er giri� ge�erli de�ilse, i�lemi durdur
            }

            try
            {
                // Kullan�c�dan de�erleri al�yoruz
                double adimUzunluk = Convert.ToDouble(txtAdimUzunluk.Text); // cm cinsinden
                                                                            //txtAdimsayisini kontrol ettik metodumuzda o y�zden es ge�tik.                                                           
                int adimSayisi = int.Parse(txtAdimSayisi.Text);
                int kosuSaat = Convert.ToInt32(numericUpDownKosuSaat.Value);
                int kosuDakika = Convert.ToInt32(numericUpDownKosuDakika.Value);

                // Toplam ko�u s�resini dakikaya g�re hesaplad�k
                int toplamKosuSuresi = (kosuSaat * 60) + kosuDakika;

                // Ko�u mesafesini hesaplayoruz (Kilometre cinsindenyapt�k burada)
                double kosuMesafesi = (adimSayisi * adimUzunluk * toplamKosuSuresi) / 100000.0;

                // Sonucu yazd�r
                MessageBox.Show("Toplam Ko�u Mesafesi: " + kosuMesafesi.ToString("0.00") + " kilometre", "Sonu�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata yakalama
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdvancedCalculationForm advancedForm = new AdvancedCalculationForm();
            advancedForm.ShowDialog(); 
        }
    }
}
