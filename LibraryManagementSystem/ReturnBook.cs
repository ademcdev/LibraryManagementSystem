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
    public partial class ReturnBook : Form
    {
        private database.dbConfig db;
        private DataTable dataTable;

        public ReturnBook()
        {
            InitializeComponent();
            db = new database.dbConfig();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataTable = db.GetBook();
            dataGridViewBook.DataSource = dataTable;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
