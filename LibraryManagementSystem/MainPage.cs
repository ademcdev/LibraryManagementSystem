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
//icon source: https://www.flaticon.com/free-icons

namespace LibraryManagementSystem
{   
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            //menuStripMain.BackColor = Color.Transparent;
        }

        private string msg, caption, prompt, title;

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookPage addBook = new AddBookPage();
            addBook.Show();
        }

        private void showBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
