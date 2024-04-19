using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            database.dbConfig db = new database.dbConfig();
            DataTable dataTable = db.GetBook();
            DataTable dataTable1 = db.GetStudent();

            dataGridViewBook.DataSource = dataTable;
            dataGridViewStudent.DataSource = dataTable1;
        }
    }
}
