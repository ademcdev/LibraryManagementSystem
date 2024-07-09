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

        database.dbConfig db = new database.dbConfig();
        private DataTable dataTable;

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0 || dataGridViewBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir öğrenci ve kitap seçin!");
                return;
            }
            else
            {
                int studentId = Convert.ToInt32(dataGridViewStudent.SelectedRows[0].Cells["studentId"].Value);
                int bookId = Convert.ToInt32(dataGridViewBook.SelectedRows[0].Cells["bookId"].Value);
                DateTime borrowDate = dateTimePickerBorrowDate.Value;
                DateTime returnDate = dateTimePickerReturnDate.Value;

                bool bookBorrowed = db.BorrowBook(studentId, bookId, borrowDate, returnDate);

                if (bookBorrowed)
                {
                    MessageBox.Show("İşlem başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Kitap ödünç verirken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadData()
        {
            DataTable dataTable = db.GetAvailableBook();
            DataTable dataTable1 = db.GetStudent();

            dataGridViewBook.DataSource = dataTable;
            dataGridViewStudent.DataSource = dataTable1;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadData();
                return;
            }

            var filteredRows = dataTable.AsEnumerable().Where(row =>
                row.Field<string>("bookName").ToLower().Contains(searchTerm) ||
                row.Field<string>("bookAuthor").ToLower().Contains(searchTerm));

            if (filteredRows.Any())
            {
                dataGridViewBook.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                dataGridViewBook.DataSource = dataTable.Clone();
            }
        }
    }
}
