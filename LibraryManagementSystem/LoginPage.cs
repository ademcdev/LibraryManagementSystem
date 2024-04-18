using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LibraryManagementSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            AcceptButton = buttonLogin;
        }

        private string msg, caption, prompt, title;

        private void textBoxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUsername.Text == "Kullanıcı Adı...")
            {
                textBoxUsername.Clear();
            }
        }

        private void textBoxPswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxPswd.PasswordChar = '*';
        }

        private void textBoxPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPswd.Text == "Şifre...")
            {
                textBoxPswd.Clear();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == "admin" && textBoxPswd.Text.Trim() == "admin")
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            msg = "Programı kapatmak istiyor musunuz?";
            caption = "Emin misiniz?";
            MessageBoxButtons buttonExit = MessageBoxButtons.YesNo;
            MessageBoxIcon iconExit = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(msg, caption, buttonExit, iconExit, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
