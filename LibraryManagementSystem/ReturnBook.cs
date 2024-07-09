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
            LoadData();
        }

        private void LoadData()
        {
            dataTable = db.GetBorrowedBook();
            dataGridViewBook.DataSource = dataTable;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir öğrenci ve kitap seçin!");
                return;
            }
            else
            {
                int bookId = Convert.ToInt32(dataGridViewBook.SelectedRows[0].Cells["bookId"].Value);
                int borrowId = Convert.ToInt32(dataGridViewBook.SelectedRows[0].Cells["borrowId"].Value);
                bool bookReturned = db.ReturnBook(bookId, borrowId);

                if (bookReturned)
                {
                    MessageBox.Show("İşlem başarılı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Kitap geri eklerken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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