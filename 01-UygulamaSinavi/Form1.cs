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
            //kullanýcý boþ býraktý mý kontrolü yaptýk
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Ortalama adým sayýsý boþ býrakýlamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // kullanýcý tamsayý girdi mi girmedi mi kontrol ediyoruz
            if (!int.TryParse(input, out int stepCount))
            {
                MessageBox.Show("Ortalama adým sayýsý için geçerli bir tam sayý giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 'txtAdimSayisi' giriþini kontrol et
            if (!GirdiKontrol(txtAdimSayisi.Text))
            {
                return; // Eðer giriþ geçerli deðilse, iþlemi durdur
            }

            try
            {
                // Kullanýcýdan deðerleri alýyoruz
                double adimUzunluk = Convert.ToDouble(txtAdimUzunluk.Text); // cm cinsinden
                                                                            //txtAdimsayisini kontrol ettik metodumuzda o yüzden es geçtik.                                                           
                int adimSayisi = int.Parse(txtAdimSayisi.Text);
                int kosuSaat = Convert.ToInt32(numericUpDownKosuSaat.Value);
                int kosuDakika = Convert.ToInt32(numericUpDownKosuDakika.Value);

                // Toplam koþu süresini dakikaya göre hesapladýk
                int toplamKosuSuresi = (kosuSaat * 60) + kosuDakika;

                // Koþu mesafesini hesaplayoruz (Kilometre cinsindenyaptýk burada)
                double kosuMesafesi = (adimSayisi * adimUzunluk * toplamKosuSuresi) / 100000.0;

                // Sonucu yazdýr
                MessageBox.Show("Toplam Koþu Mesafesi: " + kosuMesafesi.ToString("0.00") + " kilometre", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
