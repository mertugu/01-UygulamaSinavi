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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            // RegisterForm'u gösteriyor // ayrıca loginfrmuna geçiş yapılamaz
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarının boş olup olmadığı kontrolü
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer boşsa, işlemi burada sonlandır
            }

            // Kayıtlı kullanıcıları tutan dosyamızı oku
            string fileDosyaYolu = Path.Combine(Application.StartupPath, "users.txt");

            try
            {
                bool loginSuccess = false;
                using (StreamReader sr = new StreamReader(fileDosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string fileUsername = parts[0];
                            string filePassword = parts[1];
                            if (fileUsername == txtUsername.Text && filePassword == txtPassword.Text)
                            {
                                loginSuccess = true;
                                break;
                            }
                        }
                    }
                }

                if (loginSuccess)
                {
                    // Giriş başarılı olursa, Form1'i aç
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.Closed += (s, args) => this.Close(); // Anaform kapadığmızda login formunu kapatmayı yapıyoruz
                    mainForm.Show();
                }
                else
                {
                    // Giriş başarısız, hata mesajı göster
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

