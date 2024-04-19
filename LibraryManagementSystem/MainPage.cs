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

        private void MainPage_Load(object sender, EventArgs e)
        {
            database.dbConfig db = new database.dbConfig();

            int TotalBookCount = db.GetTotalBookCount();
            int TotalStudentCount = db.GetTotalStudentCount();

            labelBookCount.Text = TotalBookCount.ToString();
            labelMemberCount.Text = TotalStudentCount.ToString();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void öğrencileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.Show();
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
