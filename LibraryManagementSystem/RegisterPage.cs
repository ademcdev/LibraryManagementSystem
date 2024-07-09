using LibraryManagementSystem.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.helpers;

namespace LibraryManagementSystem
{
    public partial class RegisterPage : Form
    {
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        database.dbConfig db = new database.dbConfig();

        public RegisterPage()
        {
            InitializeComponent();
            InitializeTextBoxPlaceholders();
        }

        private void InitializeTextBoxPlaceholders()
        {
            SetPlaceholder(textBoxName, "Adınız...");
            SetPlaceholder(textBoxSurname, "Soyadınız...");
            SetPlaceholder(textBoxPhone, "Telefon Numaranız...");
            SetPlaceholder(textBoxEmail, "E-posta adresiniz...");
            SetPlaceholder(textBoxPassword, "Şifreniz...");
            SetPlaceholder(textBoxConfirmPassword, "Şifrenizin tekrarı...");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            placeholders[textBox] = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += RemovePlaceholder;
            textBox.LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == placeholders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string managerName = textBoxName.Text.Trim();
            string managerSurname = textBoxSurname.Text.Trim();
            string managerPhone = textBoxPhone.Text.Trim();
            string managerEmail = textBoxEmail.Text.Trim();
            string managerPassword = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            if (managerPassword != confirmPassword)
            {
                MessageBox.Show("Şifreler Eşleşmiyor", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.AddManager(managerName, managerSurname, managerPhone, managerEmail, managerPassword))
            {
                MessageBox.Show("Kayıt Başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
