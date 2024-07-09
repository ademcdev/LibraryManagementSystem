using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.database;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            InitializeTextBoxPlaceholders();
            AcceptButton = buttonLogin;
        }

        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        database.dbConfig db = new database.dbConfig();

        private void InitializeTextBoxPlaceholders()
        {
            SetPlaceholder(textBoxEmail, "E-postanızı giriniz...");
            SetPlaceholder(textBoxPassword, "Şifreniz");
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

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string managerEmail = textBoxEmail.Text.Trim();
            string managerPassword = textBoxPassword.Text.Trim();

            if (db.ValidateManager(managerEmail, managerPassword))
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
