using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_UygulamaSinavi
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;

            // hata kontrol yönetimi
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }
            // password eşleşiyor mu kontrol ediyorz
            if (password != repeatPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            // Dosya yolu
            string filePath = Path.Combine(Application.StartupPath, "users.txt");

            // Kullanıcı bilgisini dosyaya yazıyoz
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{username},{password}");
            }

            MessageBox.Show("Kullanıcı kaydedildi.");
            this.Close(); // formu kapadık
        }
    }
}
